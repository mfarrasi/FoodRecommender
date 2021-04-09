using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLibrary
{
    public class Food
    {
        public string HowHungry(double hungryLevel)
        {
            string x = "please insert a number within the paramaeters";
            string y = "please insert a digit within the parameters";
            string a = "click less";
            string b = "click more";
            if (hungryLevel > 10)
            {
                return x;
            }
            else if (hungryLevel < 1)
            {
                return y;
            }
            else if (hungryLevel >= 1 && hungryLevel <= 5)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
