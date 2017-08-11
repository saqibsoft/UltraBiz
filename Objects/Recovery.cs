using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Recovery
    {
        private Int32 _RecoveryID;
        private DateTime _RecoveryDate;
        private bool _IsWithInvoice;
        private string _SalesmanID;
        private Int32 _OfficeID;



        public Int32 RecoveryID { get { return _RecoveryID; } set { _RecoveryID = value; } }
        public DateTime RecoveryDate { get { return _RecoveryDate; } set { _RecoveryDate = value; } }
        public bool IsWithInvoice { get { return _IsWithInvoice; } set { _IsWithInvoice = value; } }
        public string SalesmanID { get { return _SalesmanID; } set { _SalesmanID = value; } }
        public Int32 OfficeID { get { return _OfficeID; } set { _OfficeID = value; } }


    }
}