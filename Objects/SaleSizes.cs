using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class SaleSizes
    {
        private Int64 _SerialNo;
        private DateTime _Dated;
        private Int32 _SaleId;
        private string _ProductId;
        private Int32 _Size;
        private string _SizeName;
        private Int32 _SizeQty;
        private decimal _WeightKgs;



        public Int64 SerialNo { get { return _SerialNo; } set { _SerialNo = value; } }
        public DateTime Dated { get { return _Dated; } set { _Dated = value; } }
        public Int32 SaleId { get { return _SaleId; } set { _SaleId = value; } }
        public string ProductId { get { return _ProductId; } set { _ProductId = value; } }
        public Int32 Size { get { return _Size; } set { _Size = value; } }
        public string SizeName { get { return _SizeName; } set { _SizeName = value; } }
        public Int32 SizeQty { get { return _SizeQty; } set { _SizeQty = value; } }
        public decimal WeightKgs { get { return _WeightKgs; } set { _WeightKgs = value; } }


    }
}