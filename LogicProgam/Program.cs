using System;
namespace LogicProgam
{
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciSer fibSer = new FibonacciSer();
            fibSer.fiboSer(9);
            PerfectNum armStrong = new PerfectNum();
            if (armStrong.perfectCheck(28))
                Console.WriteLine("\n Given Number is Perfect Number");
            else
                Console.WriteLine("\n Given Number is not a Perfect Number");

            //UC3
            PrimeEven primeEven = new PrimeEven();
            primeEven.checkPrime(12222);


        }
    }

}

