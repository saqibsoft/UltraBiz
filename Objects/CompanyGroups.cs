using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class CompanyGroups
    {
        private Int32 _GroupID;
        private string _GroupName;
        private string _CompanyID;



        public Int32 GroupID { get { return _GroupID; } set { _GroupID = value; } }
        public string GroupName { get { return _GroupName; } set { _GroupName = value; } }
        public string CompanyID { get { return _CompanyID; } set { _CompanyID = value; } }


    }
}
