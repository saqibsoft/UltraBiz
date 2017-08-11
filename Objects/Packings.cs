using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Packings
    {
        private int _PackingId;
        private string _PackingName;
        private string _Abbrevation;



        public int PackingId { get { return _PackingId; } set { _PackingId = value; } }
        public string PackingName { get { return _PackingName; } set { _PackingName = value; } }
        public string Abbrevation { get { return _Abbrevation; } set { _Abbrevation = value; } }


    }
}