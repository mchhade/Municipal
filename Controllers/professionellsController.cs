using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Municipal;

namespace Municipal.Controllers
{
    public class professionellsController : Controller
    {
        private MunicipalEntities db = new MunicipalEntities();

        // GET: professionells
        public ActionResult Index()
        {
            return View(db.professionells.ToList());
        }

        // GET: professionells/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            professionell professionell = db.professionells.Find(id);
            if (professionell == null)
            {
                return HttpNotFound();
            }
            return View(professionell);
        }

        // GET: professionells/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: professionells/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,year_professionel,description_professionel")] professionell professionell)
        {
            if (ModelState.IsValid)
            {
                db.professionells.Add(professionell);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(professionell);
        }

        // GET: professionells/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            professionell professionell = db.professionells.Find(id);
            if (professionell == null)
            {
                return HttpNotFound();
            }
            return View(professionell);
        }

        // POST: professionells/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,year_professionel,description_professionel")] professionell professionell)
        {
            if (ModelState.IsValid)
            {
                db.Entry(professionell).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(professionell);
        }

        // GET: professionells/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            professionell professionell = db.professionells.Find(id);
            if (professionell == null)
            {
                return HttpNotFound();
            }
            return View(professionell);
        }

        // POST: professionells/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            professionell professionell = db.professionells.Find(id);
            db.professionells.Remove(professionell);
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
