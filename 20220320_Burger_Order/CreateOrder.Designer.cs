
namespace _20220320_Burger_Order
{
    partial class CreateOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrder));
            this.lblChooseOrder = new System.Windows.Forms.Label();
            this.cbxMenu = new System.Windows.Forms.ComboBox();
            this.lblChooseSize = new System.Windows.Forms.Label();
            this.lblSauces = new System.Windows.Forms.Label();
            this.upDownOrderAmount = new System.Windows.Forms.NumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnAddToChart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flo_Sauces = new System.Windows.Forms.FlowLayoutPanel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.floSize = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.lblDrinkSelection = new System.Windows.Forms.Label();
            this.cbxDrinks = new System.Windows.Forms.ComboBox();
            this.lblCurrentAmount = new System.Windows.Forms.Label();
            this.btnEditOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.upDownOrderAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChooseOrder
            // 
            this.lblChooseOrder.AutoSize = true;
            this.lblChooseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseOrder.Location = new System.Drawing.Point(12, 228);
            this.lblChooseOrder.Name = "lblChooseOrder";
            this.lblChooseOrder.Size = new System.Drawing.Size(140, 29);
            this.lblChooseOrder.TabIndex = 0;
            this.lblChooseOrder.Text = "Menü Seçin";
            // 
            // cbxMenu
            // 
            this.cbxMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMenu.FormattingEnabled = true;
            this.cbxMenu.Location = new System.Drawing.Point(31, 259);
            this.cbxMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMenu.Name = "cbxMenu";
            this.cbxMenu.Size = new System.Drawing.Size(281, 37);
            this.cbxMenu.TabIndex = 1;
            // 
            // lblChooseSize
            // 
            this.lblChooseSize.AutoSize = true;
            this.lblChooseSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseSize.Location = new System.Drawing.Point(12, 368);
            this.lblChooseSize.Name = "lblChooseSize";
            this.lblChooseSize.Size = new System.Drawing.Size(140, 29);
            this.lblChooseSize.TabIndex = 2;
            this.lblChooseSize.Text = "Boyut Seçin";
            // 
            // lblSauces
            // 
            this.lblSauces.AutoSize = true;
            this.lblSauces.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSauces.Location = new System.Drawing.Point(12, 454);
            this.lblSauces.Name = "lblSauces";
            this.lblSauces.Size = new System.Drawing.Size(135, 29);
            this.lblSauces.TabIndex = 6;
            this.lblSauces.Text = "Sos Seçimi";
            // 
            // upDownOrderAmount
            // 
            this.upDownOrderAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDownOrderAmount.Location = new System.Drawing.Point(88, 592);
            this.upDownOrderAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upDownOrderAmount.Name = "upDownOrderAmount";
            this.upDownOrderAmount.Size = new System.Drawing.Size(173, 30);
            this.upDownOrderAmount.TabIndex = 12;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(21, 594);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(62, 29);
            this.lblAmount.TabIndex = 13;
            this.lblAmount.Text = "Adet";
            // 
            // btnAddToChart
            // 
            this.btnAddToChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToChart.Location = new System.Drawing.Point(21, 637);
            this.btnAddToChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddToChart.Name = "btnAddToChart";
            this.btnAddToChart.Size = new System.Drawing.Size(291, 46);
            this.btnAddToChart.TabIndex = 14;
            this.btnAddToChart.Text = "Sepete Ekle";
            this.btnAddToChart.UseVisualStyleBackColor = true;
            this.btnAddToChart.Click += new System.EventHandler(this.btnAddToChart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // flo_Sauces
            // 
            this.flo_Sauces.Location = new System.Drawing.Point(31, 486);
            this.flo_Sauces.Name = "flo_Sauces";
            this.flo_Sauces.Size = new System.Drawing.Size(371, 92);
            this.flo_Sauces.TabIndex = 16;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(428, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(562, 604);
            this.listBox1.TabIndex = 17;
            // 
            // floSize
            // 
            this.floSize.Location = new System.Drawing.Point(31, 400);
            this.floSize.Name = "floSize";
            this.floSize.Size = new System.Drawing.Size(371, 38);
            this.floSize.TabIndex = 17;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrder.Location = new System.Drawing.Point(699, 637);
            this.btnCreateOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(291, 46);
            this.btnCreateOrder.TabIndex = 18;
            this.btnCreateOrder.Text = "Siparişi Tamamla";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // lblDrinkSelection
            // 
            this.lblDrinkSelection.AutoSize = true;
            this.lblDrinkSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrinkSelection.Location = new System.Drawing.Point(12, 298);
            this.lblDrinkSelection.Name = "lblDrinkSelection";
            this.lblDrinkSelection.Size = new System.Drawing.Size(150, 29);
            this.lblDrinkSelection.TabIndex = 21;
            this.lblDrinkSelection.Text = "İçecek Seçin";
            // 
            // cbxDrinks
            // 
            this.cbxDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDrinks.FormattingEnabled = true;
            this.cbxDrinks.Location = new System.Drawing.Point(31, 329);
            this.cbxDrinks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxDrinks.Name = "cbxDrinks";
            this.cbxDrinks.Size = new System.Drawing.Size(281, 37);
            this.cbxDrinks.TabIndex = 22;
            // 
            // lblCurrentAmount
            // 
            this.lblCurrentAmount.AutoSize = true;
            this.lblCurrentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentAmount.Location = new System.Drawing.Point(424, 637);
            this.lblCurrentAmount.Name = "lblCurrentAmount";
            this.lblCurrentAmount.Size = new System.Drawing.Size(119, 25);
            this.lblCurrentAmount.TabIndex = 23;
            this.lblCurrentAmount.Text = "Sepet Tutarı";
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditOrder.Location = new System.Drawing.Point(21, 692);
            this.btnEditOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(291, 46);
            this.btnEditOrder.TabIndex = 24;
            this.btnEditOrder.Text = "Siparişi Sil";
            this.btnEditOrder.UseVisualStyleBackColor = true;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // CreateOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1147, 874);
            this.ControlBox = false;
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.lblCurrentAmount);
            this.Controls.Add(this.cbxDrinks);
            this.Controls.Add(this.lblDrinkSelection);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.floSize);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.flo_Sauces);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddToChart);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.upDownOrderAmount);
            this.Controls.Add(this.lblSauces);
            this.Controls.Add(this.lblChooseSize);
            this.Controls.Add(this.cbxMenu);
            this.Controls.Add(this.lblChooseOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateOrder";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CreateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upDownOrderAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChooseOrder;
        private System.Windows.Forms.ComboBox cbxMenu;
        private System.Windows.Forms.Label lblChooseSize;
        private System.Windows.Forms.Label lblSauces;
        private System.Windows.Forms.NumericUpDown upDownOrderAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnAddToChart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flo_Sauces;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.FlowLayoutPanel floSize;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Label lblDrinkSelection;
        private System.Windows.Forms.ComboBox cbxDrinks;
        private System.Windows.Forms.Label lblCurrentAmount;
        private System.Windows.Forms.Button btnEditOrder;
    }
}

