using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;


namespace DAL
{
    public class CreditVouchers
    {
        public string connectionstring;
        public void InsertRecord(Objects.CreditVouchers obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_CreditVouchersInsert";

                /**/
                cmd.Parameters.AddWithValue("@VoucherNo", obj.VoucherNo);
                cmd.Parameters.AddWithValue("@VoucherDate", obj.VoucherDate);
                cmd.Parameters.AddWithValue("@LastUpdateDate", obj.LastUpdateDate);
                cmd.Parameters.AddWithValue("@UserNo", obj.UserNo);
                cmd.Parameters.AddWithValue("@OfficeID", obj.OfficeID);
                cmd.Parameters.AddWithValue("@IsUploaded", obj.IsUploaded);
                cmd.Parameters.AddWithValue("@IsPosted", obj.IsPosted);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.CreditVouchers obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_CreditVouchersUpdate";

                cmd.Parameters.AddWithValue("@VoucherNo", obj.VoucherNo);
                cmd.Parameters.AddWithValue("@VoucherDate", obj.VoucherDate);
                cmd.Parameters.AddWithValue("@LastUpdateDate", obj.LastUpdateDate);
                cmd.Parameters.AddWithValue("@UserNo", obj.UserNo);
                cmd.Parameters.AddWithValue("@OfficeID", obj.OfficeID);
                cmd.Parameters.AddWithValue("@IsUploaded", obj.IsUploaded);
                cmd.Parameters.AddWithValue("@IsPosted", obj.IsPosted);


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
                cmd.CommandText = "SP_CreditVouchersDelete";

                cmd.Parameters.AddWithValue("@VoucherNo", vID);
                new Database(connectionstring).ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }
        }
        public DataTable getRecord(string vWhere)
        {
            string query = @"SELECT     * from CreditVouchers Where 1=1 {0}";
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

            string vSql = "Select COALESCE(MAX(Isnull(VoucherNo,0)),0) + 1  as VoucherNo From CreditVouchers ";


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