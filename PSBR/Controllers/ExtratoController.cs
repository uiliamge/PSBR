using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSBR.Controllers
{
    public class ExtratoController : Controller
    {
        //
        // GET: /Extrato/

        public ActionResult Index()
        {
            ViewBag.Title = "Importar ou digitar Extratos de Prontuários";
            return View();
        }

        //
        // GET: /Extrato/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Extrato/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Extrato/Create

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

        //
        // GET: /Extrato/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Extrato/Edit/5

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

        //
        // GET: /Extrato/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Extrato/Delete/5

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
