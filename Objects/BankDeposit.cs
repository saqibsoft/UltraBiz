using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class BankDeposit
    {
        private decimal _VoucherNo;
        private DateTime _VoucherDate;
        private bool _IsCheque;
        private string _ChequeNo;
        private DateTime _ChequeDate;
        private string _SlipNo;
        private DateTime _DepositedDate;
        private DateTime _ReconcileDate;
        private string _BankAccountNo;
        private string _AccountNo;
        private int _UserNo;
        private decimal _Amount;
        private string _DepositedBy;
        private bool _IsPosted;
        private string _Narration;
        private bool _IsBounced;
        private decimal _BankPrevBal;
        private Int32 _OfficeID;



        public decimal VoucherNo { get { return _VoucherNo; } set { _VoucherNo = value; } }
        public DateTime VoucherDate { get { return _VoucherDate; } set { _VoucherDate = value; } }
        public bool IsCheque { get { return _IsCheque; } set { _IsCheque = value; } }
        public string ChequeNo { get { return _ChequeNo; } set { _ChequeNo = value; } }
        public DateTime ChequeDate { get { return _ChequeDate; } set { _ChequeDate = value; } }
        public string SlipNo { get { return _SlipNo; } set { _SlipNo = value; } }
        public DateTime DepositedDate { get { return _DepositedDate; } set { _DepositedDate = value; } }
        public DateTime ReconcileDate { get { return _ReconcileDate; } set { _ReconcileDate = value; } }
        public string BankAccountNo { get { return _BankAccountNo; } set { _BankAccountNo = value; } }
        public string AccountNo { get { return _AccountNo; } set { _AccountNo = value; } }
        public int UserNo { get { return _UserNo; } set { _UserNo = value; } }
        public decimal Amount { get { return _Amount; } set { _Amount = value; } }
        public string DepositedBy { get { return _DepositedBy; } set { _DepositedBy = value; } }
        public bool IsPosted { get { return _IsPosted; } set { _IsPosted = value; } }
        public string Narration { get { return _Narration; } set { _Narration = value; } }
        public bool IsBounced { get { return _IsBounced; } set { _IsBounced = value; } }
        public decimal BankPrevBal { get { return _BankPrevBal; } set { _BankPrevBal = value; } }
        public Int32 OfficeID { get { return _OfficeID; } set { _OfficeID = value; } }


    }
}