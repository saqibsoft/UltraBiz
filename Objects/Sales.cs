using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Sales
    {
        private Int32 _SaleId;
        private DateTime _SaleDate;
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
        private Int32 _OrderId;
        private decimal _ServiceChargesRatio;
        private decimal _GstRatio;
        private string _CustomerName;
        private bool _IsRP;
        private decimal _TotalReceivedCash;
        private string _CustomerMobile;
        private Int64 _OfferID;
        private string _BookerID;
        private decimal _Freight2;
        private decimal _Unloading2;
        private decimal _ITax2;
        private DateTime _DueDate;
        private string _InvType;
        private Int32 _SaleIdNew;
        private string _VehicleACNo;
        private string _VehicleACName;
        private decimal _VehicleFreightExp;
        private decimal _SalTaxPerc;
        private decimal _SalTaxVal;
        private decimal _CurrentReading;
        private bool _isOilTuning;
        private DateTime _OilChangeDate;
        private bool _SendSMSTunning;
        private bool _SendSMSOilChange;
        private Int32 _OfficeID;
        private Int32 _TownID;
        private string _VehicleNo;
        private string _CustPhoneNo;
        private DateTime _SaleTime;
        private bool _IsPrinted;



        public Int32 SaleId { get { return _SaleId; } set { _SaleId = value; } }
        public DateTime SaleDate { get { return _SaleDate; } set { _SaleDate = value; } }
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
        public Int32 OrderId { get { return _OrderId; } set { _OrderId = value; } }
        public decimal ServiceChargesRatio { get { return _ServiceChargesRatio; } set { _ServiceChargesRatio = value; } }
        public decimal GstRatio { get { return _GstRatio; } set { _GstRatio = value; } }
        public string CustomerName { get { return _CustomerName; } set { _CustomerName = value; } }
        public bool IsRP { get { return _IsRP; } set { _IsRP = value; } }
        public decimal TotalReceivedCash { get { return _TotalReceivedCash; } set { _TotalReceivedCash = value; } }
        public string CustomerMobile { get { return _CustomerMobile; } set { _CustomerMobile = value; } }
        public Int64 OfferID { get { return _OfferID; } set { _OfferID = value; } }
        public string BookerID { get { return _BookerID; } set { _BookerID = value; } }
        public decimal Freight2 { get { return _Freight2; } set { _Freight2 = value; } }
        public decimal Unloading2 { get { return _Unloading2; } set { _Unloading2 = value; } }
        public decimal ITax2 { get { return _ITax2; } set { _ITax2 = value; } }
        public DateTime DueDate { get { return _DueDate; } set { _DueDate = value; } }
        public string InvType { get { return _InvType; } set { _InvType = value; } }
        public Int32 SaleIdNew { get { return _SaleIdNew; } set { _SaleIdNew = value; } }
        public string VehicleACNo { get { return _VehicleACNo; } set { _VehicleACNo = value; } }
        public string VehicleACName { get { return _VehicleACName; } set { _VehicleACName = value; } }
        public decimal VehicleFreightExp { get { return _VehicleFreightExp; } set { _VehicleFreightExp = value; } }
        public decimal SalTaxPerc { get { return _SalTaxPerc; } set { _SalTaxPerc = value; } }
        public decimal SalTaxVal { get { return _SalTaxVal; } set { _SalTaxVal = value; } }
        public decimal CurrentReading { get { return _CurrentReading; } set { _CurrentReading = value; } }
        public bool isOilTuning { get { return _isOilTuning; } set { _isOilTuning = value; } }
        public DateTime OilChangeDate { get { return _OilChangeDate; } set { _OilChangeDate = value; } }
        public bool SendSMSTunning { get { return _SendSMSTunning; } set { _SendSMSTunning = value; } }
        public bool SendSMSOilChange { get { return _SendSMSOilChange; } set { _SendSMSOilChange = value; } }
        public Int32 OfficeID { get { return _OfficeID; } set { _OfficeID = value; } }
        public Int32 TownID { get { return _TownID; } set { _TownID = value; } }
        public string VehicleNo { get { return _VehicleNo; } set { _VehicleNo = value; } }
        public string CustPhoneNo { get { return _CustPhoneNo; } set { _CustPhoneNo = value; } }
        public DateTime SaleTime { get { return _SaleTime; } set { _SaleTime = value; } }
        public bool IsPrinted { get { return _IsPrinted; } set { _IsPrinted = value; } }


    }
}