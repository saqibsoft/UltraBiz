using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class PartyGroups
    {
        private Int32 _GroupID;
        private string _GroupName;



        public Int32 GroupID { get { return _GroupID; } set { _GroupID = value; } }
        public string GroupName { get { return _GroupName; } set { _GroupName = value; } }


    }
}