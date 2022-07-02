
namespace _20220320_Burger_Order
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripOrderManage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAddMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAddSauce = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCreateOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCreateOrderForm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAdminPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOrderManage,
            this.toolStripCreateOrder});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1276, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripOrderManage
            // 
            this.toolStripOrderManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAddMenu,
            this.toolStripAddSauce});
            this.toolStripOrderManage.Name = "toolStripOrderManage";
            this.toolStripOrderManage.Size = new System.Drawing.Size(116, 24);
            this.toolStripOrderManage.Text = "Ürün Yönetimi";
            // 
            // toolStripAddMenu
            // 
            this.toolStripAddMenu.Name = "toolStripAddMenu";
            this.toolStripAddMenu.Size = new System.Drawing.Size(224, 26);
            this.toolStripAddMenu.Text = "Menü Ekle";
            this.toolStripAddMenu.Click += new System.EventHandler(this.toolStripAddMenu_Click);
            // 
            // toolStripAddSauce
            // 
            this.toolStripAddSauce.Name = "toolStripAddSauce";
            this.toolStripAddSauce.Size = new System.Drawing.Size(224, 26);
            this.toolStripAddSauce.Text = "Sos Ekle";
            this.toolStripAddSauce.Click += new System.EventHandler(this.toolStripAddSauce_Click);
            // 
            // toolStripCreateOrder
            // 
            this.toolStripCreateOrder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCreateOrderForm,
            this.toolStripAdminPanel});
            this.toolStripCreateOrder.Name = "toolStripCreateOrder";
            this.toolStripCreateOrder.Size = new System.Drawing.Size(129, 24);
            this.toolStripCreateOrder.Text = "Sipariş Yönetimi";
            // 
            // toolStripCreateOrderForm
            // 
            this.toolStripCreateOrderForm.Name = "toolStripCreateOrderForm";
            this.toolStripCreateOrderForm.Size = new System.Drawing.Size(224, 26);
            this.toolStripCreateOrderForm.Text = "Sipariş Oluştur";
            this.toolStripCreateOrderForm.Click += new System.EventHandler(this.toolStripCreateOrderForm_Click);
            // 
            // toolStripAdminPanel
            // 
            this.toolStripAdminPanel.Name = "toolStripAdminPanel";
            this.toolStripAdminPanel.Size = new System.Drawing.Size(224, 26);
            this.toolStripAdminPanel.Text = "Admin Paneli";
            this.toolStripAdminPanel.Click += new System.EventHandler(this.toolStripAdminPanel_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1276, 971);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripOrderManage;
        private System.Windows.Forms.ToolStripMenuItem toolStripAddMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripAddSauce;
        private System.Windows.Forms.ToolStripMenuItem toolStripCreateOrder;
        private System.Windows.Forms.ToolStripMenuItem toolStripCreateOrderForm;
        private System.Windows.Forms.ToolStripMenuItem toolStripAdminPanel;
    }
}