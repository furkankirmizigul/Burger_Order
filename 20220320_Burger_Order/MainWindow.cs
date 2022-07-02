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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        CreateOrder createOrder;
        CurrentOrder currentOrder;
        AddMenu addMenu;
        AddExtraSauce addSauce;
        Size createOrderSize = new Size(1147, 874);
        Size currentOrderSize = new Size(1227, 709);
        Size addMenuSize = new Size(347, 365);
        Size addExtraSauceSize = new Size(346, 330);
        private void MainWindow_Load(object sender, EventArgs e)
        {
            createOrder = new CreateOrder();
            createOrder.MdiParent = this;

            this.ClientSize = createOrderSize;
            createOrder.Dock = DockStyle.Fill;
            createOrder.Show();

            currentOrder = new CurrentOrder();
            currentOrder.MdiParent = this;
            

            addMenu = new AddMenu();
            addMenu.MdiParent = this;

            addSauce = new AddExtraSauce();
            addSauce.MdiParent = this;
            
        }

        

        private void toolStripAddMenu_Click(object sender, EventArgs e)
        {
            this.ClientSize = addMenuSize;
            addMenu.Dock = DockStyle.Fill;
            ShowSelected(addMenu);
            
        }

        private void toolStripAddSauce_Click(object sender, EventArgs e)
        {
            this.ClientSize = addExtraSauceSize;
            addSauce.Dock = DockStyle.Fill;
            ShowSelected(addSauce);
        }

        public void ShowSelected(Form form)
        {
            currentOrder.Hide();
            createOrder.Hide();
            addMenu.Hide();
            addSauce.Hide();
            form.Show();
        }

        private void toolStripAdminPanel_Click(object sender, EventArgs e)
        {
            this.ClientSize = currentOrderSize;
            currentOrder.Dock = DockStyle.Fill;
            currentOrder.GetAllOrders();
            ShowSelected(currentOrder);
        }

        private void toolStripCreateOrderForm_Click(object sender, EventArgs e)
        {
            this.ClientSize = createOrderSize;
            createOrder.Dock = DockStyle.Fill;
            createOrder.AddSaucesToFlo();
            createOrder.AddMenusToCmbx();

            ShowSelected(createOrder);
        }

     



    }
}
