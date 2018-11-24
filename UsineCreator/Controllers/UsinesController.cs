using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UsineCreator.Controllers
{
    public class UsinesController : Controller
    {
        // GET: Usines
        public ActionResult Index()
        {
            return View();
        }

        // GET: Usines/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Usines/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usines/Create
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

        // GET: Usines/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Usines/Edit/5
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

        // GET: Usines/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usines/Delete/5
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
