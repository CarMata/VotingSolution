using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using VotingWebApplication.EN;
using VotingWebApplication.DAL;
using System;
using System.IO;

namespace VotingWebApplication.Controllers
{
    public class PartidoController : Controller
    {
        // GET: Partido
        public ActionResult Index()
        {
            PartidoDAL partDAL = new PartidoDAL();
            List<Partido> partList = new List<Partido>();
            partList = partDAL.getAll();

            return View(partList);
        }

        // GET: Partido/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Partido/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Partido/Create
        [HttpPost]
        public ActionResult Create(HttpPostedFileBase file, Partido partido, FormCollection collection)
        {

            if (file != null && file.ContentLength > 0)
            {
                byte[] imageData = null;
                using (var binaryReader = new BinaryReader(file.InputStream))
                {
                    imageData = binaryReader.ReadBytes(file.ContentLength);
                }
                //setear la imagen a la entidad que se creara
                partido.foto = imageData;
            }
            try
            {

                PartidoDAL partDAL = new PartidoDAL();
                partDAL.save(partido);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View();
            }
        }

        // GET: Partido/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Partido/Edit/5
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

        // GET: Partido/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Partido/Delete/5
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
