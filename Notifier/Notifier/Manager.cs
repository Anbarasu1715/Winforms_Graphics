using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifier
{
    class Manager:Component
    {
        public string Msg { get; set; }
        public Point Location { get; set; }
        public DateTime TimeStamp { get; set; }

        public List<Manager> Datas = new List<Manager>();

        public void AddData(string msg, Point loc) {
            var Data = new Manager() {
                Msg = msg,
                Location = loc,
                TimeStamp = DateTime.Now
            };

            Datas.Add(Data);
        }
    }
}
