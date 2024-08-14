using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Events
{
    internal class Alarme
    {
        public event EventHandler<AlerteEventArgs> Alarm;

        public void  SurveillerTemperature(int temperature)
        {
            if (temperature > 10)
            {
                this.Alarm?.Invoke(this, new AlerteEventArgs(temperature));
            }
        }

    }
}
