using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class StockIssue
    {
        private Int32 _IssueID;
        private DateTime _IssueDate;
        private string _SalesmanID;
        private bool _IsUploaded;
        private string _BookerID;
        private DateTime _DeliveryDate;
        private Int32 _OfficeID;



        public Int32 IssueID { get { return _IssueID; } set { _IssueID = value; } }
        public DateTime IssueDate { get { return _IssueDate; } set { _IssueDate = value; } }
        public string SalesmanID { get { return _SalesmanID; } set { _SalesmanID = value; } }
        public bool IsUploaded { get { return _IsUploaded; } set { _IsUploaded = value; } }
        public string BookerID { get { return _BookerID; } set { _BookerID = value; } }
        public DateTime DeliveryDate { get { return _DeliveryDate; } set { _DeliveryDate = value; } }
        public Int32 OfficeID { get { return _OfficeID; } set { _OfficeID = value; } }


    }
}