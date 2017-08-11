using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class BankCheques
    {

        private decimal _VoucherNo;
        private DateTime _VoucherDate;
        private string _ChequeNo;
        private DateTime _ChequeDate;
        private DateTime _ReconcileDate;
        private string _BankAccountNo;
        private string _AccountNo;
        private int _UserNo;
        private decimal _Amount;
        private string _ReceivedBy;
        private bool _IsPosted;
        private string _Narration;
        private bool _IsLost;
        private decimal _PrevBal;
        private decimal _BankPrevBal;
        private Int32 _OfficeID;



        public decimal VoucherNo { get { return _VoucherNo; } set { _VoucherNo = value; } }
        public DateTime VoucherDate { get { return _VoucherDate; } set { _VoucherDate = value; } }
        public string ChequeNo { get { return _ChequeNo; } set { _ChequeNo = value; } }
        public DateTime ChequeDate { get { return _ChequeDate; } set { _ChequeDate = value; } }
        public DateTime ReconcileDate { get { return _ReconcileDate; } set { _ReconcileDate = value; } }
        public string BankAccountNo { get { return _BankAccountNo; } set { _BankAccountNo = value; } }
        public string AccountNo { get { return _AccountNo; } set { _AccountNo = value; } }
        public int UserNo { get { return _UserNo; } set { _UserNo = value; } }
        public decimal Amount { get { return _Amount; } set { _Amount = value; } }
        public string ReceivedBy { get { return _ReceivedBy; } set { _ReceivedBy = value; } }
        public bool IsPosted { get { return _IsPosted; } set { _IsPosted = value; } }
        public string Narration { get { return _Narration; } set { _Narration = value; } }
        public bool IsLost { get { return _IsLost; } set { _IsLost = value; } }
        public decimal PrevBal { get { return _PrevBal; } set { _PrevBal = value; } }
        public decimal BankPrevBal { get { return _BankPrevBal; } set { _BankPrevBal = value; } }
        public Int32 OfficeID { get { return _OfficeID; } set { _OfficeID = value; } }


    }
}
