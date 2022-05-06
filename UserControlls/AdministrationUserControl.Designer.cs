namespace VetClinicMS.UserControlls
{
    partial class AdministrationUserControl
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameSurname = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.uId = new System.Windows.Forms.Label();
            this.Delete = new Guna.UI2.WinForms.Guna2Button();
            this.surnameName = new System.Windows.Forms.Label();
            this.uName = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(76, 71);
            this.guna2Panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VetClinicMS.Properties.Resources.doctor;
            this.pictureBox1.Location = new System.Drawing.Point(8, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nameSurname
            // 
            this.nameSurname.AutoSize = true;
            this.nameSurname.Location = new System.Drawing.Point(88, 17);
            this.nameSurname.Name = "nameSurname";
            this.nameSurname.Size = new System.Drawing.Size(0, 13);
            this.nameSurname.TabIndex = 1;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(88, 45);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(0, 13);
            this.Username.TabIndex = 2;
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Location = new System.Drawing.Point(293, 17);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(35, 13);
            this.role.TabIndex = 3;
            this.role.Text = "label1";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(293, 45);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(35, 13);
            this.email.TabIndex = 4;
            this.email.Text = "label1";
            // 
            // uId
            // 
            this.uId.AutoSize = true;
            this.uId.Location = new System.Drawing.Point(536, 45);
            this.uId.Name = "uId";
            this.uId.Size = new System.Drawing.Size(35, 13);
            this.uId.TabIndex = 5;
            this.uId.Text = "label1";
            this.uId.Visible = false;
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
            this.Delete.Location = new System.Drawing.Point(483, 9);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(88, 23);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.DeleteObject);
            // 
            // surnameName
            // 
            this.surnameName.AutoSize = true;
            this.surnameName.Location = new System.Drawing.Point(88, 17);
            this.surnameName.Name = "surnameName";
            this.surnameName.Size = new System.Drawing.Size(35, 13);
            this.surnameName.TabIndex = 9;
            this.surnameName.Text = "label1";
            // 
            // uName
            // 
            this.uName.AutoSize = true;
            this.uName.Location = new System.Drawing.Point(88, 45);
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(35, 13);
            this.uName.TabIndex = 10;
            this.uName.Text = "label1";
            // 
            // AdministrationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uName);
            this.Controls.Add(this.surnameName);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.uId);
            this.Controls.Add(this.email);
            this.Controls.Add(this.role);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.nameSurname);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "AdministrationUserControl";
            this.Size = new System.Drawing.Size(583, 71);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameSurname;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label uId;
        private Guna.UI2.WinForms.Guna2Button Delete;
        private System.Windows.Forms.Label surnameName;
        private System.Windows.Forms.Label uName;
    }
}
