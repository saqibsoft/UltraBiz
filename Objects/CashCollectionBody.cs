using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class CashCollectionBody
    {
        private Int32 _SerialNo;
        private Int32 _CollectionId;
        private string _CustomerId;
        private decimal _RAmount;
        private decimal _Discount;
        private bool _isDeleted;
        private string _SaleID;
        private decimal _Receivables;



        public Int32 SerialNo { get { return _SerialNo; } set { _SerialNo = value; } }
        public Int32 CollectionId { get { return _CollectionId; } set { _CollectionId = value; } }
        public string CustomerId { get { return _CustomerId; } set { _CustomerId = value; } }
        public decimal RAmount { get { return _RAmount; } set { _RAmount = value; } }
        public decimal Discount { get { return _Discount; } set { _Discount = value; } }
        public bool isDeleted { get { return _isDeleted; } set { _isDeleted = value; } }
        public string SaleID { get { return _SaleID; } set { _SaleID = value; } }
        public decimal Receivables { get { return _Receivables; } set { _Receivables = value; } }


    }
}