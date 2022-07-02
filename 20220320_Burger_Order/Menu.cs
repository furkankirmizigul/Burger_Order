using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220320_Burger_Order
{
   
    public class Menu
    {
        public Menu(string menuName,double menuPrice)
        {
            Name = menuName;

            string burgerName = menuName + " burger";
            CreateBurger(burgerName);
            MenuPrice = menuPrice;
        }
        
        public Menu(string menuName,string burger,double burgerPrice/*,string drink,params string[] sauces,string sauce*/)
        {
            Name = menuName;
            MenuPrice = burgerPrice + 10;
            CreateBurger(burger);
            //CreateDrink(drink);
            //CreateSauce(sauce);

        }
        public double MenuPrice { get; set; }
        public string Name { get; set; }
        public Burger BurgerSelection { get; set; }

        public Drink DrinkSelection { get; set; }

        public Sauce SauceSelection { get; set; }

        

        void CreateBurger(string burgerName)
        {
            Burger burger= new Burger(burgerName);
            BurgerSelection=burger;
            //Lists.burgers.Add(burger);
        }
        void AddDrink(string drinkName)
        {
            Drink drink = new Drink(drinkName);
            DrinkSelection = drink;
            //Lists.drinks.Add(drink);
        }
        void AddSauce(string sauceName)
        {
            Sauce sauce = new Sauce(sauceName);
            SauceSelection = sauce;
            //Lists.sauces.Add(sauce);
        }

        public override string ToString()
        {
            return Name+" ("+BurgerSelection.ToString()+")";
        }
    }
}
