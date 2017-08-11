using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Exceed
    {
        private Int32 _InvoiceId;
        private DateTime _InvoiceDate;
        private string _Narration;



        public Int32 InvoiceId { get { return _InvoiceId; } set { _InvoiceId = value; } }
        public DateTime InvoiceDate { get { return _InvoiceDate; } set { _InvoiceDate = value; } }
        public string Narration { get { return _Narration; } set { _Narration = value; } }


    }
}