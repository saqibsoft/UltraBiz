using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class CashCollection
    {
        private Int32 _CollectionId;
        private DateTime _CollectionDate;
        private string _SalesmanID;
        private Int32 _TownID;
        private Int32 _Sectorid;



        public Int32 CollectionId { get { return _CollectionId; } set { _CollectionId = value; } }
        public DateTime CollectionDate { get { return _CollectionDate; } set { _CollectionDate = value; } }
        public string SalesmanID { get { return _SalesmanID; } set { _SalesmanID = value; } }
        public Int32 TownID { get { return _TownID; } set { _TownID = value; } }
        public Int32 Sectorid { get { return _Sectorid; } set { _Sectorid = value; } }


    }
}