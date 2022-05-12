namespace VetClinicMS.UserControlls
{
    partial class DashBoardUserControl
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
            this.descriptionValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toValue = new System.Windows.Forms.Label();
            this.fromValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionValue
            // 
            this.descriptionValue.AutoSize = true;
            this.descriptionValue.Location = new System.Drawing.Point(170, 62);
            this.descriptionValue.Name = "descriptionValue";
            this.descriptionValue.Size = new System.Drawing.Size(38, 13);
            this.descriptionValue.TabIndex = 48;
            this.descriptionValue.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Description:";
            // 
            // nameValue
            // 
            this.nameValue.AutoSize = true;
            this.nameValue.Location = new System.Drawing.Point(145, 38);
            this.nameValue.Name = "nameValue";
            this.nameValue.Size = new System.Drawing.Size(38, 13);
            this.nameValue.TabIndex = 46;
            this.nameValue.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Name:";
            // 
            // toValue
            // 
            this.toValue.AutoSize = true;
            this.toValue.Location = new System.Drawing.Point(340, 15);
            this.toValue.Name = "toValue";
            this.toValue.Size = new System.Drawing.Size(35, 13);
            this.toValue.TabIndex = 44;
            this.toValue.Text = "label2";
            // 
            // fromValue
            // 
            this.fromValue.AutoSize = true;
            this.fromValue.Location = new System.Drawing.Point(137, 15);
            this.fromValue.Name = "fromValue";
            this.fromValue.Size = new System.Drawing.Size(35, 13);
            this.fromValue.TabIndex = 43;
            this.fromValue.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "To:";
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Location = new System.Drawing.Point(101, 15);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(33, 13);
            this.From.TabIndex = 41;
            this.From.Text = "From:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VetClinicMS.Properties.Resources.id_card;
            this.pictureBox1.Location = new System.Drawing.Point(13, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.FillColor = System.Drawing.Color.SeaGreen;
            this.guna2Panel2.Location = new System.Drawing.Point(493, 6);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(20, 20);
            this.guna2Panel2.TabIndex = 51;
            // 
            // DashBoardUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.descriptionValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toValue);
            this.Controls.Add(this.fromValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.From);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DashBoardUserControl";
            this.Size = new System.Drawing.Size(520, 90);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descriptionValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nameValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label toValue;
        private System.Windows.Forms.Label fromValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}
