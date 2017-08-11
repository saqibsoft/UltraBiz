using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class BankCheques
    {
        
        public string connectionstring;
        public void InsertRecord(Objects.BankCheques obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_BankChequesInsert";

                /**/cmd.Parameters.AddWithValue("@VoucherNo", obj.VoucherNo);
cmd.Parameters.AddWithValue("@VoucherDate", obj.VoucherDate);
cmd.Parameters.AddWithValue("@ChequeNo", obj.ChequeNo);
cmd.Parameters.AddWithValue("@ChequeDate", obj.ChequeDate);
cmd.Parameters.AddWithValue("@ReconcileDate", obj.ReconcileDate);
cmd.Parameters.AddWithValue("@BankAccountNo", obj.BankAccountNo);
cmd.Parameters.AddWithValue("@AccountNo", obj.AccountNo);
cmd.Parameters.AddWithValue("@UserNo", obj.UserNo);
cmd.Parameters.AddWithValue("@Amount", obj.Amount);
cmd.Parameters.AddWithValue("@ReceivedBy", obj.ReceivedBy);
cmd.Parameters.AddWithValue("@IsPosted", obj.IsPosted);
cmd.Parameters.AddWithValue("@Narration", obj.Narration);
cmd.Parameters.AddWithValue("@IsLost", obj.IsLost);
cmd.Parameters.AddWithValue("@PrevBal", obj.PrevBal);
cmd.Parameters.AddWithValue("@BankPrevBal", obj.BankPrevBal);
cmd.Parameters.AddWithValue("@OfficeID", obj.OfficeID);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.BankCheques obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_BankChequesUpdate";

                cmd.Parameters.AddWithValue("@VoucherNo", obj.VoucherNo);
cmd.Parameters.AddWithValue("@VoucherDate", obj.VoucherDate);
cmd.Parameters.AddWithValue("@ChequeNo", obj.ChequeNo);
cmd.Parameters.AddWithValue("@ChequeDate", obj.ChequeDate);
cmd.Parameters.AddWithValue("@ReconcileDate", obj.ReconcileDate);
cmd.Parameters.AddWithValue("@BankAccountNo", obj.BankAccountNo);
cmd.Parameters.AddWithValue("@AccountNo", obj.AccountNo);
cmd.Parameters.AddWithValue("@UserNo", obj.UserNo);
cmd.Parameters.AddWithValue("@Amount", obj.Amount);
cmd.Parameters.AddWithValue("@ReceivedBy", obj.ReceivedBy);
cmd.Parameters.AddWithValue("@IsPosted", obj.IsPosted);
cmd.Parameters.AddWithValue("@Narration", obj.Narration);
cmd.Parameters.AddWithValue("@IsLost", obj.IsLost);
cmd.Parameters.AddWithValue("@PrevBal", obj.PrevBal);
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
                cmd.CommandText = "SP_BankChequesDelete";

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
            string query = @"SELECT     * from BankCheques Where 1=1 {0}";
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

            string vSql = "Select COALESCE(MAX(Isnull(VoucherNo,0)),0) + 1  as VoucherNo From BankCheques ";


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
