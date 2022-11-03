using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProgam
{
    internal class CouponNumber
    {
    /*    Random random = new Random();
        int[] arr = new int[100];
        bool flag = true;
        public int generateCoupon(int num)
        {
            int coupNum = random.Next(1, num*1000);
            return coupNum;
        }
        public bool checkDistinct(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = i + 1; j < num; j++)
                {
                    //Console.WriteLine("I :{0} " + arr[i] + "  J {1}:" + arr[j] + " ", i, j);
                    int a = arr[i];
                    int b = arr[j];
                    int z = a.CompareTo(b);
                    if (z == 0)
                    {
                        flag = false;
                    }
                }
            }
            return flag;
        }
        public void coupon(int num)
        {
            for(int i = 0; i < num; i++)
            {
                int coupNum;
                coupNum = generateCoupon(num);
                arr[i] = coupNum;
                //Console.Write(arr[i]+"  ");   
            }
            bool checkDis = checkDistinct(num);
            if (flag) 
                Console.WriteLine("Coupons are the distinct.");
            else
                Console.WriteLine("Coupons are the NOT distinct.");
        }*/

        public static int GenerateRandon()
        {
            Random rand = new Random();
            int randomNum = rand.Next(0, 11);
            return randomNum;
        }

        public static void checkCoupon(int num)
        {
            int[] arr = new int[num];
            for(int i = 0; i < arr.Length; i++)
            {
                int count=0;
                int randonCoupon = GenerateRandon();
                for(int j = 0; j <= i; j++)
                {
                    if (arr[j] == randonCoupon) 
                        count++;
                }
                if (count == 0) 
                    arr[i] = randonCoupon;
            }

            foreach(var data in arr)
            {
                if(data != 0)
                {
                    Console.WriteLine(data);
                }
            }
        }
    }
}
