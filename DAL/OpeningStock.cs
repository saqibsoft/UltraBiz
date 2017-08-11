using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;


namespace DAL
{
    public class OpeningStock
    {
        public string connectionstring;
        public void InsertRecord(Objects.OpeningStock obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_OpeningStockInsert";

                /**/
                cmd.Parameters.AddWithValue("@SerialNo", obj.SerialNo);
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
                cmd.Parameters.AddWithValue("@OfferDiscount", obj.OfferDiscount);
                cmd.Parameters.AddWithValue("@IsSTaxOnBns", obj.IsSTaxOnBns);
                cmd.Parameters.AddWithValue("@IsFTaxExempted", obj.IsFTaxExempted);
                cmd.Parameters.AddWithValue("@TTLValue", obj.TTLValue);
                cmd.Parameters.AddWithValue("@TTLSTax", obj.TTLSTax);
                cmd.Parameters.AddWithValue("@TTLFTax", obj.TTLFTax);
                cmd.Parameters.AddWithValue("@ExtraSTaxBns", obj.ExtraSTaxBns);
                cmd.Parameters.AddWithValue("@ExtraFTaxBns", obj.ExtraFTaxBns);
                cmd.Parameters.AddWithValue("@IsDeleted", obj.IsDeleted);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.OpeningStock obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_OpeningStockUpdate";

                cmd.Parameters.AddWithValue("@SerialNo", obj.SerialNo);
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
                cmd.Parameters.AddWithValue("@OfferDiscount", obj.OfferDiscount);
                cmd.Parameters.AddWithValue("@IsSTaxOnBns", obj.IsSTaxOnBns);
                cmd.Parameters.AddWithValue("@IsFTaxExempted", obj.IsFTaxExempted);
                cmd.Parameters.AddWithValue("@TTLValue", obj.TTLValue);
                cmd.Parameters.AddWithValue("@TTLSTax", obj.TTLSTax);
                cmd.Parameters.AddWithValue("@TTLFTax", obj.TTLFTax);
                cmd.Parameters.AddWithValue("@ExtraSTaxBns", obj.ExtraSTaxBns);
                cmd.Parameters.AddWithValue("@ExtraFTaxBns", obj.ExtraFTaxBns);
                cmd.Parameters.AddWithValue("@IsDeleted", obj.IsDeleted);


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
                cmd.CommandText = "SP_OpeningStockDelete";

                cmd.Parameters.AddWithValue("@SerialNo", vID);
                new Database(connectionstring).ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }
        }
        public DataTable getRecord(string vWhere)
        {
            string query = @"SELECT     * from OpeningStock Where 1=1 {0}";
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

            string vSql = "Select COALESCE(MAX(Isnull(SerialNo,0)),0) + 1  as SerialNo From OpeningStock ";


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