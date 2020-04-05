using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeTeKanBan.Models
{
    public class LineDropBoxState
    {
        public long ID { get; set; }
        public string LineName { get; set; }
        public string KanBanName { get; set; }
        public string Machine { get; set; }
        public string State { get; set; }
        //public string Udf3 { get; set; }
        //public string sku { get; set; }
    }
}