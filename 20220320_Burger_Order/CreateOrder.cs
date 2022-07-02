using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20220320_Burger_Order
{
    public partial class CreateOrder : Form
    {

        public enum Sizes { Kucuk = 0, Orta = 4, Buyuk = 7 }
        public enum Drinks { Kola, Fanta, Sprite, Şalgam, KFC_Kahve }
        public CreateOrder()
        {
            InitializeComponent();
        }

        List<RadioButton> rbList = new List<RadioButton>();

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            InitialSauces();
            InitialMenus();
            AddMenusToCmbx();
            AddSaucesToFlo();
            upDownOrderAmount.Value = 1;
            upDownOrderAmount.Maximum = 100;
            upDownOrderAmount.Minimum = 1;
            upDownOrderAmount.ReadOnly = true;
            CreateRbSizes();
            cbxDrinks.Items.AddRange(Enum.GetNames(typeof(Drinks)));
        }


        List<CheckBox> cbxList = new List<CheckBox>();
        public void AddSaucesToFlo()
        {
            flo_Sauces.Controls.Clear();

            foreach (Sauce sauce in Lists.sauces)
            {
                CheckBox cbxsauce = new CheckBox();
                cbxsauce.Font = new Font("Microsoft Sans Serif", 12);
                cbxsauce.Text = sauce.ToString();
                cbxList.Add(cbxsauce);
                flo_Sauces.Controls.Add(cbxsauce);
            }
        }
        public void AddMenusToCmbx()
        {
            cbxMenu.Items.Clear();

            foreach (Menu item in Lists.menus)
            {
                cbxMenu.Items.Add(item.Name);
            }
        }
        void CreateRbSizes()
        {
            foreach (string item in Enum.GetNames(typeof(Sizes)))
            {
                RadioButton rbSize = new RadioButton();
                rbSize.Font = new Font("Microsoft Sans Serif", 12);
                rbSize.Text = item;
                rbList.Add(rbSize);
                floSize.Controls.Add(rbSize);
            }
        }


        public void InitialSauces()
        {
            Sauce ketchup = new Sauce("Ketçap", 1);
            Lists.sauces.Add(ketchup);
            Sauce mayonnaise = new Sauce("Mayonez", 1);
            Lists.sauces.Add(mayonnaise);
            Sauce mustard = new Sauce("Hardal", 1);
            Lists.sauces.Add(mustard);
            Sauce buffalo = new Sauce("Bufalo", 2.5);
            Lists.sauces.Add(buffalo);
            Sauce ranch = new Sauce("Ranch", 2.5);
            Lists.sauces.Add(ranch);
            Sauce bbq = new Sauce("BBQ", 2.5);
            Lists.sauces.Add(bbq);

        }

        public void InitialMenus()
        {
            Menu plantyMenu = new Menu("Plant Based Menu", "Planty Burger", 25);
            Menu beanMenu = new Menu("Bean Menu", "Bean Burger", 30);
            Menu flafelMenu = new Menu("Falafel Menu", "Falafel Burger", 20);
            Lists.menus.Add(plantyMenu);
            Lists.menus.Add(beanMenu);
            Lists.menus.Add(flafelMenu);

            //Burger plantyBurger = new Burger();
            //Drink coke = new Drink();
            //plantyMenu.BurgerSelection = plantyBurger;
            //plantyMenu.DrinkSelection = coke;

        }
        public void AddSauce(string sauceName)
        {
            Sauce sauce = new Sauce(sauceName);
            Lists.sauces.Add(sauce);

        }

        double chartPrice = 0;
        string chartString;
        private void btnAddToChart_Click(object sender, EventArgs e)
        {

            CalculateChart(ref chartString, ref chartPrice);
        }



        void MenuSelection(ref string chartString, ref double chartPrice, ref bool isOrderCreated)
        {
            bool isMenuSelected = false;
            foreach (Menu menu in Lists.menus)
            {
                if (menu.Name == cbxMenu.Text)
                {
                    chartPrice += menu.MenuPrice;
                    chartString += menu.ToString();
                    isMenuSelected = true;
                    
                }
            }
            if (isMenuSelected == false)
            {
                MessageBox.Show("Lütfen bir menü seçimi yapınız");
                isOrderCreated = false;
            }


        }
        void DrinkSelection(ref string chartString, ref bool isOrderCreated)
        {
            bool isDrinkSelected = false;
            foreach (string drink in Enum.GetNames(typeof(Drinks)))
            {
                if (drink == cbxDrinks.Text)
                {
                    chartString += ", " + drink;
                    isDrinkSelected = true;
                }

            }
            if (isDrinkSelected == false)
            {
                MessageBox.Show("Lütfen bir içecek seçimi yapınız");
                isOrderCreated = false;
            }
           

        }
        void ClearSelections()
        {
            cbxMenu.SelectedIndex = -1;
            cbxDrinks.SelectedIndex = -1;

            foreach (CheckBox cbx in cbxList)
            {
                cbx.Checked = false;
            }

            foreach (RadioButton rb in rbList)
            {
                rb.Checked = false;
            }
        }
        void SauceSelection(ref string chartString, ref double chartPrice)
        {
            foreach (CheckBox cbx in cbxList)
            {
                if (cbx.Checked)
                {
                    foreach (Sauce sauce in Lists.sauces)
                    {
                        if (sauce.Name == cbx.Text)
                        {
                            chartString += ", " + sauce.Name;
                            chartPrice += sauce.Price;
                        }
                    }
                }
                

            }
        }

        void SizeSelection(ref string chartString, ref double chartPrice, ref bool isOrderCreated)
        {
            int a = 0;
            foreach (RadioButton rb in rbList)
            {

                if (rb.Checked && rb.Text == "Kucuk")
                {
                    chartString += ", Küçük Boy";
                    chartPrice += (int)Enum.Parse(typeof(Sizes), "Kucuk");
                }
                else if (rb.Checked && rb.Text == "Orta")
                {
                    chartString += ", Orta Boy";
                    chartPrice += (int)Enum.Parse(typeof(Sizes), "Orta");
                }
                else if (rb.Checked && rb.Text == "Buyuk")
                {
                    chartString += ", Büyük Boy";
                    chartPrice += (int)Enum.Parse(typeof(Sizes), "Buyuk");
                }
                else if (rb.Checked == false)
                {
                    a++;
                    if (a == 3)
                    {
                        isOrderCreated = false;
                        MessageBox.Show("Lütfen boyut seçimi yapınız");

                    }

                }
              

            }
        }
        public void CalculateChart(ref string chartString, ref double chartPrice)
        {

            bool isOrderCreated = true;
            chartString = null;
            

            MenuSelection(ref chartString, ref chartPrice, ref isOrderCreated);
            DrinkSelection(ref chartString, ref isOrderCreated);
            SauceSelection(ref chartString, ref chartPrice);
            SizeSelection(ref chartString, ref chartPrice, ref isOrderCreated);

           

            if (isOrderCreated)
            {
                chartPrice = chartPrice * (int)upDownOrderAmount.Value;
                chartString += " x" + upDownOrderAmount.Value;
                upDownOrderAmount.Value = 1;

                lblCurrentAmount.Text = "Sipariş Tutarı: " + chartPrice.ToString();
                listBox1.Items.Add(chartString);

                ClearSelections();
            }
            else
            {
                chartPrice = 0;
                chartString = null;

            }


        }
        

        void CreateOrderToAdmin(ref DateTime orderDate)
        {
            try
            {
                if (listBox1.Items.Count == 0)
                {
                    MessageBox.Show("Lütfen sepetinizi kontrol ediniz");
                }
                else
                {
                    orderDate = DateTime.Now;
                    string totalOrdersInChart = "Order " + orderDate + " ";
                    foreach (string chartorders in listBox1.Items)
                    {
                        totalOrdersInChart += chartorders;
                    }


                    Lists.orders.Add(totalOrdersInChart,chartPrice);
                    lblCurrentAmount.Text = "Sipariş Tutarı";
                    listBox1.Items.Clear();
                    chartPrice = 0;
                    totalOrdersInChart = "";
                    MessageBox.Show("Sipariş tamamlanmıştır.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lütfen sepetinizi kontrol ediniz\n" + ex.Message);
            }
        }

        DateTime orderDate;

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            
            CreateOrderToAdmin(ref orderDate);

        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is null)
            {
                MessageBox.Show("Lütfen silinecek sipariş detayını seçiniz");
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            
        }
    }
}
