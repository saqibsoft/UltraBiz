using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class PurOrder
    {
        private Int32 _PurOrderID;
        private DateTime _OrderDate;
        private int _OfficeID;
        private string _VendorID;
        private string _BillNo;
        private DateTime _BillDate;
        private bool _IsUploaded;
        private decimal _PaidAmount;
        private string _Narration;
        private decimal _SpecialDiscount;
        private string _CustomerId;
        private decimal _GSTax;
        private string _SalesmanID;



        public Int32 PurOrderID { get { return _PurOrderID; } set { _PurOrderID = value; } }
        public DateTime OrderDate { get { return _OrderDate; } set { _OrderDate = value; } }
        public int OfficeID { get { return _OfficeID; } set { _OfficeID = value; } }
        public string VendorID { get { return _VendorID; } set { _VendorID = value; } }
        public string BillNo { get { return _BillNo; } set { _BillNo = value; } }
        public DateTime BillDate { get { return _BillDate; } set { _BillDate = value; } }
        public bool IsUploaded { get { return _IsUploaded; } set { _IsUploaded = value; } }
        public decimal PaidAmount { get { return _PaidAmount; } set { _PaidAmount = value; } }
        public string Narration { get { return _Narration; } set { _Narration = value; } }
        public decimal SpecialDiscount { get { return _SpecialDiscount; } set { _SpecialDiscount = value; } }
        public string CustomerId { get { return _CustomerId; } set { _CustomerId = value; } }
        public decimal GSTax { get { return _GSTax; } set { _GSTax = value; } }
        public string SalesmanID { get { return _SalesmanID; } set { _SalesmanID = value; } }


    }
}