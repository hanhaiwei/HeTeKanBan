using HeTeKanBan.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HeTeKanBan.Models;

namespace HeTeKanBan.Controllers
{
    public class LineDropBoxTaskController : Controller
    {
        //通过db获取数据库数据
        private KanBanConnContext db = new KanBanConnContext();
        // GET: LineDropBoxTask
        public ActionResult Index()
        {
            var dropBoxTasks = from tasks in db.LineDropBoxTasks
                        select tasks;
            return View(dropBoxTasks);
        }
    }
}