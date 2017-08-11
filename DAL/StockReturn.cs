using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;


namespace DAL
{
    public class StockReturn
    {
        public string connectionstring;
        public void InsertRecord(Objects.StockReturn obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_StockReturnInsert";

                /**/
                cmd.Parameters.AddWithValue("@ReturnId", obj.ReturnId);
                cmd.Parameters.AddWithValue("@Returndate", obj.Returndate);
                cmd.Parameters.AddWithValue("@SalesmanID", obj.SalesmanID);
                cmd.Parameters.AddWithValue("@IsUploaded", obj.IsUploaded);
                cmd.Parameters.AddWithValue("@OfficeID", obj.OfficeID);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void InsertRecordBody (Objects.StockReturnBody obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_StockReturnBodyInsert";

                /**/
                cmd.Parameters.AddWithValue("@ReturnID", obj.ReturnID);
                cmd.Parameters.AddWithValue("@ProductID", obj.ProductID);
                cmd.Parameters.AddWithValue("@PackingId", obj.PackingId);
                cmd.Parameters.AddWithValue("@Multiplier", obj.Multiplier);
                cmd.Parameters.AddWithValue("@QtyPack", obj.QtyPack);
                cmd.Parameters.AddWithValue("@QtyLose", obj.QtyLose);
                cmd.Parameters.AddWithValue("@TTLValue", obj.TTLValue);
                cmd.Parameters.AddWithValue("@PerUnitCostLose", obj.PerUnitCostLose);
                cmd.Parameters.AddWithValue("@DamageQty", obj.DamageQty);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.StockReturn obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_StockReturnUpdate";

                cmd.Parameters.AddWithValue("@ReturnId", obj.ReturnId);
                cmd.Parameters.AddWithValue("@Returndate", obj.Returndate);
                cmd.Parameters.AddWithValue("@SalesmanID", obj.SalesmanID);
                cmd.Parameters.AddWithValue("@IsUploaded", obj.IsUploaded);
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
                cmd.CommandText = "SP_StockReturnDelete";

                cmd.Parameters.AddWithValue("@ReturnId", vID);
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
                cmd.CommandText = "SP_StockReturnBodyDelete";

                cmd.Parameters.AddWithValue("@ReturnID", vID);
                new Database(connectionstring).ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }
        }
        public DataTable getRecord(string vWhere)
        {
            string query = @"SELECT     * from StockReturn Where 1=1 {0}";
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

            string vSql = "Select COALESCE(MAX(Isnull(ReturnId,0)),0) + 1  as ReturnId From StockReturn ";


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