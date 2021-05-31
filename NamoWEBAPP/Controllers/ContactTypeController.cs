using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NamoWEBAPP.Controllers
{
    public class ContactTypeController : Controller
    {
        // GET: ContactTypeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ContactTypeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContactTypeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactTypeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ContactTypeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContactTypeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ContactTypeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContactTypeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
