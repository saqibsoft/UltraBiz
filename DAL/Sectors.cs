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
    public class Sectors
    {
        public string connectionstring;
        public void InsertRecord(Objects.Sectors obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_SectorsInsert";

                /**/
                cmd.Parameters.AddWithValue("@SectorID", obj.SectorID);
                cmd.Parameters.AddWithValue("@TownID", obj.TownID);
                cmd.Parameters.AddWithValue("@SectorName", obj.SectorName);
                cmd.Parameters.AddWithValue("@SectorOrder", obj.SectorOrder);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.Sectors obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_SectorsUpdate";

                cmd.Parameters.AddWithValue("@SectorID", obj.SectorID);
                cmd.Parameters.AddWithValue("@TownID", obj.TownID);
                cmd.Parameters.AddWithValue("@SectorName", obj.SectorName);
                cmd.Parameters.AddWithValue("@SectorOrder", obj.SectorOrder);


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
                cmd.CommandText = "SP_SectorsDelete";

                cmd.Parameters.AddWithValue("@SectorID", vID);
                new Database(connectionstring).ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }
        }
        public DataTable getRecord(string vWhere)
        {
            string query = @"SELECT     * from Sectors Where 1=1 {0}";
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

            string vSql = "Select COALESCE(MAX(Isnull(SectorID,0)),0) + 1  as SectorID From Sectors ";


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
