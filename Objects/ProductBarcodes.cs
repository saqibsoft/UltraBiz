using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class ProductBarcodes
    {
        private string _ProductID;
        private string _BarCode;
        private string _ShortCode;



        public string ProductID { get { return _ProductID; } set { _ProductID = value; } }
        public string BarCode { get { return _BarCode; } set { _BarCode = value; } }
        public string ShortCode { get { return _ShortCode; } set { _ShortCode = value; } }


    }
}