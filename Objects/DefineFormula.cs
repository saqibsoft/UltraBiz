using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class DefineFormula
    {
        private Int32 _FormulaID;
        private string _ProductId;
        private int _PackingId;
        private Int32 _Qty;
        private decimal _AvgRate;



        public Int32 FormulaID { get { return _FormulaID; } set { _FormulaID = value; } }
        public string ProductId { get { return _ProductId; } set { _ProductId = value; } }
        public int PackingId { get { return _PackingId; } set { _PackingId = value; } }
        public Int32 Qty { get { return _Qty; } set { _Qty = value; } }
        public decimal AvgRate { get { return _AvgRate; } set { _AvgRate = value; } }


    }
}