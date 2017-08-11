using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;


namespace DAL
{
    public class Sales
    {
        public string connectionstring;
        public void InsertRecord(Objects.Sales obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_SalesInsert";

                //cmd.Parameters.AddWithValue("@SaleId", obj.SaleId);
                cmd.Parameters.AddWithValue("@SaleDate", obj.SaleDate);
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
                cmd.Parameters.AddWithValue("@OrderId", obj.OrderId);
                cmd.Parameters.AddWithValue("@ServiceChargesRatio", obj.ServiceChargesRatio);
                cmd.Parameters.AddWithValue("@GstRatio", obj.GstRatio);
                cmd.Parameters.AddWithValue("@CustomerName", obj.CustomerName);
                cmd.Parameters.AddWithValue("@IsRP", obj.IsRP);
                cmd.Parameters.AddWithValue("@TotalReceivedCash", obj.TotalReceivedCash);
                cmd.Parameters.AddWithValue("@CustomerMobile", obj.CustomerMobile);
                cmd.Parameters.AddWithValue("@OfferID", obj.OfferID);
                cmd.Parameters.AddWithValue("@BookerID", obj.BookerID);
                cmd.Parameters.AddWithValue("@Freight2", obj.Freight2);
                cmd.Parameters.AddWithValue("@Unloading2", obj.Unloading2);
                cmd.Parameters.AddWithValue("@ITax2", obj.ITax2);
                cmd.Parameters.AddWithValue("@DueDate", obj.DueDate);
                cmd.Parameters.AddWithValue("@InvType", obj.InvType);
                cmd.Parameters.AddWithValue("@SaleIdNew", obj.SaleIdNew);
                cmd.Parameters.AddWithValue("@VehicleACNo", obj.VehicleACNo);
                cmd.Parameters.AddWithValue("@VehicleACName", obj.VehicleACName);
                cmd.Parameters.AddWithValue("@VehicleFreightExp", obj.VehicleFreightExp);
                cmd.Parameters.AddWithValue("@SalTaxPerc", obj.SalTaxPerc);
                cmd.Parameters.AddWithValue("@SalTaxVal", obj.SalTaxVal);
                cmd.Parameters.AddWithValue("@CurrentReading", obj.CurrentReading);
                cmd.Parameters.AddWithValue("@isOilTuning", obj.isOilTuning);
                cmd.Parameters.AddWithValue("@OilChangeDate", obj.OilChangeDate);
                cmd.Parameters.AddWithValue("@SendSMSTunning", obj.SendSMSTunning);
                cmd.Parameters.AddWithValue("@SendSMSOilChange", obj.SendSMSOilChange);
                cmd.Parameters.AddWithValue("@OfficeID", obj.OfficeID);
                cmd.Parameters.AddWithValue("@TownID", obj.TownID);
                cmd.Parameters.AddWithValue("@VehicleNo", obj.VehicleNo);
                cmd.Parameters.AddWithValue("@CustPhoneNo", obj.CustPhoneNo);
                cmd.Parameters.AddWithValue("@SaleTime", obj.SaleTime);
                cmd.Parameters.AddWithValue("@IsPrinted", obj.IsPrinted);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void InsertRecordBody (Objects.SalesBody obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_SalesBodyInsert";

                //cmd.Parameters.AddWithValue("@SaleId", obj.SaleId);
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
                cmd.Parameters.AddWithValue("@Toping", obj.Toping);
                cmd.Parameters.AddWithValue("@TopingValue", obj.TopingValue);
                cmd.Parameters.AddWithValue("@CustomerId", obj.CustomerId);
                cmd.Parameters.AddWithValue("@Size", obj.Size);
                cmd.Parameters.AddWithValue("@SizeName", obj.SizeName);
                cmd.Parameters.AddWithValue("@SizeQty", obj.SizeQty);
                cmd.Parameters.AddWithValue("@OfferID", obj.OfferID);
                cmd.Parameters.AddWithValue("@IsOffered", obj.IsOffered);
                cmd.Parameters.AddWithValue("@PHeight", obj.PHeight);
                cmd.Parameters.AddWithValue("@PWidth", obj.PWidth);
                cmd.Parameters.AddWithValue("@LastSalePrice", obj.LastSalePrice);
                cmd.Parameters.AddWithValue("@SerialNo", obj.SerialNo);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.Sales obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_SalesUpdate";

                cmd.Parameters.AddWithValue("@SaleId", obj.SaleId);
                cmd.Parameters.AddWithValue("@SaleDate", obj.SaleDate);
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
                cmd.Parameters.AddWithValue("@OrderId", obj.OrderId);
                cmd.Parameters.AddWithValue("@ServiceChargesRatio", obj.ServiceChargesRatio);
                cmd.Parameters.AddWithValue("@GstRatio", obj.GstRatio);
                cmd.Parameters.AddWithValue("@CustomerName", obj.CustomerName);
                cmd.Parameters.AddWithValue("@IsRP", obj.IsRP);
                cmd.Parameters.AddWithValue("@TotalReceivedCash", obj.TotalReceivedCash);
                cmd.Parameters.AddWithValue("@CustomerMobile", obj.CustomerMobile);
                cmd.Parameters.AddWithValue("@OfferID", obj.OfferID);
                cmd.Parameters.AddWithValue("@BookerID", obj.BookerID);
                cmd.Parameters.AddWithValue("@Freight2", obj.Freight2);
                cmd.Parameters.AddWithValue("@Unloading2", obj.Unloading2);
                cmd.Parameters.AddWithValue("@ITax2", obj.ITax2);
                cmd.Parameters.AddWithValue("@DueDate", obj.DueDate);
                cmd.Parameters.AddWithValue("@InvType", obj.InvType);
                cmd.Parameters.AddWithValue("@SaleIdNew", obj.SaleIdNew);
                cmd.Parameters.AddWithValue("@VehicleACNo", obj.VehicleACNo);
                cmd.Parameters.AddWithValue("@VehicleACName", obj.VehicleACName);
                cmd.Parameters.AddWithValue("@VehicleFreightExp", obj.VehicleFreightExp);
                cmd.Parameters.AddWithValue("@SalTaxPerc", obj.SalTaxPerc);
                cmd.Parameters.AddWithValue("@SalTaxVal", obj.SalTaxVal);
                cmd.Parameters.AddWithValue("@CurrentReading", obj.CurrentReading);
                cmd.Parameters.AddWithValue("@isOilTuning", obj.isOilTuning);
                cmd.Parameters.AddWithValue("@OilChangeDate", obj.OilChangeDate);
                cmd.Parameters.AddWithValue("@SendSMSTunning", obj.SendSMSTunning);
                cmd.Parameters.AddWithValue("@SendSMSOilChange", obj.SendSMSOilChange);
                cmd.Parameters.AddWithValue("@OfficeID", obj.OfficeID);
                cmd.Parameters.AddWithValue("@TownID", obj.TownID);
                cmd.Parameters.AddWithValue("@VehicleNo", obj.VehicleNo);
                cmd.Parameters.AddWithValue("@CustPhoneNo", obj.CustPhoneNo);
                cmd.Parameters.AddWithValue("@SaleTime", obj.SaleTime);
                cmd.Parameters.AddWithValue("@IsPrinted", obj.IsPrinted);


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
                cmd.CommandText = "SP_SalesDelete";

                cmd.Parameters.AddWithValue("@SaleId", vID);
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
                cmd.CommandText = "SP_SalesBodyDelete";

                cmd.Parameters.AddWithValue("@SaleId", vID);
                new Database(connectionstring).ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }
        }
        public DataTable getRecord(string vWhere)
        {
            string query = @"SELECT     * from Sales Where 1=1 {0}";
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

            string vSql = "Select COALESCE(MAX(Isnull(SaleId,0)),0) + 1  as SaleId From Sales ";


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