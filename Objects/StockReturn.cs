using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class StockReturn
    {
        private Int32 _ReturnId;
        private DateTime _Returndate;
        private string _SalesmanID;
        private bool _IsUploaded;
        private Int32 _OfficeID;



        public Int32 ReturnId { get { return _ReturnId; } set { _ReturnId = value; } }
        public DateTime Returndate { get { return _Returndate; } set { _Returndate = value; } }
        public string SalesmanID { get { return _SalesmanID; } set { _SalesmanID = value; } }
        public bool IsUploaded { get { return _IsUploaded; } set { _IsUploaded = value; } }
        public Int32 OfficeID { get { return _OfficeID; } set { _OfficeID = value; } }


    }
}