using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;


namespace DAL
{
    public class Productions
    {
        public string connectionstring;
        public void InsertRecord(Objects.Productions obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ProductionsInsert";

                /**/
                cmd.Parameters.AddWithValue("@ProductionId", obj.ProductionId);
                cmd.Parameters.AddWithValue("@ProductionDate", obj.ProductionDate);
                cmd.Parameters.AddWithValue("@ProductId", obj.ProductId);
                cmd.Parameters.AddWithValue("@PackingId", obj.PackingId);
                cmd.Parameters.AddWithValue("@Qty", obj.Qty);
                cmd.Parameters.AddWithValue("@AvgRate", obj.AvgRate);
                cmd.Parameters.AddWithValue("@IsAutoInvoice", obj.IsAutoInvoice);
                cmd.Parameters.AddWithValue("@CustomerId", obj.CustomerId);
                cmd.Parameters.AddWithValue("@ExpPerBag", obj.ExpPerBag);
                cmd.Parameters.AddWithValue("@TotalExp", obj.TotalExp);
                cmd.Parameters.AddWithValue("@TotaAmount", obj.TotaAmount);
                cmd.Parameters.AddWithValue("@FormulaID", obj.FormulaID);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void InsertRecordBody (Objects.ProductionsBody obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ProductionsBodyInsert";

                /**/
                cmd.Parameters.AddWithValue("@SerialNo", obj.SerialNo);
                cmd.Parameters.AddWithValue("@ProductionId", obj.ProductionId);
                cmd.Parameters.AddWithValue("@ProductId", obj.ProductId);
                cmd.Parameters.AddWithValue("@PackingId", obj.PackingId);
                cmd.Parameters.AddWithValue("@Qty", obj.Qty);
                cmd.Parameters.AddWithValue("@Rate", obj.Rate);
                cmd.Parameters.AddWithValue("@CustomerId", obj.CustomerId);
                cmd.Parameters.AddWithValue("@CurrStock", obj.CurrStock);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.Productions obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ProductionsUpdate";

                cmd.Parameters.AddWithValue("@ProductionId", obj.ProductionId);
                cmd.Parameters.AddWithValue("@ProductionDate", obj.ProductionDate);
                cmd.Parameters.AddWithValue("@ProductId", obj.ProductId);
                cmd.Parameters.AddWithValue("@PackingId", obj.PackingId);
                cmd.Parameters.AddWithValue("@Qty", obj.Qty);
                cmd.Parameters.AddWithValue("@AvgRate", obj.AvgRate);
                cmd.Parameters.AddWithValue("@IsAutoInvoice", obj.IsAutoInvoice);
                cmd.Parameters.AddWithValue("@CustomerId", obj.CustomerId);
                cmd.Parameters.AddWithValue("@ExpPerBag", obj.ExpPerBag);
                cmd.Parameters.AddWithValue("@TotalExp", obj.TotalExp);
                cmd.Parameters.AddWithValue("@TotaAmount", obj.TotaAmount);
                cmd.Parameters.AddWithValue("@FormulaID", obj.FormulaID);


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
                cmd.CommandText = "SP_ProductionsDelete";

                cmd.Parameters.AddWithValue("@ProductionId", vID);
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
                cmd.CommandText = "SP_ProductionsBodyDelete";

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
            string query = @"SELECT     * from Productions Where 1=1 {0}";
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

            string vSql = "Select COALESCE(MAX(Isnull(ProductionId,0)),0) + 1  as ProductionId From Productions ";


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