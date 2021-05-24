using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using VotingWebApplication.EN;
using VotingWebApplication.DAL;

namespace VotingWebApplication.Controllers
{
    public class TipoEleccionController : Controller
    {
        // GET: TipoEleccion
        public ActionResult Index()
        {
            TipoEleccionDAL electDal = new TipoEleccionDAL();
            List<TipoEleccion> electList = new List<TipoEleccion>();
            electList = electDal.getAll();

            return View(electList);
        }

        // GET: TipoEleccion/Details/5
        public ActionResult Details(int id)
        {
            TipoEleccion elec = new TipoEleccion();
            TipoEleccionDAL elecDAL = new TipoEleccionDAL();
            elec = elecDAL.getById(id);
            return View(elec);
        }

        // GET: TipoEleccion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoEleccion/Create
        [HttpPost]
        public ActionResult Create(TipoEleccion eleccion, FormCollection collection)
        {
            try
            {
                TipoEleccionDAL elecDAL = new TipoEleccionDAL();
                elecDAL.save(eleccion);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View();
            }
        }

        // GET: TipoEleccion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipoEleccion/Edit/5
        [HttpPost]
        public ActionResult Edit(TipoEleccion eleccion, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                TipoEleccionDAL elcDAL = new TipoEleccionDAL();
                elcDAL.edit(eleccion);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoEleccion/Delete/5
        public ActionResult Delete(int id)
        {
            TipoEleccion eleccion = new TipoEleccion();
            TipoEleccionDAL elecDAL = new TipoEleccionDAL();
            eleccion = elecDAL.getById(id);
            return View(eleccion);
        }

        // POST: TipoEleccion/Delete/5
        [HttpPost]
        public ActionResult Delete(TipoEleccion eleccion, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                TipoEleccionDAL elecDAL = new TipoEleccionDAL();
                elecDAL.delete(eleccion.id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
