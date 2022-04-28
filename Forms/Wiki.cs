using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinicMS.Models;
using VetClinicMS.UserControlls;

namespace VetClinicMS
{
    public partial class Wiki : Form
    {
        readonly WindowState windowState = new WindowState();

        private List<ArticleModel> ArticlesList = new List<ArticleModel>();
        public Wiki()
        {
            InitializeComponent();
            UserText.Text = Global.UserBanner;
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
                    articleControl.setValues();
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
            windowState.openDashboard(this);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            windowState.openCalendar(this);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            windowState.openPets(this);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            windowState.openMedicines(this);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            windowState.openAdministration(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void Save_Click(object sender, EventArgs e)
        {
            if (articleId.Text == "")
            {
                using (var database = new ModelContext())
                {
                    var article = new ArticleModel()
                    {
                        Title = title.Text,
                        Short = description.Text,
                        Content = content.Text,
                        Author = Global.UserBanner,
                        CreateAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        UpdateBy = ""
                    };

                    database.Articles.Add(article);
                    database.SaveChanges();
                }
            }
            else
            {
                using (var database = new ModelContext())
                {
                    int id = Int32.Parse(articleId.Text);
                    var article = database.Articles.Where(p => p.Id == id).First();
                    article.Title = title.Text;
                    article.Content = content.Text;
                    article.Content = description.Text;
                    article.UpdatedAt = DateTime.Now;
                    article.UpdateBy = Global.UserBanner;

                    database.SaveChanges();
                }
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
                   articleControl.setValues();
                   articleControl.Click += new System.EventHandler(this.ArticleControl_Click);
                   panel1.Controls.Add(articleControl);
               });
            }
        }
    }
}
