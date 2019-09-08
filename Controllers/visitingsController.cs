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
    public class visitingsController : Controller
    {
        private MunicipalEntities db = new MunicipalEntities();

        // GET: visitings
        public ActionResult Index()
        {
            return View(db.visitings.ToList());
        }

        // GET: visitings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            visiting visiting = db.visitings.Find(id);
            if (visiting == null)
            {
                return HttpNotFound();
            }
            return View(visiting);
        }

        // GET: visitings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: visitings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,title,description_visiting,date_visiting")] visiting visiting)
        {
            if (ModelState.IsValid)
            {
                db.visitings.Add(visiting);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(visiting);
        }

        // GET: visitings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            visiting visiting = db.visitings.Find(id);
            if (visiting == null)
            {
                return HttpNotFound();
            }
            return View(visiting);
        }

        // POST: visitings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,title,description_visiting,date_visiting")] visiting visiting)
        {
            if (ModelState.IsValid)
            {
                db.Entry(visiting).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(visiting);
        }

        // GET: visitings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            visiting visiting = db.visitings.Find(id);
            if (visiting == null)
            {
                return HttpNotFound();
            }
            return View(visiting);
        }

        // POST: visitings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            visiting visiting = db.visitings.Find(id);
            db.visitings.Remove(visiting);
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
