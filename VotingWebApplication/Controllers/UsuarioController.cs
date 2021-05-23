using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VotingWebApplication.DAL;
using VotingWebApplication.EN;

namespace VotingWebApplication.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Usuario pUsuario)
        {
            UsuarioDAL usuarioDal = new UsuarioDAL();
            RegistroNacional registroNacional = usuarioDal.validarDui(pUsuario.numero_dui);
            if (registroNacional != null)
            {
                return RedirectToAction("Create", registroNacional);
            }
            else {
                ViewBag.message = "No se encontraron registros con el número: "+ pUsuario.numero_dui;
            }
            return View();
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Usuario/Create
        public ActionResult Create(RegistroNacional registroNacional)
        {
            ViewData["registroNacional"] = registroNacional;
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        public ActionResult Create(Usuario pUsuario)
        {
            try
            {
                UsuarioDAL usuarioDal = new UsuarioDAL();
                usuarioDal.create(pUsuario);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Usuario/Edit/5
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

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuario/Delete/5
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
