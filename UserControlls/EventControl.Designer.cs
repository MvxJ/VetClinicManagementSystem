namespace VetClinicMS.UserControlls
{
    partial class EventControl
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
            this.Delete = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eventId = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fromValue = new System.Windows.Forms.Label();
            this.toValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameValue = new System.Windows.Forms.Label();
            this.descriptionValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.Delete.TabIndex = 29;
            this.Delete.Text = "Delete";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VetClinicMS.Properties.Resources.id_card;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // eventId
            // 
            this.eventId.AutoSize = true;
            this.eventId.Location = new System.Drawing.Point(517, 23);
            this.eventId.Name = "eventId";
            this.eventId.Size = new System.Drawing.Size(0, 13);
            this.eventId.TabIndex = 31;
            this.eventId.Visible = false;
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Location = new System.Drawing.Point(100, 13);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(33, 13);
            this.From.TabIndex = 32;
            this.From.Text = "From:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "To:";
            // 
            // fromValue
            // 
            this.fromValue.AutoSize = true;
            this.fromValue.Location = new System.Drawing.Point(136, 13);
            this.fromValue.Name = "fromValue";
            this.fromValue.Size = new System.Drawing.Size(35, 13);
            this.fromValue.TabIndex = 34;
            this.fromValue.Text = "label2";
            // 
            // toValue
            // 
            this.toValue.AutoSize = true;
            this.toValue.Location = new System.Drawing.Point(339, 13);
            this.toValue.Name = "toValue";
            this.toValue.Size = new System.Drawing.Size(35, 13);
            this.toValue.TabIndex = 35;
            this.toValue.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Name:";
            // 
            // nameValue
            // 
            this.nameValue.AutoSize = true;
            this.nameValue.Location = new System.Drawing.Point(144, 36);
            this.nameValue.Name = "nameValue";
            this.nameValue.Size = new System.Drawing.Size(38, 13);
            this.nameValue.TabIndex = 37;
            this.nameValue.Text = "Name:";
            // 
            // descriptionValue
            // 
            this.descriptionValue.AutoSize = true;
            this.descriptionValue.Location = new System.Drawing.Point(169, 60);
            this.descriptionValue.Name = "descriptionValue";
            this.descriptionValue.Size = new System.Drawing.Size(38, 13);
            this.descriptionValue.TabIndex = 39;
            this.descriptionValue.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Description:";
            // 
            // EventControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.descriptionValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toValue);
            this.Controls.Add(this.fromValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.From);
            this.Controls.Add(this.eventId);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Delete);
            this.Name = "EventControl";
            this.Size = new System.Drawing.Size(625, 90);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Delete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label eventId;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fromValue;
        private System.Windows.Forms.Label toValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nameValue;
        private System.Windows.Forms.Label descriptionValue;
        private System.Windows.Forms.Label label5;
    }
}
