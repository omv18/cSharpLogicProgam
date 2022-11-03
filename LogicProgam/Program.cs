using System;
namespace LogicProgam
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            Console.WriteLine("1.Fabonacci Series \n 2.Perfect Number \n 3.Prime Even \n 4.Reverse Number " +
                "\n 5.Coupon Number \n 6.CelFar 7. monthly Pay 8.Exit");
            int check = Convert.ToInt32(Console.ReadLine());
            while (flag)
            {
                switch (check)
                {
                    case 1:
                        FibonacciSer fibSer = new FibonacciSer();
                        fibSer.fiboSer(9);
                        break;
                    case 2:
                        PerfectNum armStrong = new PerfectNum();
                        if (armStrong.perfectCheck(28))
                            Console.WriteLine("\n Given Number is Perfect Number");
                        else
                            Console.WriteLine("\n Given Number is not a Perfect Number");
                        break;
                    case 3:
                        PrimeEven primeEven = new PrimeEven();
                        primeEven.checkPrime(12222);
                        break;
                    case 4:
                        ReverseNum rv = new ReverseNum();
                        rv.reverse(122);
                        break;
                    case 5:
                        CouponNumber.checkCoupon(9);
                        //couponNumber.checkCoupon(9);
                        break;
                    case 6:
                        CelFar cf = new CelFar();
                        Console.WriteLine("1. celcius to farhnite \n 2. farnhite to celcius ");
                        int celFar = Convert.ToInt32(Console.ReadLine());
                        if (celFar == 0)
                        {
                            float f = cf.celcuisConvert(99);
                            Console.WriteLine("celcius to farnhite is " + f);
                        }
                        else
                        {
                            float c = cf.fahrenhiteConvert(99);
                            Console.WriteLine("Franhite to celcius is : " + c);
                        }
                         break;
                case 7:
                    MonthlyPay.momthlyPayment();
                    break;
                    default:
                            break;
                }
            }
        }
    }

}

