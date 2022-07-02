
namespace _20220320_Burger_Order
{
    partial class AddMenu
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
            this.txtMenuToAdd = new System.Windows.Forms.TextBox();
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.lblAddMenuName = new System.Windows.Forms.Label();
            this.lblAddMenüPrice = new System.Windows.Forms.Label();
            this.txtAddMenuPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMenuToAdd
            // 
            this.txtMenuToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenuToAdd.Location = new System.Drawing.Point(33, 88);
            this.txtMenuToAdd.Name = "txtMenuToAdd";
            this.txtMenuToAdd.Size = new System.Drawing.Size(271, 34);
            this.txtMenuToAdd.TabIndex = 0;
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMenu.Location = new System.Drawing.Point(159, 210);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(144, 40);
            this.btnAddMenu.TabIndex = 1;
            this.btnAddMenu.Text = "Menü Ekle";
            this.btnAddMenu.UseVisualStyleBackColor = true;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // lblAddMenuName
            // 
            this.lblAddMenuName.AutoSize = true;
            this.lblAddMenuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMenuName.Location = new System.Drawing.Point(28, 60);
            this.lblAddMenuName.Name = "lblAddMenuName";
            this.lblAddMenuName.Size = new System.Drawing.Size(192, 25);
            this.lblAddMenuName.TabIndex = 2;
            this.lblAddMenuName.Text = "Eklenecek Menü Adı";
            // 
            // lblAddMenüPrice
            // 
            this.lblAddMenüPrice.AutoSize = true;
            this.lblAddMenüPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMenüPrice.Location = new System.Drawing.Point(27, 133);
            this.lblAddMenüPrice.Name = "lblAddMenüPrice";
            this.lblAddMenüPrice.Size = new System.Drawing.Size(261, 31);
            this.lblAddMenüPrice.TabIndex = 4;
            this.lblAddMenüPrice.Text = "Eklenecek Menü Fiyatı";
            // 
            // txtAddMenuPrice
            // 
            this.txtAddMenuPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddMenuPrice.Location = new System.Drawing.Point(32, 161);
            this.txtAddMenuPrice.Name = "txtAddMenuPrice";
            this.txtAddMenuPrice.Size = new System.Drawing.Size(271, 34);
            this.txtAddMenuPrice.TabIndex = 3;
            // 
            // AddMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 365);
            this.Controls.Add(this.lblAddMenüPrice);
            this.Controls.Add(this.txtAddMenuPrice);
            this.Controls.Add(this.lblAddMenuName);
            this.Controls.Add(this.btnAddMenu);
            this.Controls.Add(this.txtMenuToAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMenu";
            this.Text = "AddMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMenuToAdd;
        private System.Windows.Forms.Button btnAddMenu;
        private System.Windows.Forms.Label lblAddMenuName;
        private System.Windows.Forms.Label lblAddMenüPrice;
        private System.Windows.Forms.TextBox txtAddMenuPrice;
    }
}