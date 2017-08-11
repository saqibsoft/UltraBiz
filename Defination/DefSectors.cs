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
    public partial class DefSectors : Form
    {
        
        DAL.Sectors objDAL = new DAL.Sectors();


        string vConnectionString = ConfigurationManager.ConnectionStrings["MyString"].ConnectionString.ToString();

        bool vOpenMode = false;

        public DefSectors()
        {
            InitializeComponent();
        }
        private void DefSectors_Load(object sender, EventArgs e)
        {

            objDAL.connectionstring = vConnectionString;
            PopulateCombos();
            LoadGrid(CmbFilter.SelectedValue.ToString());

        }
        private void DefOffices_KeyDown(object sender, KeyEventArgs e)
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
        private void PopulateCombos()
        {
            try
            {
                DataTable dt = new DataTable();

                DAL.Towns obj = new DAL.Towns();
                obj.connectionstring = objDAL.connectionstring;
                dt = obj.getRecord(string.Empty);


                CmbTown.ValueMember = "TownID";
                CmbTown.DisplayMember = "TownName";
                CmbTown.DataSource = dt;


                DAL.Towns objF = new DAL.Towns();
                obj.connectionstring = objDAL.connectionstring;
                dt = obj.getRecord(string.Empty);

                CmbFilter.ValueMember = "TownID";
                CmbFilter.DisplayMember = "TownName";

                CmbFilter.DataSource = dt;

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void CmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrid(CmbFilter.SelectedValue.ToString());
        }
        private void CmbTown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrid(CmbTown.SelectedValue.ToString());
        }

        #region // Buttons Click
        private void CmdClose_Click(object sender, EventArgs e)
        {
            

            Close();
        }
        private void CmdOpen_Click(object sender, EventArgs e)
        {
            Grid.Enabled = true;
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

                objDAL.DeleteRecord(Int16.Parse(txtName.Tag.ToString()));
                MessageBox.Show("Record Deleted Successfully.", "Task Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);              

                CmdClear_Click(sender, e);
                LoadGrid(CmbFilter.SelectedValue.ToString());

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void CmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Sector Name", "Sector Name");
                    txtName.Focus();
                    return;
                }

                int vTown;
                int.TryParse(CmbTown.SelectedValue.ToString(), out vTown);
                //  int.TryParse(CmbFilter.SelectedValue.ToString(), out vFilter);


                Objects.Sectors obj = new Objects.Sectors();
                // obj.SectorOrder = txtOrd






                obj.SectorName = txtName.Text.Trim();
                // obj.TownID = vFilter;
                if (vTown > 0) obj.TownID = vTown;

                if (!vOpenMode)
                {
                    obj.SectorID = Int32.Parse(objDAL.getNextNo().ToString());
                    objDAL.InsertRecord(obj);
                }
                else
                {
                    // UPdate 
                    obj.SectorID = Int16.Parse(txtName.Tag.ToString());
                    objDAL.UpdateRecord(obj);
                }

                MessageBox.Show("Record Saved Succesfully", "Save");
                CmdClear_Click(sender, e);
                LoadGrid(CmbTown.SelectedValue.ToString());



            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        #endregion
  

        #region // Grid Operations
        private void LoadGrid(string filter)
        {
            try
            {
               // Grid.Rows.Clear();
                string vWhere = string.Empty;




                if (!string.IsNullOrEmpty(filter))
                {
                    vWhere = " AND TownID =" + filter;
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
                    txtName.Tag = Grid.Rows[Grid.CurrentRow.Index].Cells["SectorID"].Value.ToString();


                    DataTable dt = objDAL.getRecord(" AND SectorID =" + txtName.Tag);
                    txtName.Text = dt.Rows[0]["SectorName"].ToString();
                    //CmbTown.SelectedValue = dt.Rows[0]["SectorID"].ToString();
                    //CmbTown.SelectedText = dt.Rows[0]["SectorName"].ToString();

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
