using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProgam
{
    internal class Stopwatch
    {
        DateTime timeSpan = DateTime.Now;
        public void start()
        {
            int startHr = timeSpan.Hour;
            int startMin = timeSpan.Minute;
            int startSec = timeSpan.Second;
            int startMilliSec = timeSpan.Millisecond;
            Console.WriteLine("Wait and passs x for exit");
            string data = Console.ReadLine().ToLower();
            if (data.Equals("x"))
            {
                DateTime timeSpan1 = DateTime.Now;
                int endHr = timeSpan1.Hour;
                int endMin = timeSpan1.Minute;
                int endSec = timeSpan1.Second;
                int endMilllisec = timeSpan1.Millisecond;
                Console.WriteLine("Hours is : " + (endHr - startHr) + "\n Minutes is :  " + (endMin - startMin) + " \n Second is : " + (endSec - startSec)
                    +" \n MilliSeconds : "+(endMilllisec - startMilliSec));
            }
        }
    }
}
