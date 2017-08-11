using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class CompanySpecialDiscBody
    {
        private Int32 _SerialNo;
        private Int32 _ID;
        private string _CustomerName;
        private string _CustomerID;
        private decimal _RecoveryAmount;
        private decimal _SaleAmount;
        private decimal _Discount;
        private decimal _DiscountValue;



        public Int32 SerialNo { get { return _SerialNo; } set { _SerialNo = value; } }
        public Int32 ID { get { return _ID; } set { _ID = value; } }
        public string CustomerName { get { return _CustomerName; } set { _CustomerName = value; } }
        public string CustomerID { get { return _CustomerID; } set { _CustomerID = value; } }
        public decimal RecoveryAmount { get { return _RecoveryAmount; } set { _RecoveryAmount = value; } }
        public decimal SaleAmount { get { return _SaleAmount; } set { _SaleAmount = value; } }
        public decimal Discount { get { return _Discount; } set { _Discount = value; } }
        public decimal DiscountValue { get { return _DiscountValue; } set { _DiscountValue = value; } }


    }
}