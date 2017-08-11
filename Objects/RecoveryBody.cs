using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class RecoveryBody
    {
        private Int32 _SerialNo;
        private Int32 _RecoveryID;
        private Int32 _SaleID;
        private string _CustomerID;
        private decimal _Amount;
        private decimal _Discount;
        private bool _IsDeleted;
        private string _Narration;



        public Int32 SerialNo { get { return _SerialNo; } set { _SerialNo = value; } }
        public Int32 RecoveryID { get { return _RecoveryID; } set { _RecoveryID = value; } }
        public Int32 SaleID { get { return _SaleID; } set { _SaleID = value; } }
        public string CustomerID { get { return _CustomerID; } set { _CustomerID = value; } }
        public decimal Amount { get { return _Amount; } set { _Amount = value; } }
        public decimal Discount { get { return _Discount; } set { _Discount = value; } }
        public bool IsDeleted { get { return _IsDeleted; } set { _IsDeleted = value; } }
        public string Narration { get { return _Narration; } set { _Narration = value; } }


    }
}