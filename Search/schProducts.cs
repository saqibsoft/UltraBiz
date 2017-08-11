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
    public partial class schProducts : Form
    {
        string tmpID, tmpName;

        public schProducts()
        {
            InitializeComponent();
        }

        public string MyId
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
                tmpID = Grid.Rows[Grid.CurrentRow.Index].Cells["ProductId"].Value.ToString();
            }
            else tmpID = "";

            if (Grid.Rows.Count > 0 && Grid.CurrentRow.Index != -1)
            {
                tmpName = Grid.Rows[Grid.CurrentRow.Index].Cells["ProductName"].Value.ToString();
            }
            else tmpName = "";

            Close(); //Closes the schProducts Form
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
                vWhere = " AND Products.ProductName Like '%" + txtFilter.Text + "%'";
            }

            //if (int.Parse(CmbFilter.SelectedValue.ToString()) > 0)
            //{
            //    vWhere += " AND ChartOfAccounts.AccountType=" + CmbFilter.SelectedValue;
            //}

            try
            {
                DAL.Products objDAL = new DAL.Products();
                objDAL.connectionstring = vConnectionString;
                dt = objDAL.getSchRecord(vWhere);
                Grid.AutoGenerateColumns = false;
                Grid.DataSource = dt;

            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString());
            }
        }
        private void schProducts_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
    }
}
