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
        public string _machine;
        public string Machine
        {
            get
            {
                _machine = _machine.Length > 25 ? _machine.Substring(0, 25) : _machine;
                return _machine;
            }
            set
            {
                _machine = value;
            }
        }
        public string AbleAmount { get; set; }
        public string AlreadyAmount { get; set; }

        private DateTime dateTime;//巷道已经分配时间
        private string _udf3;
        public string udf3
        {
            get
            {
                if(DateTime.TryParse(_udf3, out dateTime))
                {
                    _udf3 = Math.Round(DateTime.Now.Subtract(dateTime).Duration().TotalMinutes, 0).ToString();
                }
                return _udf3;
            }
            set
            {
                _udf3 = value;
            }
        }
    }
}