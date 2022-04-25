namespace VetClinicMS
{
    partial class Splash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.label1 = new System.Windows.Forms.Label();
            this.LoadingProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.LoadingValueLabel = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vet Clinic Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoadingProgressBar
            // 
            this.LoadingProgressBar.BorderColor = System.Drawing.Color.Transparent;
            this.LoadingProgressBar.FillColor = System.Drawing.Color.White;
            this.LoadingProgressBar.Location = new System.Drawing.Point(-2, 440);
            this.LoadingProgressBar.Name = "LoadingProgressBar";
            this.LoadingProgressBar.ProgressColor = System.Drawing.Color.SeaGreen;
            this.LoadingProgressBar.ProgressColor2 = System.Drawing.Color.SeaGreen;
            this.LoadingProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LoadingProgressBar.Size = new System.Drawing.Size(365, 12);
            this.LoadingProgressBar.TabIndex = 3;
            this.LoadingProgressBar.Text = "guna2ProgressBar1";
            this.LoadingProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.LoadingProgressBar.ValueChanged += new System.EventHandler(this.guna2ProgressBar1_ValueChanged);
            // 
            // SplashTimer
            // 
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loading: ";
            // 
            // LoadingValueLabel
            // 
            this.LoadingValueLabel.AutoSize = true;
            this.LoadingValueLabel.Location = new System.Drawing.Point(69, 424);
            this.LoadingValueLabel.Name = "LoadingValueLabel";
            this.LoadingValueLabel.Size = new System.Drawing.Size(0, 13);
            this.LoadingValueLabel.TabIndex = 5;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Panel1.BorderRadius = 125;
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.FillColor = System.Drawing.Color.SeaGreen;
            this.guna2Panel1.Location = new System.Drawing.Point(55, 113);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(253, 243);
            this.guna2Panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(361, 450);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.LoadingValueLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoadingProgressBar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ProgressBar LoadingProgressBar;
        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LoadingValueLabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}