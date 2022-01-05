using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment.Models;



namespace Assignment.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            using (DBModels dbModel = new DBModels())
                return View(dbModel.BookShops.ToList());
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            using(DBModels dbModel = new DBModels())
            {
                return View(dbModel.BookShops.Where(x=> x.Id == id).FirstOrDefault());
            }
            
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(BookShop bookShop )
        {
            try
            {
                // TODO: Add insert logic here
                using(DBModels dbModel = new DBModels())
                    
                {
                    dbModel.BookShops.Add(bookShop);
                    dbModel.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            using (DBModels dbModel = new DBModels())
            {
                return View(dbModel.BookShops.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, BookShop bookShop)
        {
            try
            {
                // TODO: Add update logic here
                using(DBModels dbModels = new DBModels())
                {
                    dbModels.Entry(bookShop).State = System.Data.Entity.EntityState.Modified;
                    dbModels.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            using (DBModels dbModel = new DBModels())
            {
                return View(dbModel.BookShops.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using(DBModels dbModels = new DBModels())
                {
                    BookShop bookShop = dbModels.BookShops.Where(x => x.Id == id).FirstOrDefault();
                   dbModels.BookShops.Remove(bookShop);
                    dbModels.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
