using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Offices
    {
        private int _OfficeID;
        private string _Description;



        public int OfficeID { get { return _OfficeID; } set { _OfficeID = value; } }
        public string Description { get { return _Description; } set { _Description = value; } }


    }
}
