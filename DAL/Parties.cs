using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;


namespace DAL
{
    public class Parties
    {
        public string connectionstring;
        public void InsertRecord(Objects.Parties obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_PartiesInsert";

                /**/
                cmd.Parameters.AddWithValue("@PartyID", obj.PartyID);
                cmd.Parameters.AddWithValue("@PartyName", obj.PartyName);
                cmd.Parameters.AddWithValue("@SectorID", obj.SectorID);// pichy sy es object ko sectorid pas krain then save krain 


                cmd.Parameters.AddWithValue("@Address", obj.Address);
                cmd.Parameters.AddWithValue("@City", obj.City);
                cmd.Parameters.AddWithValue("@Phone1", obj.Phone1);
                cmd.Parameters.AddWithValue("@Phone2", obj.Phone2);
                cmd.Parameters.AddWithValue("@Mobile", obj.Mobile);
                cmd.Parameters.AddWithValue("@Fax", obj.Fax);
                cmd.Parameters.AddWithValue("@EMail", obj.EMail);
                cmd.Parameters.AddWithValue("@ContactPerson", obj.ContactPerson);
                cmd.Parameters.AddWithValue("@PartyType", obj.PartyType);
                cmd.Parameters.AddWithValue("@DiscRatio", obj.DiscRatio);
                cmd.Parameters.AddWithValue("@ReceivablesFlag", obj.ReceivablesFlag);
                cmd.Parameters.AddWithValue("@PayablesFlag", obj.PayablesFlag);
                cmd.Parameters.AddWithValue("@GroupID", obj.GroupID);
                cmd.Parameters.AddWithValue("@DueDays", obj.DueDays);
                cmd.Parameters.AddWithValue("@DebitLimit", obj.DebitLimit);
                cmd.Parameters.AddWithValue("@CreditLimit", obj.CreditLimit);
                cmd.Parameters.AddWithValue("@Description", obj.Description);
                cmd.Parameters.AddWithValue("@InActive", obj.InActive);
                cmd.Parameters.AddWithValue("@OfficeID", obj.OfficeID);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.Parties obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_PartiesUpdate";

                cmd.Parameters.AddWithValue("@PartyID", obj.PartyID);
                cmd.Parameters.AddWithValue("@PartyName", obj.PartyName);
                cmd.Parameters.AddWithValue("@SectorID", obj.SectorID);
                cmd.Parameters.AddWithValue("@Address", obj.Address);
                cmd.Parameters.AddWithValue("@City", obj.City);
                cmd.Parameters.AddWithValue("@Phone1", obj.Phone1);
                cmd.Parameters.AddWithValue("@Phone2", obj.Phone2);
                cmd.Parameters.AddWithValue("@Mobile", obj.Mobile);
                cmd.Parameters.AddWithValue("@Fax", obj.Fax);
                cmd.Parameters.AddWithValue("@EMail", obj.EMail);
                cmd.Parameters.AddWithValue("@ContactPerson", obj.ContactPerson);
                cmd.Parameters.AddWithValue("@PartyType", obj.PartyType);
                cmd.Parameters.AddWithValue("@DiscRatio", obj.DiscRatio);
                cmd.Parameters.AddWithValue("@ReceivablesFlag", obj.ReceivablesFlag);
                cmd.Parameters.AddWithValue("@PayablesFlag", obj.PayablesFlag);
                cmd.Parameters.AddWithValue("@GroupID", obj.GroupID);
                cmd.Parameters.AddWithValue("@DueDays", obj.DueDays);
                cmd.Parameters.AddWithValue("@DebitLimit", obj.DebitLimit);// es main value kya a ri hai 0 a ri hai
                cmd.Parameters.AddWithValue("@CreditLimit", obj.CreditLimit);
                cmd.Parameters.AddWithValue("@Description", obj.Description);
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
                cmd.CommandText = "SP_PartiesDelete";

                cmd.Parameters.AddWithValue("@PartyID", vID);
                new Database(connectionstring).ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }
        }
        public DataTable getRecord(string vWhere)
        {
            string query = @"SELECT     * from Parties Where 1=1 {0}";
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
COALESCE(MAX(Convert(bigint,SUBSTRING(partyid,LEN(62)+1, LEN(partyid)))),0) + 1 
From Parties  where PartyID like '62%' 
";


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


        public int getNextNoForParties()
        {
            int vNextID = 1;

            string vSql = @"Select 
COALESCE(MAX(Convert(bigint,SUBSTRING(partyid,LEN(61)+1, LEN(partyid)))),0) + 1 
From Parties  where PartyID like '62%'
 ";


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
        public int getNextNoForVendor()
        {
            int vNextID = 1;

            string vSql = @"Select 
COALESCE(MAX(Convert(bigint,SUBSTRING(partyid,LEN(61)+1, LEN(partyid)))),0) + 1 
From Parties  where PartyID like '61%'
 ";


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

    
