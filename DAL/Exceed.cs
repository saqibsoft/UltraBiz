using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;


namespace DAL
{
    public class Exceed
    {
        public string connectionstring;
        public void InsertRecord(Objects.Exceed obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ExceedInsert";

                //cmd.Parameters.AddWithValue("@InvoiceId", obj.InvoiceId);
                cmd.Parameters.AddWithValue("@InvoiceDate", obj.InvoiceDate);
                cmd.Parameters.AddWithValue("@Narration", obj.Narration);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void InsertRecordBody(Objects.ExceedBody obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ExceedBodyInsert";

                //cmd.Parameters.AddWithValue("@SerialNo", obj.SerialNo);
                cmd.Parameters.AddWithValue("@InvoiceId", obj.InvoiceId);
                cmd.Parameters.AddWithValue("@ProductId", obj.ProductId);
                cmd.Parameters.AddWithValue("@PackingId", obj.PackingId);
                cmd.Parameters.AddWithValue("@Qty", obj.Qty);
                cmd.Parameters.AddWithValue("@Rate", obj.Rate);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.Exceed obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ExceedUpdate";

                cmd.Parameters.AddWithValue("@InvoiceId", obj.InvoiceId);
                cmd.Parameters.AddWithValue("@InvoiceDate", obj.InvoiceDate);
                cmd.Parameters.AddWithValue("@Narration", obj.Narration);


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
                cmd.CommandText = "SP_ExceedDelete";

                cmd.Parameters.AddWithValue("@InvoiceId", vID);
                new Database(connectionstring).ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }
        }
        public void DeleteRecordBody(Int64 vID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ExceedBodyDelete";

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
            string query = @"SELECT     * from Exceed Where 1=1 {0}";
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

            string vSql = "Select COALESCE(MAX(Isnull(InvoiceId,0)),0) + 1  as InvoiceId From Exceed ";


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