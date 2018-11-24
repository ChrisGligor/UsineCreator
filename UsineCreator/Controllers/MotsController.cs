using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UsineCreator.Controllers
{
    public class MotsController : Controller
    {
        // GET: Mots
        public ActionResult Index()
        {
            return View();
        }

        // GET: Mots/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mots/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mots/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mots/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mots/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mots/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mots/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
