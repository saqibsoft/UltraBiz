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

namespace Defination
{
    public partial class DefProductBarcodes : Form
    {
        DAL.ProductBarcodes objDAL = new DAL.ProductBarcodes();

        string vConnectionString = ConfigurationManager.ConnectionStrings["MyString"].ConnectionString.ToString();

        bool vOpenMode = false;

        public DefProductBarcodes()
        {
            InitializeComponent();
        }

        private void DefProductBarcodes_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = vConnectionString;
            LoadGrid();
        }

        private void ClearFields()
        {
            try
            {

                TxtProductID.Text = string.Empty;
                TxtProductID.Tag = string.Empty;
                vOpenMode = false;
                GridProduct.Enabled = false;
                //txtFilter.Text = string.Empty;
                //txtFilter.Enabled = false;
                TxtProductID.Focus();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        #region // Buttons Click
        private void CmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void CmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!vOpenMode) return;
                DialogResult dMsg = MessageBox.Show("Are you Sure To Delete!!!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dMsg == DialogResult.No) return;

                objDAL.DeleteRecord(Int16.Parse(TxtProductID.Tag.ToString()));
                MessageBox.Show("Record Deleted Successfully.", "Task Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);


                CmdClear_Click(sender, e);
                LoadGrid();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region // GridProduct Operations
        private void LoadGrid()
        {
            try
            {
                //GridProduct.Rows.Clear();
                string vWhere = string.Empty;
                if (!string.IsNullOrEmpty(TxtProductID.Text))
                {
                    vWhere = " AND ProductID Like '%" + TxtProductID.Text + "%'";
                }

                DataTable dt = objDAL.getRecord(vWhere);
                GridProduct.AutoGenerateColumns = false;
                GridProduct.DataSource = dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void GridProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridProduct.Rows.Count > 0 && GridProduct.CurrentRow.Index != -1)
                {
                    TxtProductID.Tag = GridProduct.Rows[GridProduct.CurrentRow.Index].Cells["ProductID"].Value.ToString();

                    DataTable dt = new DataTable();
                    DAL.Products obj = new DAL.Products();
                    obj.connectionstring = objDAL.connectionstring;
                    dt = obj.getRecord(" AND ProductID='" + TxtProductID.Tag.ToString() + "'");
                    TxtProductID.Text = dt.Rows[0]["ProductId"].ToString();
                    TxtProductName.Text = dt.Rows[0]["ProductName"].ToString();


                    //DataTable dt = objDAL.getRecord(" AND ProductID='" + TxtProductID.Tag.ToString() + "'");

                    vOpenMode = true;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        #endregion

        private void TxtProductID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Search.schProducts vForm = new Search.schProducts();
                vForm.ShowDialog();
            }
        }
    }
}
