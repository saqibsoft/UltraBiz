using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class OfferHeader
    {
        private Int64 _OfferID;
        private DateTime _EntryDate;
        private DateTime _FromDate;
        private DateTime _ToDate;
        private bool _IsActive;
        private int _OfferType;
        private decimal _BaseInvoiceValue;
        private string _BaseProductID;
        private Int32 _QtyLose;
        private bool _IsValOffer;
        private decimal _OfferValue;
        private decimal _OfferRatio;
        private bool _IsProductOffer;
        private string _OfferTitle;



        public Int64 OfferID { get { return _OfferID; } set { _OfferID = value; } }
        public DateTime EntryDate { get { return _EntryDate; } set { _EntryDate = value; } }
        public DateTime FromDate { get { return _FromDate; } set { _FromDate = value; } }
        public DateTime ToDate { get { return _ToDate; } set { _ToDate = value; } }
        public bool IsActive { get { return _IsActive; } set { _IsActive = value; } }
        public int OfferType { get { return _OfferType; } set { _OfferType = value; } }
        public decimal BaseInvoiceValue { get { return _BaseInvoiceValue; } set { _BaseInvoiceValue = value; } }
        public string BaseProductID { get { return _BaseProductID; } set { _BaseProductID = value; } }
        public Int32 QtyLose { get { return _QtyLose; } set { _QtyLose = value; } }
        public bool IsValOffer { get { return _IsValOffer; } set { _IsValOffer = value; } }
        public decimal OfferValue { get { return _OfferValue; } set { _OfferValue = value; } }
        public decimal OfferRatio { get { return _OfferRatio; } set { _OfferRatio = value; } }
        public bool IsProductOffer { get { return _IsProductOffer; } set { _IsProductOffer = value; } }
        public string OfferTitle { get { return _OfferTitle; } set { _OfferTitle = value; } }


    }
}
