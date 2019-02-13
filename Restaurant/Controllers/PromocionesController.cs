using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Restaurant.Models;

namespace Restaurant.Views
{
    public class PromocionesController : Controller
    {
        private RestauranteBDEntities db = new RestauranteBDEntities();

        // GET: Promociones
        public ActionResult Index()
        {
            return View(db.Promociones.ToList());
        }

        // GET: Promociones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Promociones promociones = db.Promociones.Find(id);
            if (promociones == null)
            {
                return HttpNotFound();
            }
            return View(promociones);
        }

        // GET: Promociones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Promociones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Descripcion,estado,descuento")] Promociones promociones)
        {
            if (ModelState.IsValid)
            {
                db.Promociones.Add(promociones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(promociones);
        }

        // GET: Promociones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Promociones promociones = db.Promociones.Find(id);
            if (promociones == null)
            {
                return HttpNotFound();
            }
            return View(promociones);
        }

        // POST: Promociones/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Descripcion,estado,descuento")] Promociones promociones)
        {
            if (ModelState.IsValid)
            {
                db.Entry(promociones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(promociones);
        }

        // GET: Promociones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Promociones promociones = db.Promociones.Find(id);
            if (promociones == null)
            {
                return HttpNotFound();
            }
            return View(promociones);
        }

        // POST: Promociones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Promociones promociones = db.Promociones.Find(id);
            db.Promociones.Remove(promociones);
            db.SaveChanges();
            return RedirectToAction("Index");
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
