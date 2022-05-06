namespace VetClinicMS.UserControlls
{
    partial class MedicinControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textMedicine = new System.Windows.Forms.Label();
            this.textCategory = new System.Windows.Forms.Label();
            this.textStock = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.Label();
            this.Delete = new Guna.UI2.WinForms.Guna2Button();
            this.textPrice = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textMedicine
            // 
            this.textMedicine.AutoSize = true;
            this.textMedicine.Location = new System.Drawing.Point(99, 13);
            this.textMedicine.Name = "textMedicine";
            this.textMedicine.Size = new System.Drawing.Size(50, 13);
            this.textMedicine.TabIndex = 24;
            this.textMedicine.Text = "Medicine";
            // 
            // textCategory
            // 
            this.textCategory.AutoSize = true;
            this.textCategory.Location = new System.Drawing.Point(99, 40);
            this.textCategory.Name = "textCategory";
            this.textCategory.Size = new System.Drawing.Size(49, 13);
            this.textCategory.TabIndex = 25;
            this.textCategory.Text = "Category";
            // 
            // textStock
            // 
            this.textStock.AutoSize = true;
            this.textStock.Location = new System.Drawing.Point(99, 64);
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(35, 13);
            this.textStock.TabIndex = 26;
            this.textStock.Text = "Stock";
            // 
            // textDescription
            // 
            this.textDescription.AutoSize = true;
            this.textDescription.Location = new System.Drawing.Point(260, 13);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(60, 13);
            this.textDescription.TabIndex = 27;
            this.textDescription.Text = "Description";
            // 
            // Delete
            // 
            this.Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(523, 13);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(88, 23);
            this.Delete.TabIndex = 28;
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.DeleteObject);
            // 
            // textPrice
            // 
            this.textPrice.AutoSize = true;
            this.textPrice.Location = new System.Drawing.Point(260, 64);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(31, 13);
            this.textPrice.TabIndex = 29;
            this.textPrice.Text = "Price";
            // 
            // textId
            // 
            this.textId.AutoSize = true;
            this.textId.Location = new System.Drawing.Point(3, 0);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(0, 13);
            this.textId.TabIndex = 30;
            this.textId.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VetClinicMS.Properties.Resources.medicine;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // MedicinControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textId);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textStock);
            this.Controls.Add(this.textCategory);
            this.Controls.Add(this.textMedicine);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MedicinControl";
            this.Size = new System.Drawing.Size(625, 90);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textMedicine;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label textCategory;
        private System.Windows.Forms.Label textStock;
        private System.Windows.Forms.Label textDescription;
        private Guna.UI2.WinForms.Guna2Button Delete;
        private System.Windows.Forms.Label textPrice;
        private System.Windows.Forms.Label textId;
    }
}
