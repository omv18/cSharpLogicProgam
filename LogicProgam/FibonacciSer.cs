using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProgam
{
    internal class FibonacciSer
    {
        public void fiboSer(int num)
        {
            int a = 0 ,b = 1;
            Console.Write("Fibonacci Series is : "+ a + " " + b);
            for(int i =0; i < num; i++)
            {
                int c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
            
        }
    }
}
