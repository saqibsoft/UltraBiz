using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Parties
    {
        private string _PartyID;
        private string _PartyName;
        private int _SectorID;
        private string _Address;
        private string _City;
        private string _Phone1;
        private string _Phone2;
        private string _Mobile;
        private string _Fax;
        private string _EMail;
        private string _ContactPerson;
        private string _PartyType;
        private decimal _DiscRatio;
        private bool _ReceivablesFlag;
        private bool _PayablesFlag;
        private Int32 _GroupID;
        private int _DueDays;
        private decimal _DebitLimit;
        private decimal _CreditLimit;
        private string _Description;
        private bool _InActive;
        private Int32 _OfficeID;



        public string PartyID { get { return _PartyID; } set { _PartyID = value; } }
        public string PartyName { get { return _PartyName; } set { _PartyName = value; } }
        public int SectorID { get { return _SectorID; } set { _SectorID = value; } }
        public string Address { get { return _Address; } set { _Address = value; } }
        public string City { get { return _City; } set { _City = value; } }
        public string Phone1 { get { return _Phone1; } set { _Phone1 = value; } }
        public string Phone2 { get { return _Phone2; } set { _Phone2 = value; } }
        public string Mobile { get { return _Mobile; } set { _Mobile = value; } }
        public string Fax { get { return _Fax; } set { _Fax = value; } }
        public string EMail { get { return _EMail; } set { _EMail = value; } }
        public string ContactPerson { get { return _ContactPerson; } set { _ContactPerson = value; } }
        public string PartyType { get { return _PartyType; } set { _PartyType = value; } }
        public decimal DiscRatio { get { return _DiscRatio; } set { _DiscRatio = value; } }
        public bool ReceivablesFlag { get { return _ReceivablesFlag; } set { _ReceivablesFlag = value; } }
        public bool PayablesFlag { get { return _PayablesFlag; } set { _PayablesFlag = value; } }
        public Int32 GroupID { get { return _GroupID; } set { _GroupID = value; } }
        public int DueDays { get { return _DueDays; } set { _DueDays = value; } }
        public decimal DebitLimit { get { return _DebitLimit; } set { _DebitLimit = value; } }
        public decimal CreditLimit { get { return _CreditLimit; } set { _CreditLimit = value; } }
        public string Description { get { return _Description; } set { _Description = value; } }
        public bool InActive { get { return _InActive; } set { _InActive = value; } }
        public Int32 OfficeID { get { return _OfficeID; } set { _OfficeID = value; } }


    }
}