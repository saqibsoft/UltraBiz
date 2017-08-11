using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class PurReturns
    {
        private Int32 _PurReturnId;
        private Int32 _PurchaseId;
        private string _VendorId;
        private string _ReturnDate;
        private decimal _Disc2Ratio;
        private decimal _FTaxRatio;
        private decimal _SpecialDiscount;
        private decimal _InvOfferDiscount;
        private decimal _InvOfferSTax;
        private decimal _InvOfferFTax;
        private decimal _ReceivedAmount;
        private decimal _PreviousCredit;
        private string _Narration;
        private bool _IsPosted;
        private Int32 _OfficeID;



        public Int32 PurReturnId { get { return _PurReturnId; } set { _PurReturnId = value; } }
        public Int32 PurchaseId { get { return _PurchaseId; } set { _PurchaseId = value; } }
        public string VendorId { get { return _VendorId; } set { _VendorId = value; } }
        public string ReturnDate { get { return _ReturnDate; } set { _ReturnDate = value; } }
        public decimal Disc2Ratio { get { return _Disc2Ratio; } set { _Disc2Ratio = value; } }
        public decimal FTaxRatio { get { return _FTaxRatio; } set { _FTaxRatio = value; } }
        public decimal SpecialDiscount { get { return _SpecialDiscount; } set { _SpecialDiscount = value; } }
        public decimal InvOfferDiscount { get { return _InvOfferDiscount; } set { _InvOfferDiscount = value; } }
        public decimal InvOfferSTax { get { return _InvOfferSTax; } set { _InvOfferSTax = value; } }
        public decimal InvOfferFTax { get { return _InvOfferFTax; } set { _InvOfferFTax = value; } }
        public decimal ReceivedAmount { get { return _ReceivedAmount; } set { _ReceivedAmount = value; } }
        public decimal PreviousCredit { get { return _PreviousCredit; } set { _PreviousCredit = value; } }
        public string Narration { get { return _Narration; } set { _Narration = value; } }
        public bool IsPosted { get { return _IsPosted; } set { _IsPosted = value; } }
        public Int32 OfficeID { get { return _OfficeID; } set { _OfficeID = value; } }


    }
}