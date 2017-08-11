using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Transport
    {
        private int _TransportID;
        private string _TransportName;



        public int TransportID { get { return _TransportID; } set { _TransportID = value; } }
        public string TransportName { get { return _TransportName; } set { _TransportName = value; } }


    }
}
