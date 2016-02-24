using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcMovie.Models;

namespace ProjetIFI.Controllers
{
    public class BateauxController : Controller
    {
        private BateauxDBContext db = new BateauxDBContext();

        // GET: Bateaux
        public ActionResult Index()
        {
            return View(db.Bateaux.ToList());
        }

        // GET: Bateaux/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bateau bateau = db.Bateaux.Find(id);
            if (bateau == null)
            {
                return HttpNotFound();
            }
            return View(bateau);
        }

        // GET: Bateaux/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bateaux/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nom,DateConstruction,TypeBateau,Prix")] Bateau bateau)
        {
            if (ModelState.IsValid)
            {
                db.Bateaux.Add(bateau);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bateau);
        }

        // GET: Bateaux/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bateau bateau = db.Bateaux.Find(id);
            if (bateau == null)
            {
                return HttpNotFound();
            }
            return View(bateau);
        }

        // POST: Bateaux/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "ID,Nom,DateConstruction,TypeBateau,Prix")] Bateau bateau)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bateau).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bateau);
        }

        // GET: Bateaux/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bateau bateau = db.Bateaux.Find(id);
            if (bateau == null)
            {
                return HttpNotFound();
            }
            return View(bateau);
        }

        // POST: Bateaux/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {
            Bateau bateau = db.Bateaux.Find(id);
            db.Bateaux.Remove(bateau);
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
