using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTestClassLibrary.EX2
{
    public class Clock
    {
        public static int GeGetClockAngle(int hours, int minutes)
        {
            if (minutes == 60)
            {
                minutes = 0;
                hours++;
            }
            if (hours >= 12)
                hours -= 12;

            int hourSlots = hours * 5;

            int angle = hourSlots > minutes ? (hourSlots - minutes) * 6 : (minutes - hourSlots) * 6;
            return angle > 180 ? 180-(angle - 180) : angle;
        }
    }
}
