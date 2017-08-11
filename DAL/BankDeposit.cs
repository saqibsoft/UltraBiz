using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;


namespace DAL
{
    public class BankDeposit
    {
        public string connectionstring;
        public void InsertRecord(Objects.BankDeposit obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_BankDepositInsert";

                /**/
                cmd.Parameters.AddWithValue("@VoucherNo", obj.VoucherNo);
                cmd.Parameters.AddWithValue("@VoucherDate", obj.VoucherDate);
                cmd.Parameters.AddWithValue("@IsCheque", obj.IsCheque);
                cmd.Parameters.AddWithValue("@ChequeNo", obj.ChequeNo);
                cmd.Parameters.AddWithValue("@ChequeDate", obj.ChequeDate);
                cmd.Parameters.AddWithValue("@SlipNo", obj.SlipNo);
                cmd.Parameters.AddWithValue("@DepositedDate", obj.DepositedDate);
                cmd.Parameters.AddWithValue("@ReconcileDate", obj.ReconcileDate);
                cmd.Parameters.AddWithValue("@BankAccountNo", obj.BankAccountNo);
                cmd.Parameters.AddWithValue("@AccountNo", obj.AccountNo);
                cmd.Parameters.AddWithValue("@UserNo", obj.UserNo);
                cmd.Parameters.AddWithValue("@Amount", obj.Amount);
                cmd.Parameters.AddWithValue("@DepositedBy", obj.DepositedBy);
                cmd.Parameters.AddWithValue("@IsPosted", obj.IsPosted);
                cmd.Parameters.AddWithValue("@Narration", obj.Narration);
                cmd.Parameters.AddWithValue("@IsBounced", obj.IsBounced);
                cmd.Parameters.AddWithValue("@BankPrevBal", obj.BankPrevBal);
                cmd.Parameters.AddWithValue("@OfficeID", obj.OfficeID);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.BankDeposit obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_BankDepositUpdate";

                cmd.Parameters.AddWithValue("@VoucherNo", obj.VoucherNo);
                cmd.Parameters.AddWithValue("@VoucherDate", obj.VoucherDate);
                cmd.Parameters.AddWithValue("@IsCheque", obj.IsCheque);
                cmd.Parameters.AddWithValue("@ChequeNo", obj.ChequeNo);
                cmd.Parameters.AddWithValue("@ChequeDate", obj.ChequeDate);
                cmd.Parameters.AddWithValue("@SlipNo", obj.SlipNo);
                cmd.Parameters.AddWithValue("@DepositedDate", obj.DepositedDate);
                cmd.Parameters.AddWithValue("@ReconcileDate", obj.ReconcileDate);
                cmd.Parameters.AddWithValue("@BankAccountNo", obj.BankAccountNo);
                cmd.Parameters.AddWithValue("@AccountNo", obj.AccountNo);
                cmd.Parameters.AddWithValue("@UserNo", obj.UserNo);
                cmd.Parameters.AddWithValue("@Amount", obj.Amount);
                cmd.Parameters.AddWithValue("@DepositedBy", obj.DepositedBy);
                cmd.Parameters.AddWithValue("@IsPosted", obj.IsPosted);
                cmd.Parameters.AddWithValue("@Narration", obj.Narration);
                cmd.Parameters.AddWithValue("@IsBounced", obj.IsBounced);
                cmd.Parameters.AddWithValue("@BankPrevBal", obj.BankPrevBal);
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
                cmd.CommandText = "SP_BankDepositDelete";

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
            string query = @"SELECT     * from BankDeposit Where 1=1 {0}";
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

            string vSql = "Select COALESCE(MAX(Isnull(VoucherNo,0)),0) + 1  as VoucherNo From BankDeposit ";


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