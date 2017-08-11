using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Productions
    {
        private Int32 _ProductionId;
        private string _ProductionDate;
        private string _ProductId;
        private int _PackingId;
        private Int32 _Qty;
        private decimal _AvgRate;
        private bool _IsAutoInvoice;
        private string _CustomerId;
        private decimal _ExpPerBag;
        private decimal _TotalExp;
        private decimal _TotaAmount;
        private Int32 _FormulaID;



        public Int32 ProductionId { get { return _ProductionId; } set { _ProductionId = value; } }
        public string ProductionDate { get { return _ProductionDate; } set { _ProductionDate = value; } }
        public string ProductId { get { return _ProductId; } set { _ProductId = value; } }
        public int PackingId { get { return _PackingId; } set { _PackingId = value; } }
        public Int32 Qty { get { return _Qty; } set { _Qty = value; } }
        public decimal AvgRate { get { return _AvgRate; } set { _AvgRate = value; } }
        public bool IsAutoInvoice { get { return _IsAutoInvoice; } set { _IsAutoInvoice = value; } }
        public string CustomerId { get { return _CustomerId; } set { _CustomerId = value; } }
        public decimal ExpPerBag { get { return _ExpPerBag; } set { _ExpPerBag = value; } }
        public decimal TotalExp { get { return _TotalExp; } set { _TotalExp = value; } }
        public decimal TotaAmount { get { return _TotaAmount; } set { _TotaAmount = value; } }
        public Int32 FormulaID { get { return _FormulaID; } set { _FormulaID = value; } }


    }
}