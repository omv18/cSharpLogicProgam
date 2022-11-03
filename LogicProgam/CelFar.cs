using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProgam
{
    internal class CelFar
    {
        public float celcuisConvert(float num)
        {
            float fahrenheit;
            fahrenheit = (num * 9 / 5) + 32;
            return fahrenheit;
        }

        public float fahrenhiteConvert(float num)
        {
            float celcius;
            celcius = (num - 32) * 5 / 9;
            return celcius;
        }
    }
}
