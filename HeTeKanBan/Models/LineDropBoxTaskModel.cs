using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeTeKanBan.Models
{
    public class LineDropBoxTask
    {
        public int ID { get; set; }
        public string KanBanName { get; set; }
        public string LineName { get; set; }
        public string Machine { get; set; }
        public string AbleAmount { get; set; }
        public string AlreadyAmount { get; set; }
        public string udf3 { get; set; }
        //public string sku { get; set; }
    }
}