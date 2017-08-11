using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;


namespace DAL
{
    public class PartyGroups
    {
        public string connectionstring;
        public void InsertRecord(Objects.PartyGroups obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_PartyGroupsInsert";

                /**/
                cmd.Parameters.AddWithValue("@GroupID", obj.GroupID);
                cmd.Parameters.AddWithValue("@GroupName", obj.GroupName);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.PartyGroups obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_PartyGroupsUpdate";

                cmd.Parameters.AddWithValue("@GroupID", obj.GroupID);
                cmd.Parameters.AddWithValue("@GroupName", obj.GroupName);


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
                cmd.CommandText = "SP_PartyGroupsDelete";

                cmd.Parameters.AddWithValue("@GroupID", vID);
                new Database(connectionstring).ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }
        }
        public DataTable getRecord(string vWhere)
        {
            string query = @"SELECT     * from PartyGroups Where 1=1 {0}";
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

            string vSql = "Select COALESCE(MAX(Isnull(GroupID,0)),0) + 1  as GroupID From PartyGroups ";


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
