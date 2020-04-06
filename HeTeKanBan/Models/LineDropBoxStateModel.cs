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
        private string _machine;
        public string Machine {
            get {
                _machine = _machine.Length > 25 ? _machine.Substring(0, 25) : _machine;
                return _machine;
            }
            set
            {
                _machine = value;
            }
        }
        public string State { get; set; }
    }
}