using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleWinForms
{
    public static class Utilities
    {
        public static int HoursToZeroAngle(int hours)
        {
            return (360 / 12) * (hours % 12);
        }

        public static int MinutesToZeroAngle(int minutes)
        {
            return (360 / 60) * minutes;
        }

        public static int GetAngle(int hoursAngleToZero, int minutesAngleToZero)
        {
            return Math.Abs(hoursAngleToZero - minutesAngleToZero);
        }

    }
}
