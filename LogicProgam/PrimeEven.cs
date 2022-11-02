using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProgam
{
    internal class PrimeEven
    {
        int count = 0;
        public void checkPrime(int num)
        {
            for(int i= 2; i <= num; i++)
            {
                for(int j= 2; j <= i; j++)
                {
                    if (i % j == 0)
                        count++;
                }
                if (count == 1)
                    Console.Write("\n " + i + " ");
            }
        }
    }
}
