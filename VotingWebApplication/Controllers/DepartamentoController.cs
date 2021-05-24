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
    public class DepartamentoController : Controller
    {
        // GET: Departamento
        public ActionResult Index()
        {
            DepartamentoDAL deptDal = new DepartamentoDAL();
            List<Departamento> deptList = new List<Departamento>();
            deptList = deptDal.getAll();

            return View(deptList);
        }

        // GET: Departamento/Details/5
        public ActionResult Details(int id)
        {
            Departamento dept = new Departamento();
            DepartamentoDAL depDAL = new DepartamentoDAL();
            dept = depDAL.getById(id);
            return View(dept);
        }

        // GET: Departamento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departamento/Create
        [HttpPost]
        public ActionResult Create(Departamento dept, FormCollection collection)
        {
            try
            {
                DepartamentoDAL deptDAL = new DepartamentoDAL();
                deptDAL.save(dept);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View();
            }
        }

        // GET: Departamento/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Departamento/Edit/5
        [HttpPost]
        public ActionResult Edit(Departamento dept, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                DepartamentoDAL depDAL = new DepartamentoDAL();
                depDAL.edit(dept);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Departamento/Delete/5
        public ActionResult Delete(int id)
        {
            Departamento dept = new Departamento();
            DepartamentoDAL depDAL = new DepartamentoDAL();
            dept = depDAL.getById(id);
            return View(dept);
        }

        // POST: Departamento/Delete/5
        [HttpPost]
        public ActionResult Delete(Departamento dept, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                DepartamentoDAL depDAL = new DepartamentoDAL();
                depDAL.delete(dept.id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
