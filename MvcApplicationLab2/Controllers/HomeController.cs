using MvcApplicationLab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationLab2.Controllers
{
    public class HomeController : Controller
    {
        private readonly WebDbContext _db = new WebDbContext();

        public ActionResult Index()
        {
            return View(_db.Accounts.ToList());
        }

        public ActionResult Invoices(int id = 0)
        {
            return View(_db.Accounts.Find(id).Invoices.ToList());
        }

        [HttpPost]
        public ActionResult Create(Accounts account)
        {
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}
