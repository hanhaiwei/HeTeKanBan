using HeTeKanBan.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HeTeKanBan.Dal
{
    public class KanBanConnContext:DbContext
    {
        //构造函数，实现数据库的初始化。父函数中的字符串为Web.config中配置的连接名
        public KanBanConnContext():base("KanBanConnContext")
        {

        }
        //public DbSet<实体模型名>   数据库名-----数据库与实体模型通过DbSet进行关联
        public DbSet<LineDropBoxTask> LineDropBoxTasks { get; set; }
        public DbSet<LineDropBoxState> LineDropBoxStates { get; set; }
    }
}