﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class HadaP1
    {
        public static double Seconds2Minutes (double s)
        {
            double min = 0;

            if (s != 0)
            {
                min = s / 60;
            }

            return min;
        }

        public static double Minutes2Seconds (double m)
        {
            double sec = 0;

            sec = m * 60;

            return sec;
        }
    }
}
