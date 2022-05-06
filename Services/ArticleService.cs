using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinicMS.Interfaces;
using VetClinicMS.Models;

namespace VetClinicMS.Services
{
    public class ArticleService : ICrudOperation
    {
        public void create(NameValueCollection list)
        {
            using (var database = new ModelContext())
            {
                var article = new ArticleModel()
                {
                    Title = list["title"],
                    Short = list["description"],
                    Content = list["content"],
                    Author = Global.UserBanner,
                    CreateAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    UpdateBy = ""
                };

                database.Articles.Add(article);
                database.SaveChanges();
            }
        }

        public void delete(int id)
        {
            using (ModelContext database = new ModelContext())
            {
                var article = database.Articles.First(c => c.Id == id);
                if (article != null)
                {
                    database.Articles.Remove(article);
                    database.SaveChanges();

                }
            }
        }

        public void update(NameValueCollection list)
        {
            using (var database = new ModelContext())
            {
                int id = Int32.Parse(list["id"]);
                var article = database.Articles.Where(p => p.Id == id).First();
                article.Title = list["title"];
                article.Content = list["content"];
                article.Short = list["description"];
                article.UpdatedAt = DateTime.Now;
                article.UpdateBy = Global.UserBanner;

                database.SaveChanges();
            }
        }
    }
}
