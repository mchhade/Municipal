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
    public class speechesController : Controller
    {
        private MunicipalEntities db = new MunicipalEntities();

        // GET: speeches
        public ActionResult Index()
        {
            return View(db.speeches.ToList());
        }

        // GET: speeches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            speech speech = db.speeches.Find(id);
            if (speech == null)
            {
                return HttpNotFound();
            }
            return View(speech);
        }

        // GET: speeches/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: speeches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,title,description_speech,date_speech")] speech speech)
        {
            if (ModelState.IsValid)
            {
                db.speeches.Add(speech);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(speech);
        }

        // GET: speeches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            speech speech = db.speeches.Find(id);
            if (speech == null)
            {
                return HttpNotFound();
            }
            return View(speech);
        }

        // POST: speeches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,title,description_speech,date_speech")] speech speech)
        {
            if (ModelState.IsValid)
            {
                db.Entry(speech).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(speech);
        }

        // GET: speeches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            speech speech = db.speeches.Find(id);
            if (speech == null)
            {
                return HttpNotFound();
            }
            return View(speech);
        }

        // POST: speeches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            speech speech = db.speeches.Find(id);
            db.speeches.Remove(speech);
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
