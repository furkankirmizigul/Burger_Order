using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220320_Burger_Order
{
    public class Burger:Food
    {
        public Burger(string burgerName)
        {
            BurgerType = burgerName;
        }
        public string BurgerType { get; set; }


        public override string ToString()
        {
            return BurgerType;
        }

    }
}
