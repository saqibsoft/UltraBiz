using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;


namespace DAL
{
    public class Purchase
    {
        public string connectionstring;
        public void InsertRecord(Objects.Purchase obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_PurchaseInsert";

                /**/
                cmd.Parameters.AddWithValue("@PurchaseID", obj.PurchaseID);
                cmd.Parameters.AddWithValue("@PurchaseDate", obj.PurchaseDate);
                cmd.Parameters.AddWithValue("@OfficeID", obj.OfficeID);
                cmd.Parameters.AddWithValue("@VendorID", obj.VendorID);
                cmd.Parameters.AddWithValue("@BillNo", obj.BillNo);
                cmd.Parameters.AddWithValue("@BillDate", obj.BillDate);
                cmd.Parameters.AddWithValue("@IsUploaded", obj.IsUploaded);
                cmd.Parameters.AddWithValue("@PaidAmount", obj.PaidAmount);
                cmd.Parameters.AddWithValue("@Narration", obj.Narration);
                cmd.Parameters.AddWithValue("@SpecialDiscount", obj.SpecialDiscount);
                cmd.Parameters.AddWithValue("@CustomerId", obj.CustomerId);
                cmd.Parameters.AddWithValue("@GSTax", obj.GSTax);
                cmd.Parameters.AddWithValue("@PurOrderID", obj.PurOrderID);
                cmd.Parameters.AddWithValue("@InvOfferFTax", obj.InvOfferFTax);
                cmd.Parameters.AddWithValue("@OfferID", obj.OfferID);
                cmd.Parameters.AddWithValue("@Freight2", obj.Freight2);
                cmd.Parameters.AddWithValue("@Unloading2", obj.Unloading2);
                cmd.Parameters.AddWithValue("@ITax2", obj.ITax2);
                cmd.Parameters.AddWithValue("@BiltyNo", obj.BiltyNo);
                cmd.Parameters.AddWithValue("@PreviousBal", obj.PreviousBal);
                cmd.Parameters.AddWithValue("@FinalBalance", obj.FinalBalance);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void InsertRecordBody (Objects.PurchasesBody obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_PurchasesBodyInsert";

                /**/
                cmd.Parameters.AddWithValue("@PurchaseId", obj.PurchaseId);
                cmd.Parameters.AddWithValue("@ProductId", obj.ProductId);
                cmd.Parameters.AddWithValue("@PackingId", obj.PackingId);
                cmd.Parameters.AddWithValue("@Multiplier", obj.Multiplier);
                cmd.Parameters.AddWithValue("@QtyPack", obj.QtyPack);
                cmd.Parameters.AddWithValue("@QtyLose", obj.QtyLose);
                cmd.Parameters.AddWithValue("@BnsLose", obj.BnsLose);
                cmd.Parameters.AddWithValue("@PricePack", obj.PricePack);
                cmd.Parameters.AddWithValue("@DiscRatio", obj.DiscRatio);
                cmd.Parameters.AddWithValue("@DiscValPack", obj.DiscValPack);
                cmd.Parameters.AddWithValue("@DiscValLose", obj.DiscValLose);
                cmd.Parameters.AddWithValue("@OfferDiscount", obj.OfferDiscount);
                cmd.Parameters.AddWithValue("@STaxRatio", obj.STaxRatio);
                cmd.Parameters.AddWithValue("@STaxValPack", obj.STaxValPack);
                cmd.Parameters.AddWithValue("@IsValueB4Ratio", obj.IsValueB4Ratio);
                cmd.Parameters.AddWithValue("@IsSTaxOnBns", obj.IsSTaxOnBns);
                cmd.Parameters.AddWithValue("@IsFTaxExempted", obj.IsFTaxExempted);
                cmd.Parameters.AddWithValue("@TTLValue", obj.TTLValue);
                cmd.Parameters.AddWithValue("@TTLSTax", obj.TTLSTax);
                cmd.Parameters.AddWithValue("@TTLFTax", obj.TTLFTax);
                cmd.Parameters.AddWithValue("@ExtraSTaxBns", obj.ExtraSTaxBns);
                cmd.Parameters.AddWithValue("@ExtraFTaxBns", obj.ExtraFTaxBns);
                cmd.Parameters.AddWithValue("@PerUnitCostLose", obj.PerUnitCostLose);
                cmd.Parameters.AddWithValue("@IsFreeProduct", obj.IsFreeProduct);
                cmd.Parameters.AddWithValue("@IsDeleted", obj.IsDeleted);
                cmd.Parameters.AddWithValue("@CustomerId", obj.CustomerId);
                cmd.Parameters.AddWithValue("@OfferID", obj.OfferID);
                cmd.Parameters.AddWithValue("@IsOffered", obj.IsOffered);
                cmd.Parameters.AddWithValue("@Damage", obj.Damage);
                cmd.Parameters.AddWithValue("@BarCode", obj.BarCode);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.Purchase obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_PurchaseUpdate";

                cmd.Parameters.AddWithValue("@PurchaseID", obj.PurchaseID);
                cmd.Parameters.AddWithValue("@PurchaseDate", obj.PurchaseDate);
                cmd.Parameters.AddWithValue("@OfficeID", obj.OfficeID);
                cmd.Parameters.AddWithValue("@VendorID", obj.VendorID);
                cmd.Parameters.AddWithValue("@BillNo", obj.BillNo);
                cmd.Parameters.AddWithValue("@BillDate", obj.BillDate);
                cmd.Parameters.AddWithValue("@IsUploaded", obj.IsUploaded);
                cmd.Parameters.AddWithValue("@PaidAmount", obj.PaidAmount);
                cmd.Parameters.AddWithValue("@Narration", obj.Narration);
                cmd.Parameters.AddWithValue("@SpecialDiscount", obj.SpecialDiscount);
                cmd.Parameters.AddWithValue("@CustomerId", obj.CustomerId);
                cmd.Parameters.AddWithValue("@GSTax", obj.GSTax);
                cmd.Parameters.AddWithValue("@PurOrderID", obj.PurOrderID);
                cmd.Parameters.AddWithValue("@InvOfferFTax", obj.InvOfferFTax);
                cmd.Parameters.AddWithValue("@OfferID", obj.OfferID);
                cmd.Parameters.AddWithValue("@Freight2", obj.Freight2);
                cmd.Parameters.AddWithValue("@Unloading2", obj.Unloading2);
                cmd.Parameters.AddWithValue("@ITax2", obj.ITax2);
                cmd.Parameters.AddWithValue("@BiltyNo", obj.BiltyNo);
                cmd.Parameters.AddWithValue("@PreviousBal", obj.PreviousBal);
                cmd.Parameters.AddWithValue("@FinalBalance", obj.FinalBalance);


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
                cmd.CommandText = "SP_PurchaseDelete";

                cmd.Parameters.AddWithValue("@PurchaseID", vID);
                new Database(connectionstring).ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }
        }
        public void DeleteRecordBody (Int64 vID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_PurchasesBodyDelete";

                cmd.Parameters.AddWithValue("@PurchaseId", vID);
                new Database(connectionstring).ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }
        }
        public DataTable getRecord(string vWhere)
        {
            string query = @"SELECT     * from Purchase Where 1=1 {0}";
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

            string vSql = "Select COALESCE(MAX(Isnull(PurchaseID,0)),0) + 1  as PurchaseID From Purchase ";


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
    }
}