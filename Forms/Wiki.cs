using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinicMS.Models;
using VetClinicMS.Services;
using VetClinicMS.UserControlls;

namespace VetClinicMS
{
    public partial class Wiki : Form
    {
        readonly ArticleService articleService = new ArticleService();
        readonly WindowState windowState = new WindowState();

        private List<ArticleModel> ArticlesList = new List<ArticleModel>();
        public Wiki()
        {
            InitializeComponent();
            UserText.Text = Global.UserBanner;

            if (Global.Usermode != 1)
            {
                this.guna2Button5.Hide();
                this.pictureBox5.Hide();
            }

            this.LoadArticles();
        }

        private void LoadArticles()
        {
            using (ModelContext database = new ModelContext())
            {
                panel1.Controls.Clear();
                var articles = database.Articles.ToList();

                articles.ForEach(article => {
                    ArticleControl articleControl = new ArticleControl();
                    articleControl.Author = article.Author;
                    articleControl.Title = article.Title;
                    articleControl.Content = article.Content;
                    articleControl.CreatedAt = article.CreateAt;
                    articleControl.UpdatedAt = article.UpdatedAt;
                    articleControl.UpdateBy = article.UpdateBy;
                    articleControl.Description = article.Short;
                    articleControl.Id = article.Id;
                    articleControl.SetValues();
                    articleControl.Click += new System.EventHandler(this.ArticleControl_Click);
                    panel1.Controls.Add(articleControl);
                });

                this.ArticlesList = articles;
            }
        }

        private void ArticleControl_Click(object sender, EventArgs e)
        {
            ArticleControl article = (ArticleControl)sender;

            articleId.Text = article.Id.ToString();
            title.Text = article.Title;
            description.Text = article.Description;
            content.Text = article.Content;
            author.Text = "Author: " + article.Author;
            created.Text = "Create at: " + article.CreatedAt.ToString();

            if (article.UpdatedAt != null && article.UpdateBy != "")
            {
                updated.Text = "Update at: " + article.UpdatedAt.ToString();
                updatedBy.Text = "Update by: " + article.UpdateBy;
            } else {
                updated.Text = "";
                updatedBy.Text = "";
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            windowState.OpenDashBoard(this);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            windowState.OpenCalendar(this);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            windowState.OpenPets(this);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            windowState.OpenMedicines(this);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            windowState.OpenUserAdministration(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            windowState.Minimalize(this);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.LoadArticles();
        }

        private void CancelModification_Click(object sender, EventArgs e)
        {
            articleId.Text = "";
            title.Text = "";
            description.Text = "";
            content.Text = "";
            author.Text = "";
            created.Text = "";
            updated.Text = "";
            updatedBy.Text = "";
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            windowState.LogOut(this);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            NameValueCollection list = new NameValueCollection();
            list["id"] = articleId.Text;
            list["title"] = title.Text;
            list["description"] = description.Text;
            list["content"] = content.Text;
            list["author"] = author.Text;

            if (articleId.Text == "")
            {
                articleService.create(list);
            }
            else
            {
                articleService.update(list);
            }

            this.LoadArticles();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (searchBox.Text != "")
            {
                this.panel1.Controls.Clear();
                var articles = ArticlesList.Where(
                    a => a.Title.Contains(searchBox.Text) || 
                    a.Short.Contains(searchBox.Text) ||
                    a.Content.Contains(searchBox.Text) ||
                    a.Author.Contains(searchBox.Text) ||
                    a.UpdateBy.Contains(searchBox.Text)
               ).ToList();

               articles.ForEach(article => {
                   ArticleControl articleControl = new ArticleControl();
                   articleControl.Author = article.Author;
                   articleControl.Title = article.Title;
                   articleControl.Content = article.Content;
                   articleControl.CreatedAt = article.CreateAt;
                   articleControl.UpdatedAt = article.UpdatedAt;
                   articleControl.UpdateBy = article.UpdateBy;
                   articleControl.Description = article.Short;
                   articleControl.Id = article.Id;
                   articleControl.SetValues();
                   articleControl.Click += new System.EventHandler(this.ArticleControl_Click);
                   panel1.Controls.Add(articleControl);
               });
            }
        }
    }
}
