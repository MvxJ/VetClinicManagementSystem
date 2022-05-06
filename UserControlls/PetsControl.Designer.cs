namespace VetClinicMS
{
    partial class PetsControl
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
            this.Petname = new System.Windows.Forms.Label();
            this.Parent = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Type = new System.Windows.Forms.Label();
            this.Delete = new Guna.UI2.WinForms.Guna2Button();
            this.Age = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.petID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Petname
            // 
            this.Petname.AutoSize = true;
            this.Petname.Location = new System.Drawing.Point(160, 53);
            this.Petname.Name = "Petname";
            this.Petname.Size = new System.Drawing.Size(38, 13);
            this.Petname.TabIndex = 0;
            this.Petname.Text = "Name:";
            // 
            // Parent
            // 
            this.Parent.AutoSize = true;
            this.Parent.Location = new System.Drawing.Point(316, 53);
            this.Parent.Name = "Parent";
            this.Parent.Size = new System.Drawing.Size(41, 13);
            this.Parent.TabIndex = 1;
            this.Parent.Text = "Parent:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(316, 76);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(34, 13);
            this.Type.TabIndex = 4;
            this.Type.Text = "Type:";
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
            this.Delete.Location = new System.Drawing.Point(523, 14);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(88, 23);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.DeleteObject);
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(164, 76);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(29, 13);
            this.Age.TabIndex = 8;
            this.Age.Text = "Age:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // petID
            // 
            this.petID.AutoSize = true;
            this.petID.Location = new System.Drawing.Point(144, 14);
            this.petID.Name = "petID";
            this.petID.Size = new System.Drawing.Size(35, 13);
            this.petID.TabIndex = 13;
            this.petID.Text = "label5";
            this.petID.Visible = false;
            // 
            // PetsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.petID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Parent);
            this.Controls.Add(this.Petname);
            this.Name = "PetsControl";
            this.Size = new System.Drawing.Size(625, 147);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Petname;
        private System.Windows.Forms.Label Parent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Type;
        private Guna.UI2.WinForms.Guna2Button Delete;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label petID;
    }
}
