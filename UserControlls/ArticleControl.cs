using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinicMS.Interfaces;
using VetClinicMS.Models;
using VetClinicMS.Services;

namespace VetClinicMS.UserControlls
{
    public partial class ArticleControl : UserControl, IUserControl
    {
        public ArticleControl()
        {
            InitializeComponent();
        }

        private int _id;
        private string _title;
        private string _author;
        private string _description;
        private DateTime _createdAt;
        private DateTime _updatedAt;
        private string _updateBy;
        private string _content;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = value; }
        }

        public DateTime UpdatedAt
        {
            get { return _updatedAt; }
            set { _updatedAt = value; }
        }

        public string UpdateBy
        {
            get { return _updateBy; }
            set { _updateBy = value; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public void SetValues()
        {
            articleId.Text = Id.ToString();
            articleName.Text = "Title: " + Title;
            articleAuthor.Text = "Author: " + Author;
            createdAt.Text = "Create at: " + CreatedAt;
            descriptionText.Text = Description;

            if (UpdatedAt != null && UpdateBy != "")
            {
                updateAt.Text = "Update at: " + UpdatedAt;
                updateBy.Text = "Update by: " + UpdateBy;
            } else {
                updateAt.Text = "";
                updateBy.Text = "";
            }
        }

        public void DeleteObject(object sender, EventArgs e)
        {
            ArticleService articleService = new ArticleService();
            articleService.delete(Id);
        }
    }
}
