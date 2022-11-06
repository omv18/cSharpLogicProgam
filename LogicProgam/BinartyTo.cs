using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProgam
{
    internal class BinartyTo
    {
        static int[] arr = new int[32];
        static int count = 0;
        public static void toBinary(int num)
        {
            int num2 = num;
            while (num > 0)
            {
                arr[count] = num % 2;
                num = num / 2;
                count++;
            }
            string s = "";
            while (num2 > 0)
            {
                int remainder = num2 % 2;
                s += remainder.ToString();
                num2 = num2 / 2;
            }
            Console.WriteLine("To Binary conversion of  using String "+ s);
            Console.Write("To Binary conversion of  using Array  ");
            for (int i=0; i < count; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Values of 1 and 0 are : ");
            for(int i=count;i >= 0; i--)
            {
                if(arr[i] != 0)
                {
                    int pow2Value = (int)(Math.Pow(2,i));
                    Console.Write(pow2Value + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
