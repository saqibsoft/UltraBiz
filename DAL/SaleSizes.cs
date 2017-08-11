using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;


namespace DAL
{
    public class SaleSizes
    {
        public string connectionstring;
        public void InsertRecord(Objects.SaleSizes obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_SaleSizesInsert";

                //cmd.Parameters.AddWithValue("@SerialNo", obj.SerialNo);
                cmd.Parameters.AddWithValue("@Dated", obj.Dated);
                cmd.Parameters.AddWithValue("@SaleId", obj.SaleId);
                cmd.Parameters.AddWithValue("@ProductId", obj.ProductId);
                cmd.Parameters.AddWithValue("@Size", obj.Size);
                cmd.Parameters.AddWithValue("@SizeName", obj.SizeName);
                cmd.Parameters.AddWithValue("@SizeQty", obj.SizeQty);
                cmd.Parameters.AddWithValue("@WeightKgs", obj.WeightKgs);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.SaleSizes obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_SaleSizesUpdate";

                cmd.Parameters.AddWithValue("@SerialNo", obj.SerialNo);
                cmd.Parameters.AddWithValue("@Dated", obj.Dated);
                cmd.Parameters.AddWithValue("@SaleId", obj.SaleId);
                cmd.Parameters.AddWithValue("@ProductId", obj.ProductId);
                cmd.Parameters.AddWithValue("@Size", obj.Size);
                cmd.Parameters.AddWithValue("@SizeName", obj.SizeName);
                cmd.Parameters.AddWithValue("@SizeQty", obj.SizeQty);
                cmd.Parameters.AddWithValue("@WeightKgs", obj.WeightKgs);


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
                cmd.CommandText = "SP_SaleSizesDelete";

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
            string query = @"SELECT     * from SaleSizes Where 1=1 {0}";
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

            string vSql = "Select COALESCE(MAX(Isnull(SerialNo,0)),0) + 1  as SerialNo From SaleSizes ";


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