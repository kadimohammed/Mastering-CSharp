using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Events
{
    internal class AlerteEventArgs : EventArgs
    {
        public int tempErature { get; set; }

        public AlerteEventArgs(int tempErature)
        {
            this.tempErature = tempErature;
        }
    }
}
