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
            timer.Interval = 2000;
            timer.Tick += CheckNotifications;
        }

        private Timer timer;

        private void CheckNotifications(object sender, EventArgs e)
        {
            
        }

        private Dictionary<Notification, Manager> notifications = new Dictionary<Notification, Manager>();

        public void GenerateNotification(object sender,EventArgs e) {
            Notification notification = new Notification();
            Manager Data = new Manager();
            Rectangle screen = (Screen.PrimaryScreen.Bounds);

            string Text = (sender as Button).Text;
            int Y = screen.Height- notification.Height-40;
            int X = screen.Width;
            int length = notifications.Count;

            Y -= (length * (notification.Height + 5));
            notification.Location = new Point(X-notification.Width-10,Y);
            notification.Show();
            Data.AddData(Text,Location);
            notifications.Add(notification,Data);
            textBox1.Text= Data.TimeStamp+"";
            timer.Start();
        }
    }
}
