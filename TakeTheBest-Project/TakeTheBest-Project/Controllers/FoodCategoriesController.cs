using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TakeTheBest_Project.Models;

namespace TakeTheBest_Project.Controllers
{
    public class FoodCategoriesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: FoodCategories
        public ActionResult BreakfastView()
        {
            return View(db.FoodCategories.ToList());
        }

        public ActionResult LunchView()
        {
            return View(db.FoodCategories.ToList());
        }
        public ActionResult DinnerView()
        {
            return View(db.FoodCategories.ToList());
        }
        public ActionResult DessertView()
        {
            return View(db.FoodCategories.ToList());
        }
        public ActionResult DrinkView()
        {
            return View(db.FoodCategories.ToList());
        }
        public ActionResult Index()
        {
            return View(db.FoodCategories.ToList());
        }

        // GET: FoodCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodCategory foodCategory = db.FoodCategories.Find(id);
            if (foodCategory == null)
            {
                return HttpNotFound();
            }
            return View(foodCategory);
        }

        // GET: FoodCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FoodCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "categoryID,categoryName,categoryDescription,categoryIngredients,categoryOrigin,categoryRating,categoryPrice,categoryImage")] FoodCategory foodCategory)
        {
            if (ModelState.IsValid)
            {
                db.FoodCategories.Add(foodCategory);
                db.SaveChanges();
                return RedirectToAction("BreakfastView");
            }

            return View(foodCategory);
        }

        // GET: FoodCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodCategory foodCategory = db.FoodCategories.Find(id);
            if (foodCategory == null)
            {
                return HttpNotFound();
            }
            return View(foodCategory);
        }

        // POST: FoodCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "categoryID,categoryName,categoryDescription,categoryIngredients,categoryOrigin,categoryRating,categoryPrice,categoryImage")] FoodCategory foodCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(foodCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(foodCategory);
        }

        // GET: FoodCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodCategory foodCategory = db.FoodCategories.Find(id);
            if (foodCategory == null)
            {
                return HttpNotFound();
            }
            return View(foodCategory);
        }

        // POST: FoodCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FoodCategory foodCategory = db.FoodCategories.Find(id);
            db.FoodCategories.Remove(foodCategory);
            db.SaveChanges();
            return RedirectToAction("BreakfastView");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
