using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProgam
{
    internal class MonthlyPay
    {
        public static void momthlyPayment()
        {
            double P, Y, R;
            Console.WriteLine("Enter the principal loan amount : ");
            P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the year to pay off");
            Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the percent interest compounded monthly.");
            R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(P);
            double r = R/(12 * 100);
            double n = 12 * Y;
            double payment = (P * r) / (1 - Math.Pow((1 + r), (-n)));
            Console.WriteLine("Payment is "+payment);


        }
    }
}
