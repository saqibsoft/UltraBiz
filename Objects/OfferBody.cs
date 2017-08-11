using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class OfferBody
    {
        private Int64 _SerialNo;
        private Int64 _OfferID;
        private string _ProductID;
        private Int32 _QtyLose;



        public Int64 SerialNo { get { return _SerialNo; } set { _SerialNo = value; } }
        public Int64 OfferID { get { return _OfferID; } set { _OfferID = value; } }
        public string ProductID { get { return _ProductID; } set { _ProductID = value; } }
        public Int32 QtyLose { get { return _QtyLose; } set { _QtyLose = value; } }


    }
}