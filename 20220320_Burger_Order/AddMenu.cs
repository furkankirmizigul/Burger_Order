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
    public partial class AddMenu : Form
    {
        public AddMenu()
        {
            InitializeComponent();
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            try
            {
                Menu menu = new Menu(txtMenuToAdd.Text, Convert.ToDouble(txtAddMenuPrice.Text));
                Lists.menus.Add(menu);
                MessageBox.Show("Menü eklendi");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"\nGirdiğiniz değerleri kontrol ediniz.");
            }
            
        }
    }
}
