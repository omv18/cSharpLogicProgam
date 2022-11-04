using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogicProgam
{
    internal class VendingMachine
    {
        int[] money = {1,2,5,10,50,100,500,1000};
        int[] ch = { 0, 0, 0, 0, 0, 0, 0, 0 };
        int totalChange = 0;  
        public void inputMoney(int num)
        {
            vendingMachime(num);
            Console.WriteLine("Minnimum note for change is : "+totalChange);
            foreach(int i in ch)
            {
                Console.Write(i + "   ");
            }
            Console.WriteLine();
        }
        public int findIndex(int num)
        {
            int i;
            for(i=0; i <money.Length; i++)
            {
                if ((money[i] <= num) && (money[i + 1] >= num))
                    break;
            }
            return i;
        }
        public void vendingMachime(int num)
        {
            int index = findIndex(num);
            int chIndex = index;
            Console.WriteLine("index is :" + index + "   "+money[index]);
            if (num == 0) return;
            if(num == 1)
            {
                totalChange++;
                ch[0] += 1;
                return;
            }
/*            if (num == 2)
            {
                totalChange += 2;
                ch[index] += 2;
            }*/
            if (num % money[index] == 0)
            {
                int add = num / money[index];
/*                if (index < 1)
                {
                    index++;
                    ch[index] += index;
                }*/
                totalChange += add;
                ch[index] += add;
                return;
            }
            int change2 = num / money[index];
            totalChange+=change2;
            ch[index] += change2;
            num = num % money[index];
            vendingMachime(num);  
        }
    }
}
