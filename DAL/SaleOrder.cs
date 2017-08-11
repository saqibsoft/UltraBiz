using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;


namespace DAL
{
    public class SaleOrder
    {
        public string connectionstring;
        public void InsertRecord(Objects.SaleOrder obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_SaleOrderInsert";

                /**/
                cmd.Parameters.AddWithValue("@OrderId", obj.OrderId);
                cmd.Parameters.AddWithValue("@OrderDate", obj.OrderDate);
                cmd.Parameters.AddWithValue("@BillNo", obj.BillNo);
                cmd.Parameters.AddWithValue("@CustomerId", obj.CustomerId);
                cmd.Parameters.AddWithValue("@SectorID", obj.SectorID);
                cmd.Parameters.AddWithValue("@SalesmanId", obj.SalesmanId);
                cmd.Parameters.AddWithValue("@IsStockist", obj.IsStockist);
                cmd.Parameters.AddWithValue("@OldIsStockist", obj.OldIsStockist);
                cmd.Parameters.AddWithValue("@Narration", obj.Narration);
                cmd.Parameters.AddWithValue("@Disc2Ratio", obj.Disc2Ratio);
                cmd.Parameters.AddWithValue("@FTaxRatio", obj.FTaxRatio);
                cmd.Parameters.AddWithValue("@SpecialDiscount", obj.SpecialDiscount);
                cmd.Parameters.AddWithValue("@InvOfferDiscount", obj.InvOfferDiscount);
                cmd.Parameters.AddWithValue("@InvOfferSTax", obj.InvOfferSTax);
                cmd.Parameters.AddWithValue("@InvOfferFTax", obj.InvOfferFTax);
                cmd.Parameters.AddWithValue("@ReceivedAmount", obj.ReceivedAmount);
                cmd.Parameters.AddWithValue("@PreviousCredit", obj.PreviousCredit);
                cmd.Parameters.AddWithValue("@InvoiceNotes", obj.InvoiceNotes);
                cmd.Parameters.AddWithValue("@IsPosted", obj.IsPosted);
                cmd.Parameters.AddWithValue("@UserNo", obj.UserNo);
                cmd.Parameters.AddWithValue("@BiltyNo", obj.BiltyNo);
                cmd.Parameters.AddWithValue("@TransportName", obj.TransportName);
                cmd.Parameters.AddWithValue("@OfferID", obj.OfferID);
                cmd.Parameters.AddWithValue("@BookerID", obj.BookerID);
                cmd.Parameters.AddWithValue("@DeliveryDate", obj.DeliveryDate);
                cmd.Parameters.AddWithValue("@OfficeID", obj.OfficeID);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void InsertRecordBody (Objects.SaleOrderBody obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_SaleOrderBodyInsert";

                /**/
                cmd.Parameters.AddWithValue("@OrderId", obj.OrderId);
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
                cmd.Parameters.AddWithValue("@PriceHistoryId", obj.PriceHistoryId);
                cmd.Parameters.AddWithValue("@OfferDiscount", obj.OfferDiscount);
                cmd.Parameters.AddWithValue("@IsDeleted", obj.IsDeleted);
                cmd.Parameters.AddWithValue("@OfferID", obj.OfferID);
                cmd.Parameters.AddWithValue("@IsOffered", obj.IsOffered);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.SaleOrder obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_SaleOrderUpdate";

                cmd.Parameters.AddWithValue("@OrderId", obj.OrderId);
                cmd.Parameters.AddWithValue("@OrderDate", obj.OrderDate);
                cmd.Parameters.AddWithValue("@BillNo", obj.BillNo);
                cmd.Parameters.AddWithValue("@CustomerId", obj.CustomerId);
                cmd.Parameters.AddWithValue("@SectorID", obj.SectorID);
                cmd.Parameters.AddWithValue("@SalesmanId", obj.SalesmanId);
                cmd.Parameters.AddWithValue("@IsStockist", obj.IsStockist);
                cmd.Parameters.AddWithValue("@OldIsStockist", obj.OldIsStockist);
                cmd.Parameters.AddWithValue("@Narration", obj.Narration);
                cmd.Parameters.AddWithValue("@Disc2Ratio", obj.Disc2Ratio);
                cmd.Parameters.AddWithValue("@FTaxRatio", obj.FTaxRatio);
                cmd.Parameters.AddWithValue("@SpecialDiscount", obj.SpecialDiscount);
                cmd.Parameters.AddWithValue("@InvOfferDiscount", obj.InvOfferDiscount);
                cmd.Parameters.AddWithValue("@InvOfferSTax", obj.InvOfferSTax);
                cmd.Parameters.AddWithValue("@InvOfferFTax", obj.InvOfferFTax);
                cmd.Parameters.AddWithValue("@ReceivedAmount", obj.ReceivedAmount);
                cmd.Parameters.AddWithValue("@PreviousCredit", obj.PreviousCredit);
                cmd.Parameters.AddWithValue("@InvoiceNotes", obj.InvoiceNotes);
                cmd.Parameters.AddWithValue("@IsPosted", obj.IsPosted);
                cmd.Parameters.AddWithValue("@UserNo", obj.UserNo);
                cmd.Parameters.AddWithValue("@BiltyNo", obj.BiltyNo);
                cmd.Parameters.AddWithValue("@TransportName", obj.TransportName);
                cmd.Parameters.AddWithValue("@OfferID", obj.OfferID);
                cmd.Parameters.AddWithValue("@BookerID", obj.BookerID);
                cmd.Parameters.AddWithValue("@DeliveryDate", obj.DeliveryDate);
                cmd.Parameters.AddWithValue("@OfficeID", obj.OfficeID);


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
                cmd.CommandText = "SP_SaleOrderDelete";

                cmd.Parameters.AddWithValue("@OrderId", vID);
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
                cmd.CommandText = "SP_SaleOrderBodyDelete";

                cmd.Parameters.AddWithValue("@OrderId", vID);
                new Database(connectionstring).ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }
        }
        public DataTable getRecord(string vWhere)
        {
            string query = @"SELECT     * from SaleOrder Where 1=1 {0}";
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

            string vSql = "Select COALESCE(MAX(Isnull(OrderId,0)),0) + 1  as OrderId From SaleOrder ";


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