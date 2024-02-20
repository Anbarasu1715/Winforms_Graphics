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
        private MsgBox MBox;
        private Rectangle screen;
        private int timeInterval = 10;
        private OrderedDictionary<Notification, Manager> ExtraNotifications = new OrderedDictionary<Notification, Manager>();
        private OrderedDictionary<Notification, Manager> notifications = new OrderedDictionary<Notification, Manager>();

        //private List<KeyValuePair<Notification, Manager>> ExtraNotifications = new List<KeyValuePair<Notification, Manager>>();
        //private List<KeyValuePair<Notification, Manager>> notifications = new List<KeyValuePair<Notification, Manager>>();

        private List<Notification> notificationsToRemove = new List<Notification>();
        private List<Notification> ExtraNotificationsToRemove = new List<Notification>();

        //private void check() {
        //    int X;
        //    if (Position == "Right")
        //        X = 0;
        //    else
        //        X = 1545;



        //    if (notifications.Count() > 0)
        //    {
        //        Point firstLoc = new Point(X, screen.Height - 35);

        //        foreach (KeyValuePair<Notification, Manager> kvp in notifications.Items)
        //        {
        //            DateTime currentTime = DateTime.Now;
        //            TimeSpan timeGap = currentTime - kvp.Value.TimeStamp;

        //            if (timeGap.TotalSeconds >= timeInterval)
        //            {
        //                notificationsToRemove.Add(kvp.Key);
        //            }
        //            else
        //            {
        //                firstLoc.Y -= (kvp.Key.Height + 5);
        //                kvp.Key.Location = firstLoc;
        //                kvp.Value.Location = firstLoc;
        //            }
        //        }
        //    }
        //}

        //private void CheckNotifications(object sender, EventArgs e)
        //{
        //    //int X;
        //    //if (Position == "Right")
        //    //    X = 0;
        //    //else
        //    //    X = 1545;



        //    //if (notifications.Count > 0)
        //    //{
        //    //    Point firstLoc = new Point(X, screen.Height - 35);

        //    //    foreach (KeyValuePair<Notification, Manager> kvp in notifications)
        //    //    {
        //    //        DateTime currentTime = DateTime.Now;
        //    //        TimeSpan timeGap = currentTime - kvp.Value.TimeStamp;

        //    //        if (timeGap.TotalSeconds >= timeInterval)
        //    //        {
        //    //            notificationsToRemove.Add(kvp.Key);
        //    //        }
        //    //        else
        //    //        {
        //    //            firstLoc.Y -= (kvp.Key.Height + 5);
        //    //            kvp.Key.Location = firstLoc;
        //    //            kvp.Value.Location = firstLoc;
        //    //        }
        //    //    }
        //    //}
        //    check();

        //    int Y = 0;

        //    foreach (var notificationToRemove in notificationsToRemove)
        //    {
        //        //Y = notifications[notificationToRemove].Location.Y;
        //        notificationToRemove.Close();
        //        notifications.Remove(notificationToRemove);
        //    }

        //    notificationsToRemove.Clear();

        //    check();

        //    if (notifications.Count() > 0)
        //        Y = notifications.Keys.Last().Location.Y;

        //    if (ExtraNotifications.Count()>0 && Y-ExtraNotifications.Keys.First().Height-35 >= 0)
        //    {
        //        for (int i = 0; i < ExtraNotifications.Count(); i++)
        //        {
        //            if (notifications.Keys.Last().Location.Y - ExtraNotifications.Keys.First().Height - 35 >= 0)
        //            {
        //                notifications.Add(ExtraNotifications.Keys.First(), ExtraNotifications[ExtraNotifications.Keys.First()]);
        //                notifications.Keys.First().Show();
        //                notifications[notifications.Keys.Last()].TimeStamp = DateTime.Now;
        //                ExtraNotifications.Remove(ExtraNotifications.Keys.First());
        //                check();
        //                i--;
        //            }
        //            else
        //            {
        //                break;
        //            }
        //        }
        //    }

        //}

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


        private void removeClosedNotification(Object sender,EventArgs e)
        {
            notifications.Remove((sender as Notification));
            CheckNotifications(sender, e);
        }

        

        public void GenerateNotification(object sender,EventArgs e)
        {

            MBox?.Dispose();

            //Graphics
            Graphics g = CreateGraphics();
            screen = (Screen.PrimaryScreen.Bounds);
            Notification notification = new Notification();
            
            int lineCount = 0;
            string Text =textBox1.Text;
            string finalText = Text;

            SizeF textSize = g.MeasureString(Text, notification.labelFont());

            if (textSize.Width>notification.labelWidth())
            {
                finalText = "";
                string line = "";
                string[] words = Text.Split(' ');

                foreach (string word in words)
                {
                    if (g.MeasureString(word, notification.labelFont()).Width > notification.labelWidth())
                    {
                        finalText += word.Trim() + Environment.NewLine;
                        line = "";
                        lineCount++;
                    }
                    else if (g.MeasureString(line+word,notification.labelFont()).Width>notification.labelWidth() )
                    {
                        finalText += line.Trim() + Environment.NewLine;
                        line = word+" ";
                        lineCount++;
                    }
                    else
                    {
                        line +=word+" ";
                    }
                }
                finalText += line.Trim();
                lineCount++;
            }

            //Set the Height of the Notification Form
            notification.SetHeight(lineCount,this.Width);

            Manager Data = new Manager(finalText);

            Position =manager1.GetPosition +"";

            int Y = screen.Height - notification.Height-40;
            int X;

            if (Position=="Right")
            {
                X = 0;
            }
            else
                X = screen.Width-notification.Width - 10;


            int NotificationsCount = notifications.Count();

            if (NotificationsCount >= 1)
            {
                Y = notifications[notifications.Keys.Last()].Location.Y - notification.Height-5;
            }

            notification.Location = new Point(X,Y);
            notification.OnExit += removeClosedNotification;
            notification.OnDisplay += DisplayNotification;
            Data.Location = notification.Location;
            Data.Msg = finalText;

            notification.SetText(finalText);

            if (NotificationsCount>0 && notifications[notifications.Keys.Last()].Location.Y - notification.Height<=0)
            {
                ExtraNotifications.Add(notification, Data);
            }
            else if (ExtraNotifications.Count() == 0)
            {
                notifications.Add(notification, Data);
                notification.Show();
            }
            
            timer.Start();
        }

        private void DisplayNotification(object sender, EventArgs e)
        {
            MBox?.Dispose();
            Notification ObjToRemove=null;
            foreach (var kvp in notifications.Items)
            {
                if ((kvp.Key as Notification) == (sender as Notification))
                {
                    ObjToRemove = kvp.Key;
                    string text = kvp.Value.Msg;
                    MBox = new MsgBox();
                    MBox.SetText(text);
                    MBox.Show();
                }
            }
            if (ObjToRemove != null)
                notifications.Remove(ObjToRemove);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MBox?.Dispose();
        }
    }
}
