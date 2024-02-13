using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += CheckNotifications;
        }

        private Timer timer;
        private String Position;
        private Dictionary<Notification, Manager> ExtraNotifications = new Dictionary<Notification, Manager>();
        private Dictionary<Notification, Manager> notifications = new Dictionary<Notification, Manager>();


        private void CheckNotifications(object sender, EventArgs e)
        {
            int X;
            if (Position == "Right")
                X = 0;
            else
                X = 1545;

            Point firstLoc = new Point(X, 930);

            List<Notification> notificationsToRemove = new List<Notification>();
            List<Notification> ExtraNotificationsToRemove = new List<Notification>();

            foreach (KeyValuePair<Notification, Manager> kvp in notifications)
            {
                DateTime currentTime = DateTime.Now;
                TimeSpan timeGap = currentTime - kvp.Value.TimeStamp;

                if (timeGap.TotalSeconds >= 10)
                {
                    notificationsToRemove.Add(kvp.Key);
                }
                else
                {
                    kvp.Key.Location = firstLoc;
                    kvp.Value.Location = firstLoc;
                    firstLoc.Y -= (kvp.Key.Height + 5);
                }
            }

            foreach (var notificationToRemove in notificationsToRemove)
            {
                notificationToRemove.Close();
                notifications.Remove(notificationToRemove);
            }

            if (notifications.Count < 9)
            {
                foreach (var kvp in ExtraNotifications)
                {
                    if (notifications.Count < 9)
                    {
                        notifications.Add(kvp.Key, kvp.Value);
                        kvp.Key.Show();
                        ExtraNotificationsToRemove.Add(kvp.Key);
                    }
                }
            }

            foreach (var n in ExtraNotificationsToRemove)
            {
                ExtraNotifications.Remove(n);
            }
        }


        private void removeClosedNotification(Object sender,EventArgs e) {
            notifications.Remove((sender as Notification));
            CheckNotifications(sender, e);
        }
        

        
        int c = 0;
        public void GenerateNotification(object sender,EventArgs e) {
            Notification notification = new Notification();

            //string Text = (sender as Button).Text;
            string Text =textBox1.Text;
            Manager Data = new Manager(Text);
            Position=manager1.GetPosition +"";

            Rectangle screen = (Screen.PrimaryScreen.Bounds);

            int Y = screen.Height- notification.Height-40;
            int X;

            if (Position=="Right") {
                X = 0;
            }
            else
                X = screen.Width-notification.Width - 10;
            int length = notifications.Count;

            Y -= (length * (notification.Height + 5));
            notification.Location = new Point(X,Y);
            notification.OnExit += removeClosedNotification;
            Data.Location = notification.Location;

            //notification.SetText((sender as Button).Text);
            notification.SetText(Text);

            if (notifications.Count >= 9)
            {
                ExtraNotifications.Add(notification, Data);
            }
            else if (ExtraNotifications.Count == 0)
            {
                notifications.Add(notification, Data);
                notification.Show();
            }
            
            timer.Start();
            c++;
        }

    }
}
