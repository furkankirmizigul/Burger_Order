
namespace _20220320_Burger_Order
{
    partial class CurrentOrder
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
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.lblTotalOrder = new System.Windows.Forms.Label();
            this.lbAllOrders = new System.Windows.Forms.ListBox();
            this.lbl_SelectedOrderPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIncome.Location = new System.Drawing.Point(1196, 307);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(48, 25);
            this.lblTotalIncome.TabIndex = 2;
            this.lblTotalIncome.Text = "Ciro";
            // 
            // lblTotalOrder
            // 
            this.lblTotalOrder.AutoSize = true;
            this.lblTotalOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrder.Location = new System.Drawing.Point(1196, 356);
            this.lblTotalOrder.Name = "lblTotalOrder";
            this.lblTotalOrder.Size = new System.Drawing.Size(201, 25);
            this.lblTotalOrder.TabIndex = 3;
            this.lblTotalOrder.Text = "Toplam Sipariş Sayısı";
            // 
            // lbAllOrders
            // 
            this.lbAllOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAllOrders.FormattingEnabled = true;
            this.lbAllOrders.ItemHeight = 25;
            this.lbAllOrders.Location = new System.Drawing.Point(22, 22);
            this.lbAllOrders.Name = "lbAllOrders";
            this.lbAllOrders.Size = new System.Drawing.Size(1136, 629);
            this.lbAllOrders.TabIndex = 4;
            this.lbAllOrders.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbAllOrders_MouseClick);
            this.lbAllOrders.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbAllOrders_MouseDown);
            // 
            // lbl_SelectedOrderPrice
            // 
            this.lbl_SelectedOrderPrice.AutoSize = true;
            this.lbl_SelectedOrderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectedOrderPrice.Location = new System.Drawing.Point(1196, 270);
            this.lbl_SelectedOrderPrice.Name = "lbl_SelectedOrderPrice";
            this.lbl_SelectedOrderPrice.Size = new System.Drawing.Size(231, 31);
            this.lbl_SelectedOrderPrice.TabIndex = 5;
            this.lbl_SelectedOrderPrice.Text = "Seçili Sipariş Tutarı:";
            // 
            // CurrentOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1484, 709);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_SelectedOrderPrice);
            this.Controls.Add(this.lbAllOrders);
            this.Controls.Add(this.lblTotalOrder);
            this.Controls.Add(this.lblTotalIncome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CurrentOrder";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CurrentOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label lblTotalOrder;
        private System.Windows.Forms.ListBox lbAllOrders;
        private System.Windows.Forms.Label lbl_SelectedOrderPrice;
    }
}