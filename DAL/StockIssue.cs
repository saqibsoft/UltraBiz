using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;


namespace DAL
{
    public class StockIssue
    {
        public string connectionstring;
        public void InsertRecord(Objects.StockIssue obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_StockIssueInsert";

                /**/
                cmd.Parameters.AddWithValue("@IssueID", obj.IssueID);
                cmd.Parameters.AddWithValue("@IssueDate", obj.IssueDate);
                cmd.Parameters.AddWithValue("@SalesmanID", obj.SalesmanID);
                cmd.Parameters.AddWithValue("@IsUploaded", obj.IsUploaded);
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
        public void InsertRecordBody (Objects.StockIssueBody obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_StockIssueBodyInsert";

                /**/
                cmd.Parameters.AddWithValue("@IssueID", obj.IssueID);
                cmd.Parameters.AddWithValue("@ProductID", obj.ProductID);
                cmd.Parameters.AddWithValue("@PackingId", obj.PackingId);
                cmd.Parameters.AddWithValue("@Multiplier", obj.Multiplier);
                cmd.Parameters.AddWithValue("@QtyPack", obj.QtyPack);
                cmd.Parameters.AddWithValue("@QtyLose", obj.QtyLose);
                cmd.Parameters.AddWithValue("@PerUnitCostLose", obj.PerUnitCostLose);
                cmd.Parameters.AddWithValue("@TTLValue", obj.TTLValue);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.StockIssue obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_StockIssueUpdate";

                cmd.Parameters.AddWithValue("@IssueID", obj.IssueID);
                cmd.Parameters.AddWithValue("@IssueDate", obj.IssueDate);
                cmd.Parameters.AddWithValue("@SalesmanID", obj.SalesmanID);
                cmd.Parameters.AddWithValue("@IsUploaded", obj.IsUploaded);
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
                cmd.CommandText = "SP_StockIssueDelete";

                cmd.Parameters.AddWithValue("@IssueID", vID);
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
                cmd.CommandText = "SP_StockIssueBodyDelete";

                cmd.Parameters.AddWithValue("@IssueID", vID);
                new Database(connectionstring).ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }
        }
        public DataTable getRecord(string vWhere)
        {
            string query = @"SELECT     * from StockIssue Where 1=1 {0}";
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

            string vSql = "Select COALESCE(MAX(Isnull(IssueID,0)),0) + 1  as IssueID From StockIssue ";


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