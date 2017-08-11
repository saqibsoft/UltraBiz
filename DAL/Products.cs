using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;


namespace DAL
{
    public class Products
    {
        public string connectionstring;
        public void InsertRecord(Objects.Products obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ProductsInsert";

                /**/
                cmd.Parameters.AddWithValue("@ProductID", obj.ProductID);
                cmd.Parameters.AddWithValue("@CompanyID", obj.CompanyID);
                cmd.Parameters.AddWithValue("@GroupId", obj.GroupId);
                cmd.Parameters.AddWithValue("@SubGroupId", obj.SubGroupId);
                cmd.Parameters.AddWithValue("@Size", obj.Size);
                cmd.Parameters.AddWithValue("@UnitId", obj.UnitId);
                cmd.Parameters.AddWithValue("@ProductName", obj.ProductName);
                cmd.Parameters.AddWithValue("@PurchasePrice", obj.PurchasePrice);
                cmd.Parameters.AddWithValue("@SalePrice", obj.SalePrice);
                cmd.Parameters.AddWithValue("@PurDiscRatio", obj.PurDiscRatio);
                cmd.Parameters.AddWithValue("@SaleDiscRatio", obj.SaleDiscRatio);
                cmd.Parameters.AddWithValue("@PurDiscValue", obj.PurDiscValue);
                cmd.Parameters.AddWithValue("@SaleDiscValue", obj.SaleDiscValue);
                cmd.Parameters.AddWithValue("@PurSTRatio", obj.PurSTRatio);
                cmd.Parameters.AddWithValue("@SaleSTRatio", obj.SaleSTRatio);
                cmd.Parameters.AddWithValue("@PurPackingId", obj.PurPackingId);
                cmd.Parameters.AddWithValue("@SalPackingId", obj.SalPackingId);
                cmd.Parameters.AddWithValue("@RetailPrice", obj.RetailPrice);
                cmd.Parameters.AddWithValue("@IsValueB4Ratio", obj.IsValueB4Ratio);
                cmd.Parameters.AddWithValue("@IsFTaxExempted", obj.IsFTaxExempted);
                cmd.Parameters.AddWithValue("@PriceControlId", obj.PriceControlId);
                cmd.Parameters.AddWithValue("@IsFTaxOnRP", obj.IsFTaxOnRP);
                cmd.Parameters.AddWithValue("@UrduName", obj.UrduName);
                cmd.Parameters.AddWithValue("@PurchasePrice2", obj.PurchasePrice2);
                cmd.Parameters.AddWithValue("@PurchasePrice3", obj.PurchasePrice3);
                cmd.Parameters.AddWithValue("@SalePrice2", obj.SalePrice2);
                cmd.Parameters.AddWithValue("@SalePrice3", obj.SalePrice3);
                cmd.Parameters.AddWithValue("@MinStockLevel", obj.MinStockLevel);
                cmd.Parameters.AddWithValue("@MinStockPackId", obj.MinStockPackId);
                cmd.Parameters.AddWithValue("@BarCode", obj.BarCode);
                cmd.Parameters.AddWithValue("@ShortCode", obj.ShortCode);
                cmd.Parameters.AddWithValue("@ProductWeight", obj.ProductWeight);
                cmd.Parameters.AddWithValue("@LabourCharges", obj.LabourCharges);
                cmd.Parameters.AddWithValue("@RPTaxRate", obj.RPTaxRate);
                cmd.Parameters.AddWithValue("@ProductWeight2", obj.ProductWeight2);
                cmd.Parameters.AddWithValue("@MinSalePrice", obj.MinSalePrice);
                cmd.Parameters.AddWithValue("@MaxSalePrice", obj.MaxSalePrice);
                cmd.Parameters.AddWithValue("@MaxStockLevel", obj.MaxStockLevel);
                cmd.Parameters.AddWithValue("@ShelfName", obj.ShelfName);
                cmd.Parameters.AddWithValue("@IsActive", obj.IsActive);
                cmd.Parameters.AddWithValue("@ProductNameUrdu", obj.ProductNameUrdu);
                cmd.Parameters.AddWithValue("@ProductNameShort", obj.ProductNameShort);
                cmd.Parameters.AddWithValue("@BrandID", obj.BrandID);
                cmd.Parameters.AddWithValue("@ManualCode", obj.ManualCode);
                cmd.Parameters.AddWithValue("@Point", obj.Point);
                cmd.Parameters.AddWithValue("@Shade", obj.Shade);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.Products obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ProductsUpdate";

                cmd.Parameters.AddWithValue("@ProductID", obj.ProductID);
                cmd.Parameters.AddWithValue("@CompanyID", obj.CompanyID);
                cmd.Parameters.AddWithValue("@GroupId", obj.GroupId);
                cmd.Parameters.AddWithValue("@SubGroupId", obj.SubGroupId);
                cmd.Parameters.AddWithValue("@Size", obj.Size);
                cmd.Parameters.AddWithValue("@UnitId", obj.UnitId);
                cmd.Parameters.AddWithValue("@ProductName", obj.ProductName);
                cmd.Parameters.AddWithValue("@PurchasePrice", obj.PurchasePrice);
                cmd.Parameters.AddWithValue("@SalePrice", obj.SalePrice);
                cmd.Parameters.AddWithValue("@PurDiscRatio", obj.PurDiscRatio);
                cmd.Parameters.AddWithValue("@SaleDiscRatio", obj.SaleDiscRatio);
                cmd.Parameters.AddWithValue("@PurDiscValue", obj.PurDiscValue);
                cmd.Parameters.AddWithValue("@SaleDiscValue", obj.SaleDiscValue);
                cmd.Parameters.AddWithValue("@PurSTRatio", obj.PurSTRatio);
                cmd.Parameters.AddWithValue("@SaleSTRatio", obj.SaleSTRatio);
                cmd.Parameters.AddWithValue("@PurPackingId", obj.PurPackingId);
                cmd.Parameters.AddWithValue("@SalPackingId", obj.SalPackingId);
                cmd.Parameters.AddWithValue("@RetailPrice", obj.RetailPrice);
                cmd.Parameters.AddWithValue("@IsValueB4Ratio", obj.IsValueB4Ratio);
                cmd.Parameters.AddWithValue("@IsFTaxExempted", obj.IsFTaxExempted);
                cmd.Parameters.AddWithValue("@PriceControlId", obj.PriceControlId);
                cmd.Parameters.AddWithValue("@IsFTaxOnRP", obj.IsFTaxOnRP);
                cmd.Parameters.AddWithValue("@UrduName", obj.UrduName);
                cmd.Parameters.AddWithValue("@PurchasePrice2", obj.PurchasePrice2);
                cmd.Parameters.AddWithValue("@PurchasePrice3", obj.PurchasePrice3);
                cmd.Parameters.AddWithValue("@SalePrice2", obj.SalePrice2);
                cmd.Parameters.AddWithValue("@SalePrice3", obj.SalePrice3);
                cmd.Parameters.AddWithValue("@MinStockLevel", obj.MinStockLevel);
                cmd.Parameters.AddWithValue("@MinStockPackId", obj.MinStockPackId);
                cmd.Parameters.AddWithValue("@BarCode", obj.BarCode);
                cmd.Parameters.AddWithValue("@ShortCode", obj.ShortCode);
                cmd.Parameters.AddWithValue("@ProductWeight", obj.ProductWeight);
                cmd.Parameters.AddWithValue("@LabourCharges", obj.LabourCharges);
                cmd.Parameters.AddWithValue("@RPTaxRate", obj.RPTaxRate);
                cmd.Parameters.AddWithValue("@ProductWeight2", obj.ProductWeight2);
                cmd.Parameters.AddWithValue("@MinSalePrice", obj.MinSalePrice);
                cmd.Parameters.AddWithValue("@MaxSalePrice", obj.MaxSalePrice);
                cmd.Parameters.AddWithValue("@MaxStockLevel", obj.MaxStockLevel);
                cmd.Parameters.AddWithValue("@ShelfName", obj.ShelfName);
                cmd.Parameters.AddWithValue("@IsActive", obj.IsActive);
                cmd.Parameters.AddWithValue("@ProductNameUrdu", obj.ProductNameUrdu);
                cmd.Parameters.AddWithValue("@ProductNameShort", obj.ProductNameShort);
                cmd.Parameters.AddWithValue("@BrandID", obj.BrandID);
                cmd.Parameters.AddWithValue("@ManualCode", obj.ManualCode);
                cmd.Parameters.AddWithValue("@Point", obj.Point);
                cmd.Parameters.AddWithValue("@Shade", obj.Shade);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void DeleteRecord(Int64 vID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ProductsDelete";

                cmd.Parameters.AddWithValue("@ProductID", vID);
                new Database(connectionstring).ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }
        }
        public DataTable getRecord(string vWhere)
        {
            string query = @"SELECT     * from Products Where 1=1 {0}";
            DataSet ds = new DataSet();

            try
            {

                ds = new Database(connectionstring).ExecuteForDataSet(string.Format(query, vWhere));
                return ds.Tables[0];

            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public int getNextNo()
        {
            int vNextID = 1;

            string vSql = "Select COALESCE(MAX(Isnull(ProductID,0)),0) + 1  as ProductID From Products ";


            try
            {
                DataSet ds = new Database(connectionstring).ExecuteForDataSet(string.Format(vSql));
                vNextID = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            }
            catch (Exception exc)
            {

                throw exc;
            }
            return vNextID;
        }

        public DataTable getSchRecord(string vWhere)
        {
            string query = @"
                            SELECT     TOP (100) PERCENT p.ProductID, p.ManualCode, p.ProductName, c.CompanyName, ISNULL(cs.QtyLose, 0) AS CStock, ISNULL(p.MinSalePrice, 0) AS MinSalePrice, 
                                                  ISNULL(p.MaxSalePrice, 0) AS MaxSalePrice
                            FROM         dbo.Products AS p INNER JOIN
                                                  dbo.Companies AS c ON c.CompanyID = p.CompanyID LEFT OUTER JOIN
                                                  dbo.CurrentStock AS cs ON p.ProductID = cs.ProductiD LEFT OUTER JOIN
                                                  dbo.ProductBarcodes AS pb ON p.ProductID = pb.ProductID
                            Where 1=1 {0}
                            GROUP BY p.ProductID, p.ManualCode, p.ProductName, c.CompanyName, ISNULL(cs.QtyLose, 0), ISNULL(p.MinSalePrice, 0), ISNULL(p.MaxSalePrice, 0)
                            ORDER BY p.ProductName"
                            ;

            DataSet ds = new DataSet();

            try
            {

                ds = new Database(connectionstring).ExecuteForDataSet(string.Format(query, vWhere));
                return ds.Tables[0];

            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
    }
}