using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;


namespace DAL
{
    public class Promises
    {
        public string connectionstring;
        public void InsertRecord(Objects.Promises obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_PromisesInsert";

                /**/
                cmd.Parameters.AddWithValue("@PromiseNo", obj.PromiseNo);
                cmd.Parameters.AddWithValue("@IsPayment", obj.IsPayment);
                cmd.Parameters.AddWithValue("@IsFullFilled", obj.IsFullFilled);
                cmd.Parameters.AddWithValue("@CurrentDate", obj.CurrentDate);
                cmd.Parameters.AddWithValue("@PromiseDate", obj.PromiseDate);
                cmd.Parameters.AddWithValue("@Narration", obj.Narration);
                cmd.Parameters.AddWithValue("@Amount", obj.Amount);
                cmd.Parameters.AddWithValue("@PartyNo", obj.PartyNo);
                cmd.Parameters.AddWithValue("@UserNo", obj.UserNo);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.Promises obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_PromisesUpdate";

                cmd.Parameters.AddWithValue("@PromiseNo", obj.PromiseNo);
                cmd.Parameters.AddWithValue("@IsPayment", obj.IsPayment);
                cmd.Parameters.AddWithValue("@IsFullFilled", obj.IsFullFilled);
                cmd.Parameters.AddWithValue("@CurrentDate", obj.CurrentDate);
                cmd.Parameters.AddWithValue("@PromiseDate", obj.PromiseDate);
                cmd.Parameters.AddWithValue("@Narration", obj.Narration);
                cmd.Parameters.AddWithValue("@Amount", obj.Amount);
                cmd.Parameters.AddWithValue("@PartyNo", obj.PartyNo);
                cmd.Parameters.AddWithValue("@UserNo", obj.UserNo);


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
                cmd.CommandText = "SP_PromisesDelete";

                cmd.Parameters.AddWithValue("@PromiseNo", vID);
                new Database(connectionstring).ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }
        }
        public DataTable getRecord(string vWhere)
        {
            string query = @"SELECT     * from Promises Where 1=1 {0}";
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

            string vSql = "Select COALESCE(MAX(Isnull(PromiseNo,0)),0) + 1  as PromiseNo From Promises ";


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