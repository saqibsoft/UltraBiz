using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class CompanyDiscounts
    {
        private string _CustomerId;
        private string _CompanyID;
        private decimal _PurDiscRatio;
        private decimal _SalDiscRatio;
        private decimal _PurDiscVal;
        private decimal _SalDiscVal;



        public string CustomerId { get { return _CustomerId; } set { _CustomerId = value; } }
        public string CompanyID { get { return _CompanyID; } set { _CompanyID = value; } }
        public decimal PurDiscRatio { get { return _PurDiscRatio; } set { _PurDiscRatio = value; } }
        public decimal SalDiscRatio { get { return _SalDiscRatio; } set { _SalDiscRatio = value; } }
        public decimal PurDiscVal { get { return _PurDiscVal; } set { _PurDiscVal = value; } }
        public decimal SalDiscVal { get { return _SalDiscVal; } set { _SalDiscVal = value; } }


    }
}