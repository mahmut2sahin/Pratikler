using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace soru_1
{
    class Functions
    {
        public static bool IsPrime(int value)
        {
            for (int i = 0; i < value; i++)
            {
                if (value != (i + 1) && i != 0 && value % (i + 1) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static double GetAverage(ArrayList list)
        {
            double avg = 0.0;
            foreach (var item in list)
            {
                avg += Convert.ToDouble(item);
            }
            return avg / list.Count;
        }
    }
}