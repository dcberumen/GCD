using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
    public class GCDlogic
    {
        public static long computeGCD(long x, long y)
        {
            long GCD = 0;
            long quotient = 0, remainder = 0;
            if (x > y)
            {
                
                quotient = x / y;
                remainder = x % y;
                while (remainder != 0)
                {
                    x = y;
                    y = remainder;
                    quotient = x / y;
                    remainder = x % y;
                }
                GCD = y;
            }
            else if (y > x)
            {
                quotient = y / x;
                remainder = y % x;
                while (remainder != 0)
                {
                    y = x;
                    x = remainder;
                    quotient = y / x;
                    remainder = y % x;
                }
                GCD = x;
            }
            else if(x == y)
            {
                GCD = x;
            }
            return GCD;
        }
    }
}
