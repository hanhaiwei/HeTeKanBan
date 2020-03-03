using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeTeKanBan.Models
{
    //看板页面视图，将两个视图的数据集合到一个页面
    public class KanBanPage
    {
        public IEnumerable<LineDropBoxState> states { get; set; }
        public IEnumerable<LineDropBoxTask> tasks { get; set; }
    }
}