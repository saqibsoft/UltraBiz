using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;


namespace DAL
{
    public class ChartOfAccounts
    {
        public string connectionstring;
        public void InsertRecord(Objects.ChartOfAccounts obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ChartOfAccountsInsert";

                /**/
                cmd.Parameters.AddWithValue("@AccountNo", obj.AccountNo);
                cmd.Parameters.AddWithValue("@UserNo", obj.UserNo);
                cmd.Parameters.AddWithValue("@AccountName", obj.AccountName);
                cmd.Parameters.AddWithValue("@AccountType", obj.AccountType);
                cmd.Parameters.AddWithValue("@AccountDepth", obj.AccountDepth);
                cmd.Parameters.AddWithValue("@Narration", obj.Narration);
                cmd.Parameters.AddWithValue("@ParentAccountNo", obj.ParentAccountNo);
                cmd.Parameters.AddWithValue("@OpeningDebit", obj.OpeningDebit);
                cmd.Parameters.AddWithValue("@OpeningCredit", obj.OpeningCredit);
                cmd.Parameters.AddWithValue("@AdjustedDebit", obj.AdjustedDebit);
                cmd.Parameters.AddWithValue("@AdjustedCredit", obj.AdjustedCredit);
                cmd.Parameters.AddWithValue("@IsDetailed", obj.IsDetailed);
                cmd.Parameters.AddWithValue("@IsLocked", obj.IsLocked);
                cmd.Parameters.AddWithValue("@IsPosted", obj.IsPosted);
                cmd.Parameters.AddWithValue("@IsEditable", obj.IsEditable);
                cmd.Parameters.AddWithValue("@BalFlag", obj.BalFlag);
                cmd.Parameters.AddWithValue("@PLFlag", obj.PLFlag);
                cmd.Parameters.AddWithValue("@ExpFlag", obj.ExpFlag);
                cmd.Parameters.AddWithValue("@EntryDate", obj.EntryDate);
                cmd.Parameters.AddWithValue("@Life", obj.Life);
                cmd.Parameters.AddWithValue("@ResidualValue", obj.ResidualValue);
                cmd.Parameters.AddWithValue("@AccountNameUrdu", obj.AccountNameUrdu);
                cmd.Parameters.AddWithValue("@IsSold", obj.IsSold);
                cmd.Parameters.AddWithValue("@InActive", obj.InActive);
                cmd.Parameters.AddWithValue("@OfficeID", obj.OfficeID);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.ChartOfAccounts obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ChartOfAccountsUpdate";

                cmd.Parameters.AddWithValue("@AccountNo", obj.AccountNo);
                cmd.Parameters.AddWithValue("@UserNo", obj.UserNo);
                cmd.Parameters.AddWithValue("@AccountName", obj.AccountName);
                cmd.Parameters.AddWithValue("@AccountType", obj.AccountType);
                cmd.Parameters.AddWithValue("@AccountDepth", obj.AccountDepth);
                cmd.Parameters.AddWithValue("@Narration", obj.Narration);
                cmd.Parameters.AddWithValue("@ParentAccountNo", obj.ParentAccountNo);
                cmd.Parameters.AddWithValue("@OpeningDebit", obj.OpeningDebit);
                cmd.Parameters.AddWithValue("@OpeningCredit", obj.OpeningCredit);
                cmd.Parameters.AddWithValue("@AdjustedDebit", obj.AdjustedDebit);
                cmd.Parameters.AddWithValue("@AdjustedCredit", obj.AdjustedCredit);
                cmd.Parameters.AddWithValue("@IsDetailed", obj.IsDetailed);
                cmd.Parameters.AddWithValue("@IsLocked", obj.IsLocked);
                cmd.Parameters.AddWithValue("@IsPosted", obj.IsPosted);
                cmd.Parameters.AddWithValue("@IsEditable", obj.IsEditable);
                cmd.Parameters.AddWithValue("@BalFlag", obj.BalFlag);
                cmd.Parameters.AddWithValue("@PLFlag", obj.PLFlag);
                cmd.Parameters.AddWithValue("@ExpFlag", obj.ExpFlag);
                cmd.Parameters.AddWithValue("@EntryDate", obj.EntryDate);
                cmd.Parameters.AddWithValue("@Life", obj.Life);
                cmd.Parameters.AddWithValue("@ResidualValue", obj.ResidualValue);
                cmd.Parameters.AddWithValue("@AccountNameUrdu", obj.AccountNameUrdu);
                cmd.Parameters.AddWithValue("@IsSold", obj.IsSold);
                cmd.Parameters.AddWithValue("@InActive", obj.InActive);
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
                cmd.CommandText = "SP_ChartOfAccountsDelete";

                cmd.Parameters.AddWithValue("@AccountNo", vID);
                new Database(connectionstring).ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }
        }
        public DataTable getRecord(string vWhere)
        {
            string query = @"SELECT     * from ChartOfAccounts Where 1=1 {0}";
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

            string vSql = "Select COALESCE(MAX(Isnull(AccountNo,0)),0) + 1  as AccountNo From ChartOfAccounts ";


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