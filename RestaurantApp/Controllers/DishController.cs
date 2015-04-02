using RestaurantApp.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System;

namespace RestaurantApp.Controllers
{
    public class DishController : Controller
    {
        RestauRaterDB _db = new RestauRaterDB();
        // GET: Dish
        public ActionResult Index()
        {
            var dishes = _db.Dishes.ToList();

            return View(dishes);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Dish dish = _db.Dishes.Find(id);
            if (dish == null)
                return HttpNotFound();

            return View(dish);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include ="ID, Name")] Dish dish)
        {
            if(ModelState.IsValid)
            {
                _db.Dishes.Add(dish);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dish);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Dish dish = _db.Dishes.Find(id);
            if (dish == null)
                return HttpNotFound();

            return View(dish);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,Name")] Dish dish)
        {
            if(ModelState.IsValid)
            {
                _db.Entry(dish).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dish);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Dish dish = _db.Dishes.Find(id);
            if (dish == null)
                return HttpNotFound();

            return View(dish);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dish dish = _db.Dishes.Find(id);
            _db.Dishes.Remove(dish);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if(_db != null)
            {
                _db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}