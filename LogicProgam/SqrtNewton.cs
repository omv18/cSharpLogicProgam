using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProgam
{
    internal class SqrtNewton
    {
        public static double calSqrt(double c)
        {
            double l=0.000000000000001;
            double t = c;
            double squrt;
            //t = (0.5 * ((c / t) + t));
            while (true)
            {
                squrt = (0.5 * ((c / t) + t));
                if (Math.Abs(squrt - t) < l)
                    break;
                t = squrt;
            }

            return t;
        }
    }
}
