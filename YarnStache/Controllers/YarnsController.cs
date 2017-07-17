using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using YarnStache.Models;

namespace YarnStache.Controllers
{
    public class YarnsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Yarns
        public ActionResult Index()
        {
            return View(db.Yarns.ToList());
        }

        // GET: Yarns/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Yarn yarn = db.Yarns.Find(id);
            if (yarn == null)
            {
                return HttpNotFound();
            }
            return View(yarn);
        }

        // GET: Yarns/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Yarns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ColorFamily,ColorName,Brand,Weight,DyeLot,FiberType,Quantity")] Yarn yarn)
        {
            if (ModelState.IsValid)
            {
                yarn.Id = Guid.NewGuid();
                db.Yarns.Add(yarn);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(yarn);
        }

        // GET: Yarns/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Yarn yarn = db.Yarns.Find(id);
            if (yarn == null)
            {
                return HttpNotFound();
            }
            return View(yarn);
        }

        // POST: Yarns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ColorFamily,ColorName,Brand,Weight,DyeLot,FiberType,Quantity")] Yarn yarn)
        {
            if (ModelState.IsValid)
            {
                db.Entry(yarn).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(yarn);
        }

        // GET: Yarns/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Yarn yarn = db.Yarns.Find(id);
            if (yarn == null)
            {
                return HttpNotFound();
            }
            return View(yarn);
        }

        // POST: Yarns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Yarn yarn = db.Yarns.Find(id);
            db.Yarns.Remove(yarn);
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
