using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class ProductionsBody
    {
        private Int32 _SerialNo;
        private Int32 _ProductionId;
        private string _ProductId;
        private int _PackingId;
        private Int32 _Qty;
        private decimal _Rate;
        private string _CustomerId;
        private decimal _CurrStock;



        public Int32 SerialNo { get { return _SerialNo; } set { _SerialNo = value; } }
        public Int32 ProductionId { get { return _ProductionId; } set { _ProductionId = value; } }
        public string ProductId { get { return _ProductId; } set { _ProductId = value; } }
        public int PackingId { get { return _PackingId; } set { _PackingId = value; } }
        public Int32 Qty { get { return _Qty; } set { _Qty = value; } }
        public decimal Rate { get { return _Rate; } set { _Rate = value; } }
        public string CustomerId { get { return _CustomerId; } set { _CustomerId = value; } }
        public decimal CurrStock { get { return _CurrStock; } set { _CurrStock = value; } }


    }
}