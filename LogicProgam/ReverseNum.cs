using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProgam
{
    internal class ReverseNum
    {
        public void reverse(int num)
        {
            int reverse =0; 
            Console.WriteLine("Number before Reverse is : " + num);
            while(num > 0)
            {
                int remainder = num % 10;
                reverse = reverse * 10 + remainder;
                
                num /= 10;
            }
            Console.WriteLine("After reverse number is :" + reverse);
        }
    }
}
