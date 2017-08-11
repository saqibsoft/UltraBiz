using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class SaleReturnsBody
    {
        private Int32 _ReturnId;
        private string _ProductId;
        private int _PackingId;
        private decimal _Multiplier;
        private Int32 _QtyPack;
        private Int32 _QtyLose;
        private int _BnsLose;
        private decimal _PricePack;
        private decimal _DiscRatio;
        private decimal _DiscValLose;
        private decimal _DiscValPack;
        private decimal _OfferDiscount;
        private decimal _ExFromSTax;
        private decimal _STaxRatio;
        private decimal _STaxValPack;
        private bool _IsValueB4Ratio;
        private bool _IsSTaxOnBnsPur;
        private bool _IsSTaxOnBns;
        private bool _IsFTaxExempted;
        private decimal _TTLValue;
        private decimal _TTLSTax;
        private decimal _TTLFTax;
        private decimal _ExtraSTaxBns;
        private decimal _ExtraFTaxBns;
        private Int32 _PriceHistoryId;
        private decimal _PerUnitCostLose;
        private bool _IsFreeProduct;
        private bool _IsDeleted;
        private decimal _LastSalePrice;



        public Int32 ReturnId { get { return _ReturnId; } set { _ReturnId = value; } }
        public string ProductId { get { return _ProductId; } set { _ProductId = value; } }
        public int PackingId { get { return _PackingId; } set { _PackingId = value; } }
        public decimal Multiplier { get { return _Multiplier; } set { _Multiplier = value; } }
        public Int32 QtyPack { get { return _QtyPack; } set { _QtyPack = value; } }
        public Int32 QtyLose { get { return _QtyLose; } set { _QtyLose = value; } }
        public int BnsLose { get { return _BnsLose; } set { _BnsLose = value; } }
        public decimal PricePack { get { return _PricePack; } set { _PricePack = value; } }
        public decimal DiscRatio { get { return _DiscRatio; } set { _DiscRatio = value; } }
        public decimal DiscValLose { get { return _DiscValLose; } set { _DiscValLose = value; } }
        public decimal DiscValPack { get { return _DiscValPack; } set { _DiscValPack = value; } }
        public decimal OfferDiscount { get { return _OfferDiscount; } set { _OfferDiscount = value; } }
        public decimal ExFromSTax { get { return _ExFromSTax; } set { _ExFromSTax = value; } }
        public decimal STaxRatio { get { return _STaxRatio; } set { _STaxRatio = value; } }
        public decimal STaxValPack { get { return _STaxValPack; } set { _STaxValPack = value; } }
        public bool IsValueB4Ratio { get { return _IsValueB4Ratio; } set { _IsValueB4Ratio = value; } }
        public bool IsSTaxOnBnsPur { get { return _IsSTaxOnBnsPur; } set { _IsSTaxOnBnsPur = value; } }
        public bool IsSTaxOnBns { get { return _IsSTaxOnBns; } set { _IsSTaxOnBns = value; } }
        public bool IsFTaxExempted { get { return _IsFTaxExempted; } set { _IsFTaxExempted = value; } }
        public decimal TTLValue { get { return _TTLValue; } set { _TTLValue = value; } }
        public decimal TTLSTax { get { return _TTLSTax; } set { _TTLSTax = value; } }
        public decimal TTLFTax { get { return _TTLFTax; } set { _TTLFTax = value; } }
        public decimal ExtraSTaxBns { get { return _ExtraSTaxBns; } set { _ExtraSTaxBns = value; } }
        public decimal ExtraFTaxBns { get { return _ExtraFTaxBns; } set { _ExtraFTaxBns = value; } }
        public Int32 PriceHistoryId { get { return _PriceHistoryId; } set { _PriceHistoryId = value; } }
        public decimal PerUnitCostLose { get { return _PerUnitCostLose; } set { _PerUnitCostLose = value; } }
        public bool IsFreeProduct { get { return _IsFreeProduct; } set { _IsFreeProduct = value; } }
        public bool IsDeleted { get { return _IsDeleted; } set { _IsDeleted = value; } }
        public decimal LastSalePrice { get { return _LastSalePrice; } set { _LastSalePrice = value; } }


    }
}