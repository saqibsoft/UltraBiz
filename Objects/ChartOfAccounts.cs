using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class ChartOfAccounts
    {
        private string _AccountNo;
        private int _UserNo;
        private string _AccountName;
        private string _AccountType;
        private int _AccountDepth;
        private string _Narration;
        private string _ParentAccountNo;
        private decimal _OpeningDebit;
        private decimal _OpeningCredit;
        private decimal _AdjustedDebit;
        private decimal _AdjustedCredit;
        private bool _IsDetailed;
        private bool _IsLocked;
        private bool _IsPosted;
        private bool _IsEditable;
        private bool _BalFlag;
        private string _PLFlag;
        private bool _ExpFlag;
        private DateTime _EntryDate;
        private decimal _Life;
        private decimal _ResidualValue;
        private string _AccountNameUrdu;
        private bool _IsSold;
        private bool _InActive;
        private Int32 _OfficeID;



        public string AccountNo { get { return _AccountNo; } set { _AccountNo = value; } }
        public int UserNo { get { return _UserNo; } set { _UserNo = value; } }
        public string AccountName { get { return _AccountName; } set { _AccountName = value; } }
        public string AccountType { get { return _AccountType; } set { _AccountType = value; } }
        public int AccountDepth { get { return _AccountDepth; } set { _AccountDepth = value; } }
        public string Narration { get { return _Narration; } set { _Narration = value; } }
        public string ParentAccountNo { get { return _ParentAccountNo; } set { _ParentAccountNo = value; } }
        public decimal OpeningDebit { get { return _OpeningDebit; } set { _OpeningDebit = value; } }
        public decimal OpeningCredit { get { return _OpeningCredit; } set { _OpeningCredit = value; } }
        public decimal AdjustedDebit { get { return _AdjustedDebit; } set { _AdjustedDebit = value; } }
        public decimal AdjustedCredit { get { return _AdjustedCredit; } set { _AdjustedCredit = value; } }
        public bool IsDetailed { get { return _IsDetailed; } set { _IsDetailed = value; } }
        public bool IsLocked { get { return _IsLocked; } set { _IsLocked = value; } }
        public bool IsPosted { get { return _IsPosted; } set { _IsPosted = value; } }
        public bool IsEditable { get { return _IsEditable; } set { _IsEditable = value; } }
        public bool BalFlag { get { return _BalFlag; } set { _BalFlag = value; } }
        public string PLFlag { get { return _PLFlag; } set { _PLFlag = value; } }
        public bool ExpFlag { get { return _ExpFlag; } set { _ExpFlag = value; } }
        public DateTime EntryDate { get { return _EntryDate; } set { _EntryDate = value; } }
        public decimal Life { get { return _Life; } set { _Life = value; } }
        public decimal ResidualValue { get { return _ResidualValue; } set { _ResidualValue = value; } }
        public string AccountNameUrdu { get { return _AccountNameUrdu; } set { _AccountNameUrdu = value; } }
        public bool IsSold { get { return _IsSold; } set { _IsSold = value; } }
        public bool InActive { get { return _InActive; } set { _InActive = value; } }
        public Int32 OfficeID { get { return _OfficeID; } set { _OfficeID = value; } }


    }
}