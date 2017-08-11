using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;


namespace DAL
{
    public class CompanyDiscounts
    {
        public string connectionstring;
        public void InsertRecord(Objects.CompanyDiscounts obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_CompanyDiscountsInsert";

                /**/
                cmd.Parameters.AddWithValue("@CustomerId", obj.CustomerId);
                cmd.Parameters.AddWithValue("@CompanyID", obj.CompanyID);
                cmd.Parameters.AddWithValue("@PurDiscRatio", obj.PurDiscRatio);
                cmd.Parameters.AddWithValue("@SalDiscRatio", obj.SalDiscRatio);
                cmd.Parameters.AddWithValue("@PurDiscVal", obj.PurDiscVal);
                cmd.Parameters.AddWithValue("@SalDiscVal", obj.SalDiscVal);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.CompanyDiscounts obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_CompanyDiscountsUpdate";

                cmd.Parameters.AddWithValue("@CustomerId", obj.CustomerId);
                cmd.Parameters.AddWithValue("@CompanyID", obj.CompanyID);
                cmd.Parameters.AddWithValue("@PurDiscRatio", obj.PurDiscRatio);
                cmd.Parameters.AddWithValue("@SalDiscRatio", obj.SalDiscRatio);
                cmd.Parameters.AddWithValue("@PurDiscVal", obj.PurDiscVal);
                cmd.Parameters.AddWithValue("@SalDiscVal", obj.SalDiscVal);


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
                cmd.CommandText = "SP_CompanyDiscountsDelete";

                cmd.Parameters.AddWithValue("@CustomerId", vID);
                new Database(connectionstring).ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }
        }
        public DataTable getRecord(string vWhere)
        {
            string query = @"SELECT     * from CompanyDiscounts Where 1=1 {0}";
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

            string vSql = "Select COALESCE(MAX(Isnull(CustomerId,0)),0) + 1  as CustomerId From CompanyDiscounts ";


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