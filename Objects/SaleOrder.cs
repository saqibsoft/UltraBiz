using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class SaleOrder
    {
        private Int32 _OrderId;
        private DateTime _OrderDate;
        private Int32 _BillNo;
        private string _CustomerId;
        private int _SectorID;
        private string _SalesmanId;
        private bool _IsStockist;
        private bool _OldIsStockist;
        private string _Narration;
        private decimal _Disc2Ratio;
        private decimal _FTaxRatio;
        private decimal _SpecialDiscount;
        private decimal _InvOfferDiscount;
        private decimal _InvOfferSTax;
        private decimal _InvOfferFTax;
        private decimal _ReceivedAmount;
        private decimal _PreviousCredit;
        private string _InvoiceNotes;
        private bool _IsPosted;
        private int _UserNo;
        private string _BiltyNo;
        private string _TransportName;
        private Int64 _OfferID;
        private string _BookerID;
        private DateTime _DeliveryDate;
        private Int32 _OfficeID;



        public Int32 OrderId { get { return _OrderId; } set { _OrderId = value; } }
        public DateTime OrderDate { get { return _OrderDate; } set { _OrderDate = value; } }
        public Int32 BillNo { get { return _BillNo; } set { _BillNo = value; } }
        public string CustomerId { get { return _CustomerId; } set { _CustomerId = value; } }
        public int SectorID { get { return _SectorID; } set { _SectorID = value; } }
        public string SalesmanId { get { return _SalesmanId; } set { _SalesmanId = value; } }
        public bool IsStockist { get { return _IsStockist; } set { _IsStockist = value; } }
        public bool OldIsStockist { get { return _OldIsStockist; } set { _OldIsStockist = value; } }
        public string Narration { get { return _Narration; } set { _Narration = value; } }
        public decimal Disc2Ratio { get { return _Disc2Ratio; } set { _Disc2Ratio = value; } }
        public decimal FTaxRatio { get { return _FTaxRatio; } set { _FTaxRatio = value; } }
        public decimal SpecialDiscount { get { return _SpecialDiscount; } set { _SpecialDiscount = value; } }
        public decimal InvOfferDiscount { get { return _InvOfferDiscount; } set { _InvOfferDiscount = value; } }
        public decimal InvOfferSTax { get { return _InvOfferSTax; } set { _InvOfferSTax = value; } }
        public decimal InvOfferFTax { get { return _InvOfferFTax; } set { _InvOfferFTax = value; } }
        public decimal ReceivedAmount { get { return _ReceivedAmount; } set { _ReceivedAmount = value; } }
        public decimal PreviousCredit { get { return _PreviousCredit; } set { _PreviousCredit = value; } }
        public string InvoiceNotes { get { return _InvoiceNotes; } set { _InvoiceNotes = value; } }
        public bool IsPosted { get { return _IsPosted; } set { _IsPosted = value; } }
        public int UserNo { get { return _UserNo; } set { _UserNo = value; } }
        public string BiltyNo { get { return _BiltyNo; } set { _BiltyNo = value; } }
        public string TransportName { get { return _TransportName; } set { _TransportName = value; } }
        public Int64 OfferID { get { return _OfferID; } set { _OfferID = value; } }
        public string BookerID { get { return _BookerID; } set { _BookerID = value; } }
        public DateTime DeliveryDate { get { return _DeliveryDate; } set { _DeliveryDate = value; } }
        public Int32 OfficeID { get { return _OfficeID; } set { _OfficeID = value; } }


    }
}