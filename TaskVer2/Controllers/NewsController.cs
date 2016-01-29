using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskVer2.Models;

namespace TaskVer2.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        dataContext db = new dataContext();
        
        

        public ActionResult Index()
        {

            List<News> News = db.News.ToList();// получаем все объекты News из базы
            List<Category> Cat = db.Category.ToList();
            
            string[] CatArray = new string[Cat.Count];//создаем массив категорий
            int i = 0;
            foreach (Category text in Cat)
            {
                CatArray[i] = text.category;
                i++;
            }
            ViewBag.Cat = CatArray;//передаем 
            ViewBag.News = News; // передаем
            return View();
        }

        // GET: News/NewsByCategory/5
        public ActionResult NewsByCategory(int? id)
        {
            List<News> News = db.News.ToList();// получаем все объекты News из базы
            List<Category> Category = db.Category.ToList();
            List<News> selectedNews = new List<News>(); // создаем список для отобраных новостей
            string[] CatArray = new string[Category.Count];
            int i = 0;

            foreach (News n in News)
            {
                if (n.CategoryID == id+1)
                {
                    selectedNews.Add(n);
                    
                }
            }
            foreach (Category text in Category)
            {
                CatArray[i] = text.category;
                i++;
            }
            string Cat = Category.ElementAt((int)id).category;
            ViewBag.CatArray = CatArray;
            ViewBag.Cat = Cat;
            ViewBag.selectedNews = selectedNews;
            return View();
        }
    }
}
