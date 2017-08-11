using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;


namespace DAL
{
    public class ProductBarcodes
    {
        public string connectionstring;
        public void InsertRecord(Objects.ProductBarcodes obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ProductBarcodesInsert";

                /**/
                cmd.Parameters.AddWithValue("@ProductID", obj.ProductID);
                cmd.Parameters.AddWithValue("@BarCode", obj.BarCode);
                cmd.Parameters.AddWithValue("@ShortCode", obj.ShortCode);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.ProductBarcodes obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ProductBarcodesUpdate";

                cmd.Parameters.AddWithValue("@ProductID", obj.ProductID);
                cmd.Parameters.AddWithValue("@BarCode", obj.BarCode);
                cmd.Parameters.AddWithValue("@ShortCode", obj.ShortCode);


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
                cmd.CommandText = "SP_ProductBarcodesDelete";

                cmd.Parameters.AddWithValue("@ProductID", vID);
                new Database(connectionstring).ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }
        }
        public DataTable getRecord(string vWhere)
        {
            string query = @"SELECT  * from ProductBarcodes Where 1=1 {0}";
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

            string vSql = "Select COALESCE(MAX(Isnull(ProductID,0)),0) + 1  as ProductID From ProductBarcodes ";


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
