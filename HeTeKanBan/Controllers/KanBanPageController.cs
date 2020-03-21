using HeTeKanBan.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HeTeKanBan.Models;

namespace HeTeKanBan.Controllers
{

    //对state和task两个实体模型的数据进行处理
    public class KanBanPageController : Controller
    {
        //获取数据库连接
        private KanBanConnContext db = new KanBanConnContext();
        public KanBanPage pages = new KanBanPage();
        // GET: KanBanIPage
        public ActionResult Index()
        {
            pages.states = db.LineDropBoxStates;//函数式写法
            pages.tasks = from lineDropBoxTasks in db.LineDropBoxTasks
                          select lineDropBoxTasks;//linq写法，易读
            return View(pages);
        }


        //根据看板编号显示内容
        // GET: KanBanIPage/Details/5
        public ActionResult Details(string name)
        {
            ViewBag.kanBanName = name;//通过viewbag把controller的值传递给view，其中name是解析的url参数
            var states = from lineDropBoxStates in db.LineDropBoxStates
                           where lineDropBoxStates.KanBanName==name
                           select lineDropBoxStates;
            foreach(var state in states)
            {
                state.Machine = state.Machine.Length>50?state.Machine.Substring(0,50):state.Machine;
            }
            pages.states = states;
            var tasks = from lineDropBoxTasks in db.LineDropBoxTasks
                          where lineDropBoxTasks.KanBanName == name
                          select lineDropBoxTasks;//linq写法，易读
            foreach(var task in tasks)
            {
                task.Machine = task.Machine.Length > 50 ? task.Machine.Substring(0, 50) : task.Machine;
            }
            pages.tasks = tasks;
            return View(pages);
        }

        // GET: KanBanIPage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KanBanIPage/Create
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

        // GET: KanBanIPage/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KanBanIPage/Edit/5
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

        // GET: KanBanIPage/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KanBanIPage/Delete/5
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
