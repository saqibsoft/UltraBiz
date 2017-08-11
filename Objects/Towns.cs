using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{

    public class Towns
    {
        private Int32 _TownID;
        private string _TownName;



        public Int32 TownID { get { return _TownID; } set { _TownID = value; } }
        public string TownName { get { return _TownName; } set { _TownName = value; } }

 
    }
}
