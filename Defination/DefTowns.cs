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
    public partial class DefTowns : Form
    {
        DAL.Towns DAL = new DAL.Towns();


        string vConnectionString = ConfigurationManager.ConnectionStrings["MyString"].ConnectionString.ToString();

        bool vOpenMode = false;

        public DefTowns()
        {
            InitializeComponent();
        }
        private void DefTowns_Load(object sender, EventArgs e)
        {
            DAL.connectionstring = vConnectionString;
            LoadGrid();
        }
        private void DefTowns_KeyDown(object sender, KeyEventArgs e)
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

                txtName.Text = string.Empty;
                txtName.Tag = string.Empty;
                vOpenMode = false;
                Grid.Enabled = false;
                //txtFilter.Text = string.Empty;
                //txtFilter.Enabled = false;
                txtName.Focus();
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

                DAL.DeleteRecord(Int16.Parse(txtName.Tag.ToString()));
                MessageBox.Show("Record Deleted Successfully.", "Task Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);              

               
                CmdClear_Click(sender,e);
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
                if (txtName.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter TownName", "TownName");
                    txtName.Focus();
                    return;
                }


                Objects.Towns obj = new Objects.Towns();
                obj.TownName = txtName.Text.Trim();


                if (!vOpenMode)
                {
                    obj.TownID = Int32.Parse(DAL.getNextNo().ToString());
                    DAL.InsertRecord(obj);
                }
                else
                {
                    // UPdate 
                    obj.TownID = Int16.Parse(txtName.Tag.ToString());
                    DAL.UpdateRecord(obj);
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
                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    vWhere = " AND TownName Like '%" + txtName.Text + "%'";
                }

                DataTable dt = DAL.getRecord(vWhere);
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
                    txtName.Tag = Grid.Rows[Grid.CurrentRow.Index].Cells["TownID"].Value.ToString();


                    DataTable dt = DAL.getRecord(" AND TownID=" + txtName.Tag);
                    txtName.Text = dt.Rows[0]["TownName"].ToString();

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
