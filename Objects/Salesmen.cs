using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Salesmen
    {
        private string _SalesmanID;
        private string _SalesmanName;
        private string _Address;
        private string _City;
        private string _Phone;
        private string _Mobile;
        private string _NIC;
        private decimal _CommissionRatio;
        private int _OfficeID;
        private bool _IsStockHolder;
        private string _Designation;
        private bool _IsStaff;



        public string SalesmanID { get { return _SalesmanID; } set { _SalesmanID = value; } }
        public string SalesmanName { get { return _SalesmanName; } set { _SalesmanName = value; } }
        public string Address { get { return _Address; } set { _Address = value; } }
        public string City { get { return _City; } set { _City = value; } }
        public string Phone { get { return _Phone; } set { _Phone = value; } }
        public string Mobile { get { return _Mobile; } set { _Mobile = value; } }
        public string NIC { get { return _NIC; } set { _NIC = value; } }
        public decimal CommissionRatio { get { return _CommissionRatio; } set { _CommissionRatio = value; } }
        public int OfficeID { get { return _OfficeID; } set { _OfficeID = value; } }
        public bool IsStockHolder { get { return _IsStockHolder; } set { _IsStockHolder = value; } }
        public string Designation { get { return _Designation; } set { _Designation = value; } }
        public bool IsStaff { get { return _IsStaff; } set { _IsStaff = value; } }


    }
}