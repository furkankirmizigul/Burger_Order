
namespace _20220320_Burger_Order
{
    partial class AddExtraSauce
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
            this.lblAddSauceName = new System.Windows.Forms.Label();
            this.btnAddSauce = new System.Windows.Forms.Button();
            this.txtSauceToAdd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAddSauceName
            // 
            this.lblAddSauceName.AutoSize = true;
            this.lblAddSauceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSauceName.Location = new System.Drawing.Point(40, 67);
            this.lblAddSauceName.Name = "lblAddSauceName";
            this.lblAddSauceName.Size = new System.Drawing.Size(221, 31);
            this.lblAddSauceName.TabIndex = 5;
            this.lblAddSauceName.Text = "Eklenecek Sos Adı";
            // 
            // btnAddSauce
            // 
            this.btnAddSauce.Location = new System.Drawing.Point(172, 145);
            this.btnAddSauce.Name = "btnAddSauce";
            this.btnAddSauce.Size = new System.Drawing.Size(144, 40);
            this.btnAddSauce.TabIndex = 4;
            this.btnAddSauce.Text = "Sos Ekle";
            this.btnAddSauce.UseVisualStyleBackColor = true;
            this.btnAddSauce.Click += new System.EventHandler(this.btnAddSauce_Click);
            // 
            // txtSauceToAdd
            // 
            this.txtSauceToAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSauceToAdd.Location = new System.Drawing.Point(45, 95);
            this.txtSauceToAdd.Name = "txtSauceToAdd";
            this.txtSauceToAdd.Size = new System.Drawing.Size(271, 34);
            this.txtSauceToAdd.TabIndex = 3;
            // 
            // AddExtraSauce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 330);
            this.Controls.Add(this.lblAddSauceName);
            this.Controls.Add(this.btnAddSauce);
            this.Controls.Add(this.txtSauceToAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddExtraSauce";
            this.Text = "AddExtraSauce";
            this.Load += new System.EventHandler(this.AddExtraSauce_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddSauceName;
        private System.Windows.Forms.Button btnAddSauce;
        private System.Windows.Forms.TextBox txtSauceToAdd;
    }
}