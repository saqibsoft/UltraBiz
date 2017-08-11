using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class CompanySpecialDisc
    {
        private Int32 _ID;
        private DateTime _Date;
        private string _CompanyID;
        private string _CompanyName;
        private string _PartyType;
        private string _TownName;
        private string _SectorName;
        private string _PartyGroup;
        private string _City;
        private string _Narration;



        public Int32 ID { get { return _ID; } set { _ID = value; } }
        public DateTime Date { get { return _Date; } set { _Date = value; } }
        public string CompanyID { get { return _CompanyID; } set { _CompanyID = value; } }
        public string CompanyName { get { return _CompanyName; } set { _CompanyName = value; } }
        public string PartyType { get { return _PartyType; } set { _PartyType = value; } }
        public string TownName { get { return _TownName; } set { _TownName = value; } }
        public string SectorName { get { return _SectorName; } set { _SectorName = value; } }
        public string PartyGroup { get { return _PartyGroup; } set { _PartyGroup = value; } }
        public string City { get { return _City; } set { _City = value; } }
        public string Narration { get { return _Narration; } set { _Narration = value; } }


    }
}