using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Companies
    {
        private string _CompanyID;
        private string _CompanyName;



        public string CompanyID { get { return _CompanyID; } set { _CompanyID = value; } }
        public string CompanyName { get { return _CompanyName; } set { _CompanyName = value; } }


    }
}