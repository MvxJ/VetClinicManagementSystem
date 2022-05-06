namespace VetClinicMS.UserControlls
{
    partial class ArticleControl
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
            this.articleName = new System.Windows.Forms.Label();
            this.articleAuthor = new System.Windows.Forms.Label();
            this.descriptionText = new Guna.UI2.WinForms.Guna2TextBox();
            this.createdAt = new System.Windows.Forms.Label();
            this.updateAt = new System.Windows.Forms.Label();
            this.updateBy = new System.Windows.Forms.Label();
            this.Delete = new Guna.UI2.WinForms.Guna2Button();
            this.articleId = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // articleName
            // 
            this.articleName.AutoSize = true;
            this.articleName.Location = new System.Drawing.Point(92, 11);
            this.articleName.Name = "articleName";
            this.articleName.Size = new System.Drawing.Size(27, 13);
            this.articleName.TabIndex = 1;
            this.articleName.Text = "Title";
            // 
            // articleAuthor
            // 
            this.articleAuthor.AutoSize = true;
            this.articleAuthor.Location = new System.Drawing.Point(92, 37);
            this.articleAuthor.Name = "articleAuthor";
            this.articleAuthor.Size = new System.Drawing.Size(38, 13);
            this.articleAuthor.TabIndex = 2;
            this.articleAuthor.Text = "Author";
            // 
            // descriptionText
            // 
            this.descriptionText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descriptionText.DefaultText = "";
            this.descriptionText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.descriptionText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.descriptionText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descriptionText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.descriptionText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descriptionText.Location = new System.Drawing.Point(11, 82);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.PasswordChar = '\0';
            this.descriptionText.PlaceholderText = "";
            this.descriptionText.ReadOnly = true;
            this.descriptionText.SelectedText = "";
            this.descriptionText.Size = new System.Drawing.Size(603, 84);
            this.descriptionText.TabIndex = 4;
            // 
            // createdAt
            // 
            this.createdAt.AutoSize = true;
            this.createdAt.Location = new System.Drawing.Point(277, 11);
            this.createdAt.Name = "createdAt";
            this.createdAt.Size = new System.Drawing.Size(57, 13);
            this.createdAt.TabIndex = 5;
            this.createdAt.Text = "Created At";
            // 
            // updateAt
            // 
            this.updateAt.AutoSize = true;
            this.updateAt.Location = new System.Drawing.Point(277, 37);
            this.updateAt.Name = "updateAt";
            this.updateAt.Size = new System.Drawing.Size(61, 13);
            this.updateAt.TabIndex = 6;
            this.updateAt.Text = "Updated At";
            // 
            // updateBy
            // 
            this.updateBy.AutoSize = true;
            this.updateBy.Location = new System.Drawing.Point(92, 62);
            this.updateBy.Name = "updateBy";
            this.updateBy.Size = new System.Drawing.Size(63, 13);
            this.updateBy.TabIndex = 7;
            this.updateBy.Text = "Updated By";
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
            this.Delete.Location = new System.Drawing.Point(526, 11);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(88, 23);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.DeleteObject);
            // 
            // articleId
            // 
            this.articleId.AutoSize = true;
            this.articleId.Location = new System.Drawing.Point(526, 41);
            this.articleId.Name = "articleId";
            this.articleId.Size = new System.Drawing.Size(0, 13);
            this.articleId.TabIndex = 9;
            this.articleId.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VetClinicMS.Properties.Resources.newspaper;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ArticleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.articleId);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.updateBy);
            this.Controls.Add(this.updateAt);
            this.Controls.Add(this.createdAt);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.articleAuthor);
            this.Controls.Add(this.articleName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ArticleControl";
            this.Size = new System.Drawing.Size(625, 177);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label articleName;
        private System.Windows.Forms.Label articleAuthor;
        private Guna.UI2.WinForms.Guna2TextBox descriptionText;
        private System.Windows.Forms.Label createdAt;
        private System.Windows.Forms.Label updateAt;
        private System.Windows.Forms.Label updateBy;
        private Guna.UI2.WinForms.Guna2Button Delete;
        private System.Windows.Forms.Label articleId;
    }
}
