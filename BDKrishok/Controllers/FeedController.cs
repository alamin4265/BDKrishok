using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Models;

namespace BDKrishok.Controllers
{
    public class FeedController : Controller
    {
        private _BDKrishokDB db = new _BDKrishokDB();

        // GET: Feed
        public ActionResult Index()
        {
            var feed = db.Feed.Include(f => f.FeedType);
            return View(feed.ToList());
        }

        // GET: Feed/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Feed feed = db.Feed.Find(id);
            if (feed == null)
            {
                return HttpNotFound();
            }
            return View(feed);
        }

        // GET: Feed/Create
        public ActionResult Create()
        {
            ViewBag.FeedTypeId = new SelectList(db.FeedType, "Id", "Name");
            return View();
        }

        // POST: Feed/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description,FeedTypeId,CompanyId,ShopId,ImageId,VideoId")] Feed feed)
        {
            if (ModelState.IsValid)
            {
                db.Feed.Add(feed);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FeedTypeId = new SelectList(db.FeedType, "Id", "Name", feed.FeedTypeId);
            return View(feed);
        }

        // GET: Feed/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Feed feed = db.Feed.Find(id);
            if (feed == null)
            {
                return HttpNotFound();
            }
            ViewBag.FeedTypeId = new SelectList(db.FeedType, "Id", "Name", feed.FeedTypeId);
            return View(feed);
        }

        // POST: Feed/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description,FeedTypeId,CompanyId,ShopId,ImageId,VideoId")] Feed feed)
        {
            if (ModelState.IsValid)
            {
                db.Entry(feed).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FeedTypeId = new SelectList(db.FeedType, "Id", "Name", feed.FeedTypeId);
            return View(feed);
        }

        // GET: Feed/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Feed feed = db.Feed.Find(id);
            if (feed == null)
            {
                return HttpNotFound();
            }
            return View(feed);
        }

        // POST: Feed/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Feed feed = db.Feed.Find(id);
            db.Feed.Remove(feed);
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
