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
    public partial class DefGroups : Form
    {
        
        DAL.CompanyGroups objDAL = new DAL.CompanyGroups();


        string vConnectionString = ConfigurationManager.ConnectionStrings["MyString"].ConnectionString.ToString();

        bool vOpenMode = false;

        public DefGroups()
        {
            InitializeComponent();
        }
        private void DefGroups_Load(object sender, EventArgs e)
        {

            objDAL.connectionstring = vConnectionString;
            PopulateCombos();
            LoadGrid(CmbFilter.SelectedValue.ToString());
            ClearFields();
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
                CmbFilter.Enabled = false;
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

                DAL.Companies obj = new DAL.Companies();
                obj.connectionstring = objDAL.connectionstring;
                dt = obj.getRecord(string.Empty);


                CmbCompany.ValueMember = "CompanyID";
                CmbCompany.DisplayMember = "CompanyName";
                CmbCompany.DataSource = dt;


                DAL.Companies objF = new DAL.Companies();
                obj.connectionstring = objDAL.connectionstring;
                dt = obj.getRecord(string.Empty);

                CmbFilter.ValueMember = "CompanyID";
                CmbFilter.DisplayMember = "CompanyName";

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
        private void CmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrid(CmbCompany.SelectedValue.ToString());
        }

         #region // Buttons Click
        private void CmdClose_Click(object sender, EventArgs e)
        {
            

            Close();
        }
        private void CmdOpen_Click(object sender, EventArgs e)
        {
            Grid.Enabled = true;
            CmbFilter.Enabled = true;
            
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

                int vCompany;
                int.TryParse(CmbCompany.SelectedValue.ToString(), out vCompany);
               


                Objects.CompanyGroups obj = new Objects.CompanyGroups();
               






                obj.GroupName = txtName.Text.Trim();
                
                if (vCompany > 0) obj.CompanyID = vCompany.ToString();

                if (!vOpenMode)
                {
                    obj.GroupID = Int32.Parse(objDAL.getNextNo().ToString());
                    objDAL.InsertRecord(obj);
                }
                else
                {
                    
                    obj.GroupID = Int16.Parse(txtName.Tag.ToString());
                    objDAL.UpdateRecord(obj);
                }

                MessageBox.Show("Record Saved Succesfully", "Save");
                LoadGrid(CmbCompany.SelectedValue.ToString());
                CmdClear_Click(sender, e);
              



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
              
                string vWhere = string.Empty;




                if (!string.IsNullOrEmpty(filter))
                {
                    vWhere = " AND CompanyID =" + filter;
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
                    txtName.Tag = Grid.Rows[Grid.CurrentRow.Index].Cells["GroupID"].Value.ToString();


                    DataTable dt = objDAL.getRecord(" AND GroupID =" + txtName.Tag);
                    txtName.Text = dt.Rows[0]["GroupName"].ToString();
                
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
