
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;


namespace DAL
{
    public class DefineFormula
    {
        public string connectionstring;
        public void InsertRecord(Objects.DefineFormula obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_DefineFormulaInsert";

                /**/cmd.Parameters.AddWithValue("@FormulaID", obj.FormulaID);
cmd.Parameters.AddWithValue("@ProductId", obj.ProductId);
cmd.Parameters.AddWithValue("@PackingId", obj.PackingId);
cmd.Parameters.AddWithValue("@Qty", obj.Qty);
cmd.Parameters.AddWithValue("@AvgRate", obj.AvgRate);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
       
        public void InsertRecordBody (Objects.DefineFormulaBody obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_DefineFormulaBodyInsert";

                /**/cmd.Parameters.AddWithValue("@SerialNo", obj.SerialNo);
cmd.Parameters.AddWithValue("@FormulaID", obj.FormulaID);
cmd.Parameters.AddWithValue("@ProductId", obj.ProductId);
cmd.Parameters.AddWithValue("@PackingId", obj.PackingId);
cmd.Parameters.AddWithValue("@Qty", obj.Qty);
cmd.Parameters.AddWithValue("@Rate", obj.Rate);


                new Database(connectionstring).ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.DefineFormula obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_DefineFormulaUpdate";

                cmd.Parameters.AddWithValue("@FormulaID", obj.FormulaID);
cmd.Parameters.AddWithValue("@ProductId", obj.ProductId);
cmd.Parameters.AddWithValue("@PackingId", obj.PackingId);
cmd.Parameters.AddWithValue("@Qty", obj.Qty);
cmd.Parameters.AddWithValue("@AvgRate", obj.AvgRate);


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
                cmd.CommandText = "SP_DefineFormulaDelete";

                cmd.Parameters.AddWithValue("@FormulaID", vID);
                new Database(connectionstring).ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }
        }
 public void DeleteRecordBody(Int64 vID)
 {
     try
     {
         SqlCommand cmd = new SqlCommand();
         cmd.CommandType = CommandType.StoredProcedure;
         cmd.CommandText = "SP_DefineFormulaBodyDelete";

         cmd.Parameters.AddWithValue("@SerialNo", vID);
         new Database(connectionstring).ExecuteNonQueryOnly(cmd);

     }
     catch (Exception exc)
     {

         throw exc;
     }
 }
        public DataTable getRecord(string vWhere)
        {
            string query = @"SELECT     * from DefineFormula Where 1=1 {0}";
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

            string vSql = "Select COALESCE(MAX(Isnull(FormulaID,0)),0) + 1  as FormulaID From DefineFormula ";


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