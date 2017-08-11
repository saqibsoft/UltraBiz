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
    public partial class DefCompanies : Form
    {
        DAL.Companies  objDAL = new DAL.Companies ();


    string vConnectionString = ConfigurationManager.ConnectionStrings["MyString"].ConnectionString.ToString();

        bool vOpenMode = false;

        public DefCompanies()
        {
            InitializeComponent();
        }
        private void DefCompanies_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = vConnectionString;
            LoadGrid();
            ClearFields();

        }
        private void DefCompanies_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                CmdSave_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.D)
            {
                CmdDelete_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.E)
            {
                CmdClose_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.P)
            {
                //btnPrint_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.R)
            {
                CmdClear_Click(null, null);
            }
            else if (e.Control && e.KeyCode == Keys.O)
            {
                CmdOpen_Click(null, null);
            }
        }
        private void ClearFields()
        {
            try
            {
                TxtName.Tag = string.Empty; ;
                TxtName.Text = string.Empty;
                txtID.Text = objDAL.getNextNo().ToString();
                vOpenMode = false;
                Grid.Enabled = false;
                // txtFilter.Text = string.Empty;
                //txtFilter.Enabled = false;
                TxtName.Focus();
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
        private void CmdClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void CmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!vOpenMode) return;
                DialogResult dMsg = MessageBox.Show("Are you Sure To Delete!!!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dMsg == DialogResult.No) return;
                objDAL.DeleteRecord(int.Parse(txtID.Text ));
                MessageBox.Show("Record Deleted Successfully.", "Task Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);              

                CmdClear_Click(sender, e);
                LoadGrid();
               
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void CmdOpen_Click(object sender, EventArgs e)
        {
            Grid.Enabled = true;
        }
        private void CmdSave_Click(object sender, EventArgs e)
        {


            try
            {
                if (TxtName.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Company Name", "Company Name");
                    TxtName.Focus();
                    return;
                }


                Objects.Companies obj = new Objects.Companies();
                obj.CompanyID = txtID.Text.ToString();
                obj.CompanyName = TxtName.Text.Trim();


                if (!vOpenMode)
                {
                    obj.CompanyID = objDAL.getNextNo().ToString();
                    objDAL.InsertRecord(obj);
                }
                else
                {
                    // UPdate 
                    obj.CompanyID = TxtName.Tag.ToString();
                    objDAL.UpdateRecord(obj);
                }

                CmdClear_Click(sender, e);
                LoadGrid();

                MessageBox.Show("Record Saved Succesfully", "Save");


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        #endregion                

        #region // Grid Operations
        private void LoadGrid()
        {
            try
            {
                //Grid.Rows.Clear();
                string vWhere = string.Empty;
                if (!string.IsNullOrEmpty(TxtName.Text))
                {
                    vWhere = " AND CompanyName Like '%" + TxtName.Tag + "%'";
                }

                DataTable dt = objDAL.getRecord(vWhere);
                Grid.AutoGenerateColumns = false;
                Grid.DataSource = dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void Grid_DoubleClick(object sender, EventArgs e)
        {

        }
        private void Grid_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grid.Rows.Count > 0 && Grid.CurrentRow.Index != -1)
                {
                    TxtName.Tag = Grid.Rows[Grid.CurrentRow.Index].Cells["CompanyID"].Value.ToString();


                    DataTable dt = objDAL.getRecord(" AND CompanyID =" + TxtName.Tag);
                    TxtName.Text = dt.Rows[0]["CompanyName"].ToString();

                    vOpenMode = true;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        #endregion

        
       

      
     
    }
}
