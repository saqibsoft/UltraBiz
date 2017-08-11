using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class CreditVouchers
    {
        private int _VoucherNo;
        private DateTime _VoucherDate;
        private string _LastUpdateDate;
        private int _UserNo;
        private int _OfficeID;
        private bool _IsUploaded;
        private bool _IsPosted;



        public int VoucherNo { get { return _VoucherNo; } set { _VoucherNo = value; } }
        public DateTime VoucherDate { get { return _VoucherDate; } set { _VoucherDate = value; } }
        public string LastUpdateDate { get { return _LastUpdateDate; } set { _LastUpdateDate = value; } }
        public int UserNo { get { return _UserNo; } set { _UserNo = value; } }
        public int OfficeID { get { return _OfficeID; } set { _OfficeID = value; } }
        public bool IsUploaded { get { return _IsUploaded; } set { _IsUploaded = value; } }
        public bool IsPosted { get { return _IsPosted; } set { _IsPosted = value; } }


    }
}