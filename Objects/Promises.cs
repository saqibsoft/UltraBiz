using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Promises
    {
        private decimal _PromiseNo;
        private bool _IsPayment;
        private bool _IsFullFilled;
        private DateTime _CurrentDate;
        private DateTime _PromiseDate;
        private string _Narration;
        private decimal _Amount;
        private string _PartyNo;
        private int _UserNo;



        public decimal PromiseNo { get { return _PromiseNo; } set { _PromiseNo = value; } }
        public bool IsPayment { get { return _IsPayment; } set { _IsPayment = value; } }
        public bool IsFullFilled { get { return _IsFullFilled; } set { _IsFullFilled = value; } }
        public DateTime CurrentDate { get { return _CurrentDate; } set { _CurrentDate = value; } }
        public DateTime PromiseDate { get { return _PromiseDate; } set { _PromiseDate = value; } }
        public string Narration { get { return _Narration; } set { _Narration = value; } }
        public decimal Amount { get { return _Amount; } set { _Amount = value; } }
        public string PartyNo { get { return _PartyNo; } set { _PartyNo = value; } }
        public int UserNo { get { return _UserNo; } set { _UserNo = value; } }


    }
}