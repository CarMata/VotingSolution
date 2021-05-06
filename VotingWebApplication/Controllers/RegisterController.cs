using System;
using System.Collections.Generic;
using System.Web.Mvc;
using VotingWebApplication.EN;
using VotingWebApplication.DAL;

namespace VotingWebApplication.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            RegistroDAL registroDal = new RegistroDAL();
            List<RegistroNacional> registerList = new List<RegistroNacional>();
            registerList = registroDal.getAll();
            
            return View(registerList);
        }

        // GET: Register/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Register/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OperacionesController/Create
        [HttpPost]
        public ActionResult Create(RegistroNacional registro)
        {
            try
            {
                RegistroDAL registroDAL = new RegistroDAL();
                registroDAL.save(registro);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROOOOOOOOOOOOOOOOOOOOOOOOR"+ e.Message);
                return View();
            }
        }

        // GET: Register/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Register/Edit/5
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

        // GET: Register/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Register/Delete/5
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
