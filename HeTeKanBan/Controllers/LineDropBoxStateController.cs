using HeTeKanBan.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HeTeKanBan.Models;

namespace HeTeKanBan.Controllers
{
    public class LineDropBoxStateController : Controller
    {
        //数据库初始化，通过db获取数据
        private KanBanConnContext db = new KanBanConnContext();

        // GET: LineDropBoxState
        public ActionResult Index()
        {
            var states = from dropBoxStates in db.LineDropBoxStates
                         select dropBoxStates;
            return View(states);
        }

        // GET: LineDropBoxState/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LineDropBoxState/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LineDropBoxState/Create
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

        // GET: LineDropBoxState/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LineDropBoxState/Edit/5
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

        // GET: LineDropBoxState/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LineDropBoxState/Delete/5
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
