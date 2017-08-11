using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;


namespace DAL
{
    public class Salesmen
    {
        public string connectionstring;
        public void InsertRecord(Objects.Salesmen obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_SalesmenInsert";

                /**/
                cmd.Parameters.AddWithValue("@SalesmanID", obj.SalesmanID);
                cmd.Parameters.AddWithValue("@SalesmanName", obj.SalesmanName);
                cmd.Parameters.AddWithValue("@Address", obj.Address);
                cmd.Parameters.AddWithValue("@City", obj.City);
                cmd.Parameters.AddWithValue("@Phone", obj.Phone);
                cmd.Parameters.AddWithValue("@Mobile", obj.Mobile);
                cmd.Parameters.AddWithValue("@NIC", obj.NIC);
                cmd.Parameters.AddWithValue("@CommissionRatio", obj.CommissionRatio);
                cmd.Parameters.AddWithValue("@OfficeID", obj.OfficeID);
                cmd.Parameters.AddWithValue("@IsStockHolder", obj.IsStockHolder);
                cmd.Parameters.AddWithValue("@Designation", obj.Designation);
                cmd.Parameters.AddWithValue("@IsStaff", obj.IsStaff);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.Salesmen obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_SalesmenUpdate";

                cmd.Parameters.AddWithValue("@SalesmanID", obj.SalesmanID);
                cmd.Parameters.AddWithValue("@SalesmanName", obj.SalesmanName);
                cmd.Parameters.AddWithValue("@Address", obj.Address);
                cmd.Parameters.AddWithValue("@City", obj.City);
                cmd.Parameters.AddWithValue("@Phone", obj.Phone);
                cmd.Parameters.AddWithValue("@Mobile", obj.Mobile);
                cmd.Parameters.AddWithValue("@NIC", obj.NIC);
                cmd.Parameters.AddWithValue("@CommissionRatio", obj.CommissionRatio);
                cmd.Parameters.AddWithValue("@OfficeID", obj.OfficeID);
                cmd.Parameters.AddWithValue("@IsStockHolder", obj.IsStockHolder);
                cmd.Parameters.AddWithValue("@Designation", obj.Designation);
                cmd.Parameters.AddWithValue("@IsStaff", obj.IsStaff);


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
                cmd.CommandText = "SP_SalesmenDelete";

                cmd.Parameters.AddWithValue("@SalesmanID", vID);
                new Database(connectionstring).ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }
        }
        public DataTable getRecord(string vWhere)
        {
            string query = @"SELECT     * from Salesmen Where 1=1 {0}";
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

            string vSql = @"Select 
COALESCE(MAX(Convert(bigint,SUBSTRING(SalesmanID,LEN(63)+1, LEN(SalesmanID)))),0) + 1 
From Salesmen ";


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