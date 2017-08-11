using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class SaleReturns
    {
private Int32 _ReturnId;
private string _ReturnDate;
private Int32 _SaleId;
private string _SalesmanId;
private string _CustomerId;
private bool _IsStockist;
private bool _OldIsStockist;
private decimal _Disc2Ratio;
private decimal _FTaxRatio;
private decimal _SpecialDiscount;
private decimal _InvOfferDiscount;
private decimal _InvOfferSTax;
private decimal _InvOfferFTax;
private decimal _PaidAmount;
private decimal _PreviousCredit;
private string _Narration;
private bool _IsPosted;
private int _UserNo;
private Int32 _OfficeID;



public Int32 ReturnId { get{return _ReturnId;} set {_ReturnId = value;} }
public string ReturnDate { get{return _ReturnDate;} set {_ReturnDate = value;} }
public Int32 SaleId { get{return _SaleId;} set {_SaleId = value;} }
public string SalesmanId { get{return _SalesmanId;} set {_SalesmanId = value;} }
public string CustomerId { get{return _CustomerId;} set {_CustomerId = value;} }
public bool IsStockist { get{return _IsStockist;} set {_IsStockist = value;} }
public bool OldIsStockist { get{return _OldIsStockist;} set {_OldIsStockist = value;} }
public decimal Disc2Ratio { get{return _Disc2Ratio;} set {_Disc2Ratio = value;} }
public decimal FTaxRatio { get{return _FTaxRatio;} set {_FTaxRatio = value;} }
public decimal SpecialDiscount { get{return _SpecialDiscount;} set {_SpecialDiscount = value;} }
public decimal InvOfferDiscount { get{return _InvOfferDiscount;} set {_InvOfferDiscount = value;} }
public decimal InvOfferSTax { get{return _InvOfferSTax;} set {_InvOfferSTax = value;} }
public decimal InvOfferFTax { get{return _InvOfferFTax;} set {_InvOfferFTax = value;} }
public decimal PaidAmount { get{return _PaidAmount;} set {_PaidAmount = value;} }
public decimal PreviousCredit { get{return _PreviousCredit;} set {_PreviousCredit = value;} }
public string Narration { get{return _Narration;} set {_Narration = value;} }
public bool IsPosted { get{return _IsPosted;} set {_IsPosted = value;} }
public int UserNo { get{return _UserNo;} set {_UserNo = value;} }
public Int32 OfficeID { get { return _OfficeID; } set { _OfficeID = value; } }
}
    
    }

 