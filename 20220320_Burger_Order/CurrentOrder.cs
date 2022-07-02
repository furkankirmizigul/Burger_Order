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
    public partial class CurrentOrder : Form
    {
        public CurrentOrder()
        {
            InitializeComponent();
        }

        private void CurrentOrder_Load(object sender, EventArgs e)
        {
            GetAllOrders();
        }
        
        public void GetAllOrders()
        {
            try
            {
                lbAllOrders.Items.Clear();
                double totalIncome = 0;

                foreach (KeyValuePair<string, double> order in Lists.orders)
                {
                    lbAllOrders.Items.Add(order.Key);
                }
                foreach (KeyValuePair<string, double> order in Lists.orders)
                {
                    totalIncome += order.Value;
                }
                lblTotalIncome.Text = "Ciro: " + totalIncome;
                lblTotalOrder.Text = "Toplam Sipariş Sayısı: " + Lists.orders.Keys.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            



        }
        void SelectedOrderPrice()
        {
            double selectedOrderPrice = 0;
            
            foreach (KeyValuePair<string, double> order in Lists.orders)
            {
                if (order.Key== lbAllOrders.SelectedItem.ToString())
                {
                    selectedOrderPrice = order.Value;
                    break;
                }
               
         
            }
            lbl_SelectedOrderPrice.Text = "Seçili Sipariş Tutarı: " + selectedOrderPrice;

        }

        private void lbAllOrders_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void lbAllOrders_MouseClick(object sender, MouseEventArgs e)
        {
            SelectedOrderPrice();
        }
    }
}
