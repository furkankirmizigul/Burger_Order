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
    public partial class AddExtraSauce : Form
    {
        public AddExtraSauce()
        {
            InitializeComponent();
        }

        private void btnAddSauce_Click(object sender, EventArgs e)
        {
            try
            {
                Sauce sauce = new Sauce(txtSauceToAdd.Text);
                Lists.sauces.Add(sauce);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nGirdiğiniz değerleri kontrol ediniz.");
            }


        }

        private void AddExtraSauce_Load(object sender, EventArgs e)
        {

        }
    }
}
