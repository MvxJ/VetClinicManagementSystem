namespace VetClinicMS
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ResetLoginFormData = new Bunifu.Framework.UI.BunifuThinButton2();
            this.UsernameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CloseLoginFormLabel = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.ActiveBorderThickness = 1;
            this.LoginButton.ActiveCornerRadius = 20;
            this.LoginButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.LoginButton.ActiveForecolor = System.Drawing.Color.White;
            this.LoginButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.LoginButton.BackColor = System.Drawing.Color.White;
            this.LoginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginButton.BackgroundImage")));
            this.LoginButton.ButtonText = "Login";
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.LoginButton.IdleBorderThickness = 1;
            this.LoginButton.IdleCornerRadius = 20;
            this.LoginButton.IdleFillColor = System.Drawing.Color.White;
            this.LoginButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.LoginButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.LoginButton.Location = new System.Drawing.Point(80, 302);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(5);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(200, 41);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ResetLoginFormData
            // 
            this.ResetLoginFormData.ActiveBorderThickness = 1;
            this.ResetLoginFormData.ActiveCornerRadius = 20;
            this.ResetLoginFormData.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.ResetLoginFormData.ActiveForecolor = System.Drawing.Color.White;
            this.ResetLoginFormData.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.ResetLoginFormData.BackColor = System.Drawing.Color.White;
            this.ResetLoginFormData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ResetLoginFormData.BackgroundImage")));
            this.ResetLoginFormData.ButtonText = "Reset";
            this.ResetLoginFormData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetLoginFormData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetLoginFormData.ForeColor = System.Drawing.Color.SeaGreen;
            this.ResetLoginFormData.IdleBorderThickness = 1;
            this.ResetLoginFormData.IdleCornerRadius = 20;
            this.ResetLoginFormData.IdleFillColor = System.Drawing.Color.White;
            this.ResetLoginFormData.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.ResetLoginFormData.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.ResetLoginFormData.Location = new System.Drawing.Point(80, 353);
            this.ResetLoginFormData.Margin = new System.Windows.Forms.Padding(5);
            this.ResetLoginFormData.Name = "ResetLoginFormData";
            this.ResetLoginFormData.Size = new System.Drawing.Size(200, 41);
            this.ResetLoginFormData.TabIndex = 1;
            this.ResetLoginFormData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResetLoginFormData.Click += new System.EventHandler(this.ResetLoginFormData_Click);
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTextbox.DefaultText = "";
            this.UsernameTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTextbox.FocusedState.BorderColor = System.Drawing.Color.SeaGreen;
            this.UsernameTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UsernameTextbox.ForeColor = System.Drawing.Color.Black;
            this.UsernameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTextbox.Location = new System.Drawing.Point(80, 148);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.PasswordChar = '\0';
            this.UsernameTextbox.PlaceholderText = "";
            this.UsernameTextbox.SelectedText = "";
            this.UsernameTextbox.Size = new System.Drawing.Size(200, 36);
            this.UsernameTextbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vet Clinic Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.PasswordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextbox.DefaultText = "";
            this.PasswordTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextbox.FocusedState.BorderColor = System.Drawing.Color.SeaGreen;
            this.PasswordTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordTextbox.ForeColor = System.Drawing.Color.Black;
            this.PasswordTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextbox.Location = new System.Drawing.Point(80, 218);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '*';
            this.PasswordTextbox.PlaceholderText = "";
            this.PasswordTextbox.SelectedText = "";
            this.PasswordTextbox.Size = new System.Drawing.Size(200, 36);
            this.PasswordTextbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // CloseLoginFormLabel
            // 
            this.CloseLoginFormLabel.AutoSize = true;
            this.CloseLoginFormLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLoginFormLabel.ForeColor = System.Drawing.Color.White;
            this.CloseLoginFormLabel.Location = new System.Drawing.Point(344, 7);
            this.CloseLoginFormLabel.Name = "CloseLoginFormLabel";
            this.CloseLoginFormLabel.Size = new System.Drawing.Size(16, 18);
            this.CloseLoginFormLabel.TabIndex = 7;
            this.CloseLoginFormLabel.Text = "x";
            this.CloseLoginFormLabel.Click += new System.EventHandler(this.CloseLoginFormLabel_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.CloseLoginFormLabel);
            this.guna2Panel1.Location = new System.Drawing.Point(-2, -3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(363, 67);
            this.guna2Panel1.TabIndex = 8;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(361, 450);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.ResetLoginFormData);
            this.Controls.Add(this.LoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 LoginButton;
        private Bunifu.Framework.UI.BunifuThinButton2 ResetLoginFormData;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTextbox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CloseLoginFormLabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}

