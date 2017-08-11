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
    public partial class DefPackings : Form
    {
        DAL.Packings  objDAL = new DAL.Packings();


        string vConnectionString = ConfigurationManager.ConnectionStrings["MyString"].ConnectionString.ToString();

        bool vOpenMode = false;

        public DefPackings()
        {
            InitializeComponent();
        }

        private void DefPackings_Load(object sender, EventArgs e)
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
                txtAbbrevation.Tag = string.Empty;
                txtAbbrevation.Text = string.Empty;
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
                objDAL.DeleteRecord(int.Parse(txtID.Text));
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
                    MessageBox.Show("Please Enter Packing Name", "Packing Name");
                    TxtName.Focus();
                    return;
                }


                Objects.Packings obj = new Objects.Packings();
                obj.PackingId = Int32.Parse(txtID.Text);
                obj.PackingName = TxtName.Text.Trim();
                obj.Abbrevation = txtAbbrevation.Text.Trim();

                if (!vOpenMode)
                {
                    obj.PackingId = objDAL.getNextNo();
                    objDAL.InsertRecord(obj);
                }
                else
                {
                    // UPdate 
                    obj.PackingId = Int32.Parse(txtID.Text);
                    objDAL.UpdateRecord(obj);
                }

                MessageBox.Show("Record Saved Succesfully", "Save");
                CmdClear_Click(sender, e);
                LoadGrid();



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
                    vWhere = " AND  PackingName Like '%" + TxtName.Text + "%'";
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
                    txtID.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["PackingID"].Value.ToString();


                    DataTable dt = objDAL.getRecord(" AND PackingID =" + txtID.Text);
                    TxtName.Text = dt.Rows[0]["PackingName"].ToString();
                    txtAbbrevation.Text = dt.Rows[0]["Abbrevation"].ToString();
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
