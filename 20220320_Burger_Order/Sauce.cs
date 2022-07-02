using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220320_Burger_Order
{
    public class Sauce:Food
    {
        public Sauce(string sauceName)
        {
            this.Name = sauceName;
            this.Price = 2;
        }
        public Sauce(string sauceName,double saucePrice)
        {
            this.Name = sauceName;
            this.Price = saucePrice;
        }

        

        public override string ToString()
        {
            return Name;
        }
    }
}
