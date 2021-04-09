using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLibrary
{
    public class FlavorB
    {
        public string HowHungry(string flavor)
        {
            if (flavor == "savory")
            {
                string x = "pizza, ayam geprek, etc.";
                return x;
            }
            else
            {
                string y = "nasi padang, paket ayam di kfc, mie keroyokan";
                return y;
            }
        }
    }
}
