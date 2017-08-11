using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Sectors
    {
        private int _SectorID;
        private Int32 _TownID;
        private string _SectorName;
        private int _SectorOrder;



        public int SectorID { get { return _SectorID; } set { _SectorID = value; } }
        public Int32 TownID { get { return _TownID; } set { _TownID = value; } }
        public string SectorName { get { return _SectorName; } set { _SectorName = value; } }
        public int SectorOrder { get { return _SectorOrder; } set { _SectorOrder = value; } }


    }
}