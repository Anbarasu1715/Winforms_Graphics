﻿using System;
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

        public enum Position {
            Left,
            Right
        }

        public Position GetPosition { get; set; }
        public int CornerRadius { get; set; }

        public string Msg { get; set; }
        public Point Location { get; set; }
        public DateTime TimeStamp { get; set; }

        public Manager(string s) {
            Msg = s;
            TimeStamp = DateTime.Now;
        }

        public Manager() {

        }
    }
}
