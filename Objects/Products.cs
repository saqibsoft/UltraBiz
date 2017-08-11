using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Products
    {
        private string _ProductID;
        private string _CompanyID;
        private Int32 _GroupId;
        private int _SubGroupId;
        private decimal _Size;
        private string _UnitId;
        private string _ProductName;
        private decimal _PurchasePrice;
        private decimal _SalePrice;
        private decimal _PurDiscRatio;
        private decimal _SaleDiscRatio;
        private decimal _PurDiscValue;
        private decimal _SaleDiscValue;
        private decimal _PurSTRatio;
        private decimal _SaleSTRatio;
        private int _PurPackingId;
        private int _SalPackingId;
        private decimal _RetailPrice;
        private bool _IsValueB4Ratio;
        private bool _IsFTaxExempted;
        private Int32 _PriceControlId;
        private bool _IsFTaxOnRP;
        private string _UrduName;
        private decimal _PurchasePrice2;
        private decimal _PurchasePrice3;
        private decimal _SalePrice2;
        private decimal _SalePrice3;
        private Int32 _MinStockLevel;
        private int _MinStockPackId;
        private string _BarCode;
        private string _ShortCode;
        private decimal _ProductWeight;
        private decimal _LabourCharges;
        private decimal _RPTaxRate;
        private decimal _ProductWeight2;
        private decimal _MinSalePrice;
        private decimal _MaxSalePrice;
        private Int32 _MaxStockLevel;
        private string _ShelfName;
        private bool _IsActive;
        private string _ProductNameUrdu;
        private string _ProductNameShort;
        private Int32 _BrandID;
        private string _ManualCode;
        private string _Point;
        private string _Shade;



        public string ProductID { get { return _ProductID; } set { _ProductID = value; } }
        public string CompanyID { get { return _CompanyID; } set { _CompanyID = value; } }
        public Int32 GroupId { get { return _GroupId; } set { _GroupId = value; } }
        public int SubGroupId { get { return _SubGroupId; } set { _SubGroupId = value; } }
        public decimal Size { get { return _Size; } set { _Size = value; } }
        public string UnitId { get { return _UnitId; } set { _UnitId = value; } }
        public string ProductName { get { return _ProductName; } set { _ProductName = value; } }
        public decimal PurchasePrice { get { return _PurchasePrice; } set { _PurchasePrice = value; } }
        public decimal SalePrice { get { return _SalePrice; } set { _SalePrice = value; } }
        public decimal PurDiscRatio { get { return _PurDiscRatio; } set { _PurDiscRatio = value; } }
        public decimal SaleDiscRatio { get { return _SaleDiscRatio; } set { _SaleDiscRatio = value; } }
        public decimal PurDiscValue { get { return _PurDiscValue; } set { _PurDiscValue = value; } }
        public decimal SaleDiscValue { get { return _SaleDiscValue; } set { _SaleDiscValue = value; } }
        public decimal PurSTRatio { get { return _PurSTRatio; } set { _PurSTRatio = value; } }
        public decimal SaleSTRatio { get { return _SaleSTRatio; } set { _SaleSTRatio = value; } }
        public int PurPackingId { get { return _PurPackingId; } set { _PurPackingId = value; } }
        public int SalPackingId { get { return _SalPackingId; } set { _SalPackingId = value; } }
        public decimal RetailPrice { get { return _RetailPrice; } set { _RetailPrice = value; } }
        public bool IsValueB4Ratio { get { return _IsValueB4Ratio; } set { _IsValueB4Ratio = value; } }
        public bool IsFTaxExempted { get { return _IsFTaxExempted; } set { _IsFTaxExempted = value; } }
        public Int32 PriceControlId { get { return _PriceControlId; } set { _PriceControlId = value; } }
        public bool IsFTaxOnRP { get { return _IsFTaxOnRP; } set { _IsFTaxOnRP = value; } }
        public string UrduName { get { return _UrduName; } set { _UrduName = value; } }
        public decimal PurchasePrice2 { get { return _PurchasePrice2; } set { _PurchasePrice2 = value; } }
        public decimal PurchasePrice3 { get { return _PurchasePrice3; } set { _PurchasePrice3 = value; } }
        public decimal SalePrice2 { get { return _SalePrice2; } set { _SalePrice2 = value; } }
        public decimal SalePrice3 { get { return _SalePrice3; } set { _SalePrice3 = value; } }
        public Int32 MinStockLevel { get { return _MinStockLevel; } set { _MinStockLevel = value; } }
        public int MinStockPackId { get { return _MinStockPackId; } set { _MinStockPackId = value; } }
        public string BarCode { get { return _BarCode; } set { _BarCode = value; } }
        public string ShortCode { get { return _ShortCode; } set { _ShortCode = value; } }
        public decimal ProductWeight { get { return _ProductWeight; } set { _ProductWeight = value; } }
        public decimal LabourCharges { get { return _LabourCharges; } set { _LabourCharges = value; } }
        public decimal RPTaxRate { get { return _RPTaxRate; } set { _RPTaxRate = value; } }
        public decimal ProductWeight2 { get { return _ProductWeight2; } set { _ProductWeight2 = value; } }
        public decimal MinSalePrice { get { return _MinSalePrice; } set { _MinSalePrice = value; } }
        public decimal MaxSalePrice { get { return _MaxSalePrice; } set { _MaxSalePrice = value; } }
        public Int32 MaxStockLevel { get { return _MaxStockLevel; } set { _MaxStockLevel = value; } }
        public string ShelfName { get { return _ShelfName; } set { _ShelfName = value; } }
        public bool IsActive { get { return _IsActive; } set { _IsActive = value; } }
        public string ProductNameUrdu { get { return _ProductNameUrdu; } set { _ProductNameUrdu = value; } }
        public string ProductNameShort { get { return _ProductNameShort; } set { _ProductNameShort = value; } }
        public Int32 BrandID { get { return _BrandID; } set { _BrandID = value; } }
        public string ManualCode { get { return _ManualCode; } set { _ManualCode = value; } }
        public string Point { get { return _Point; } set { _Point = value; } }
        public string Shade { get { return _Shade; } set { _Shade = value; } }


    }
}