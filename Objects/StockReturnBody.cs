using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class StockReturnBody
    {
        private Int32 _ReturnID;
        private string _ProductID;
        private int _PackingId;
        private decimal _Multiplier;
        private Int32 _QtyPack;
        private Int32 _QtyLose;
        private decimal _TTLValue;
        private decimal _PerUnitCostLose;
        private Int32 _DamageQty;



        public Int32 ReturnID { get { return _ReturnID; } set { _ReturnID = value; } }
        public string ProductID { get { return _ProductID; } set { _ProductID = value; } }
        public int PackingId { get { return _PackingId; } set { _PackingId = value; } }
        public decimal Multiplier { get { return _Multiplier; } set { _Multiplier = value; } }
        public Int32 QtyPack { get { return _QtyPack; } set { _QtyPack = value; } }
        public Int32 QtyLose { get { return _QtyLose; } set { _QtyLose = value; } }
        public decimal TTLValue { get { return _TTLValue; } set { _TTLValue = value; } }
        public decimal PerUnitCostLose { get { return _PerUnitCostLose; } set { _PerUnitCostLose = value; } }
        public Int32 DamageQty { get { return _DamageQty; } set { _DamageQty = value; } }


    }
}