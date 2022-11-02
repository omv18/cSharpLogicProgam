using System;
namespace LogicProgam
{
    class Program
    {
        static void Main(string[] args)
        {
            int check = 4;
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

            }
        }
    }

}

