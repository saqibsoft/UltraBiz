using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Purchase
    {
        private Int32 _PurchaseID;
        private DateTime _PurchaseDate;
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
        private Int32 _PurOrderID;
        private decimal _InvOfferFTax;
        private Int64 _OfferID;
        private decimal _Freight2;
        private decimal _Unloading2;
        private decimal _ITax2;
        private string _BiltyNo;
        private decimal _PreviousBal;
        private decimal _FinalBalance;



        public Int32 PurchaseID { get { return _PurchaseID; } set { _PurchaseID = value; } }
        public DateTime PurchaseDate { get { return _PurchaseDate; } set { _PurchaseDate = value; } }
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
        public Int32 PurOrderID { get { return _PurOrderID; } set { _PurOrderID = value; } }
        public decimal InvOfferFTax { get { return _InvOfferFTax; } set { _InvOfferFTax = value; } }
        public Int64 OfferID { get { return _OfferID; } set { _OfferID = value; } }
        public decimal Freight2 { get { return _Freight2; } set { _Freight2 = value; } }
        public decimal Unloading2 { get { return _Unloading2; } set { _Unloading2 = value; } }
        public decimal ITax2 { get { return _ITax2; } set { _ITax2 = value; } }
        public string BiltyNo { get { return _BiltyNo; } set { _BiltyNo = value; } }
        public decimal PreviousBal { get { return _PreviousBal; } set { _PreviousBal = value; } }
        public decimal FinalBalance { get { return _FinalBalance; } set { _FinalBalance = value; } }


    }
}