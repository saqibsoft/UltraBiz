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
    public partial class DefPartyGroups : Form
    {
        DAL.PartyGroups  objDAL = new DAL.PartyGroups ();


        string vConnectionString = ConfigurationManager.ConnectionStrings["MyString"].ConnectionString.ToString();

        bool vOpenMode = false;

        public DefPartyGroups()
        {
            InitializeComponent();
        }
        private void DefPartyGroups_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = vConnectionString;
            LoadGrid();
        }
        private void DefTransport_KeyDown(object sender, KeyEventArgs e)
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

                TxtName.Text = string.Empty;
                TxtName.Tag = string.Empty;
                vOpenMode = false;
                Grid.Enabled = false;
                //txtFilter.Text = string.Empty;
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

                objDAL.DeleteRecord(Int16.Parse(TxtName.Tag.ToString()));
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
                    MessageBox.Show("Please Enter Party Name", " Party Name");
                    TxtName.Focus();
                    return;
                }


                Objects.PartyGroups obj = new Objects.PartyGroups();

                obj.GroupName = TxtName.Text.Trim();


                if (!vOpenMode)
                {
                    obj.GroupID = Int32.Parse(objDAL.getNextNo().ToString());
                    objDAL.InsertRecord(obj);
                }
                else
                {
                    // UPdate 
                    obj.GroupID = Int16.Parse(TxtName.Tag.ToString());
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
                    vWhere = " AND Transport Like '%" + TxtName.Text + "%'";
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
                    TxtName.Tag = Grid.Rows[Grid.CurrentRow.Index].Cells["GroupID"].Value.ToString();


                    DataTable dt = objDAL.getRecord(" AND GroupID=" + TxtName.Tag);
                    TxtName.Text = dt.Rows[0]["GroupName"].ToString();

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
