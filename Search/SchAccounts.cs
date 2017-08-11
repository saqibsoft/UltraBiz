using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Search
{
    public partial class SchAccounts : Form
    {

          string tmpID,tmpName;

        public SchAccounts()
        {
            InitializeComponent();
        }
         public string MyID
        {
            get
            {
                return tmpID;
            }
        }

        public string MyName
        {
            get
            {
                return tmpName;                
            }
        }


         DataTable dt;
        string vConnectionString = ConfigurationManager.ConnectionStrings["MyString"].ConnectionString.ToString();

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectRecord();
        }

        private void SelectRecord()
        {
            if (Grid.Rows.Count > 0 && Grid.CurrentRow.Index != -1)
            {
                tmpID = Grid.Rows[Grid.CurrentRow.Index].Cells["AccountNo"].Value.ToString();
            }
            else tmpID = "";

            if (Grid.Rows.Count > 0 && Grid.CurrentRow.Index != -1)
            {
                tmpName = Grid.Rows[Grid.CurrentRow.Index].Cells["AccountName"].Value.ToString();
            }
            else tmpName = "";
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tmpID = string.Empty;
            tmpName = string.Empty;
            Close();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            string vWhere = string.Empty;

            if (!string.IsNullOrEmpty(txtFilter.Text))
            {
                vWhere = " AND ChartOfAccounts.AccountName Like '%" + txtFilter.Text + "%'";
            }

            if (int.Parse(CmbFilter.SelectedValue.ToString()) > 0)
            {
                vWhere += " AND ChartOfAccounts.AccountType=" + CmbFilter.SelectedValue;
            }

            try
            {
                DAL.ChartOfAccounts  objDAL = new DAL.ChartOfAccounts();
                objDAL.connectionstring = vConnectionString;
                dt = objDAL.getRecord(vWhere);
                Grid.AutoGenerateColumns = false;
                Grid.DataSource = dt;

            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString());
            }
        }


        private void PopulateCombos()
        {
            try
            {
                DataTable dt = new DataTable();

                DAL.ChartOfAccounts obj = new DAL.ChartOfAccounts();
                obj.connectionstring = vConnectionString;
                dt = obj.getRecord(string.Empty);

                DataRow dr = dt.NewRow();
                dr["AccountNo"] = "0";
                dr["AccountName"] = "ALL";
                dr["AccountType"] = "";

                dt.Rows.Add(dr);

                CmbFilter.DataSource = dt;
                CmbFilter.ValueMember = "AccountNo";
                CmbFilter.DisplayMember = "AccountName";

                CmbFilter.SelectedValue = "0";
                CmbFilter.SelectedText = "ALL";


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void SchAccounts_Load(object sender, EventArgs e)
        {
            PopulateCombos();
            DisplayData();
        }
        
    }
}
