using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLibrary
{
    public class FlavorA : FlavorProfile1
    {
        public string HowHungry(string flavor)
        {
            if (flavor == "sweet")
            {
                string x = "crackers, bread, etc.";
                return x;
            }
            else
            {
                string y = "crackers, chips, fries, etc.";
                return y;
            }
        }
        public override string Food1()
        {
            throw new NotImplementedException();
        }
    }
}
