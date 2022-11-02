using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProgam
{
    internal class PerfectNum
    {
        int sum = 0;
        public bool perfectCheck(int num)
        {
            
            for(int i = 1; i <= num/2; i++)
            {
                if(num%i == 0)
                {
                    sum += i;
                }
            }
            if(sum == num)
                return true;
            return false;
        }
    }
}
