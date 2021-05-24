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
    public class MunicipioController : Controller
    {
        // GET: Municipio
        public ActionResult Index()
        {
            MunicipioDAL muniDal = new MunicipioDAL();
            List<Municipio> muniList = new List<Municipio>();
            muniList = muniDal.getAll();

            return View(muniList);
        }

        // GET: Municipio/Details/5
        public ActionResult Details(int id)
        {
            Municipio muni = new Municipio();
            MunicipioDAL depDAL = new MunicipioDAL();
            muni = depDAL.getById(id);
            return View(muni);
        }

        // GET: Municipio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Municipio/Create
        [HttpPost]
        public ActionResult Create(Municipio muni, FormCollection collection)
        {
            try
            {
                MunicipioDAL muniDAL = new MunicipioDAL();
                muniDAL.save(muni);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View();
            }
        }

        // GET: Municipio/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Municipio/Edit/5
        [HttpPost]
        public ActionResult Edit(Municipio muni, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                MunicipioDAL muniDAL = new MunicipioDAL();
                muniDAL.edit(muni);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Municipio/Delete/5
        public ActionResult Delete(int id)
        {
            Municipio muni = new Municipio();
            MunicipioDAL muniDAL = new MunicipioDAL();
            muni = muniDAL.getById(id);
            return View(muni);
        }

        // POST: Municipio/Delete/5
        [HttpPost]
        public ActionResult Delete(Municipio muni, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                MunicipioDAL muniDAL = new MunicipioDAL();
                muniDAL.delete(muni.id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
