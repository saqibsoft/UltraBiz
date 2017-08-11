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
    public partial class DefVendors : Form
    {

        DAL.Parties objDAL = new DAL.Parties();


        string vConnectionString = ConfigurationManager.ConnectionStrings["MyString"].ConnectionString.ToString();

        bool vOpenMode = false;

        public DefVendors()
        {
            InitializeComponent();
        }
        private void DefVendors_Load(object sender, EventArgs e)
        {

            objDAL.connectionstring = vConnectionString;

            TxtID.Text = objDAL.getNextNoForVendor().ToString();
            TxtPrefix.Text = "61";
            PopulateCombos();
            LoadGrid();


     
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
                CmdSelect_Click(null, null);
            }
        }
         private void ClearFields()
        {
            try
            {

                TxtID.Tag = string.Empty;
                TxtName.Text = string.Empty;
                TxtAddress.Text = string.Empty;
                TxtCity.Text = string.Empty;
                txtPhone1.Text = string.Empty;
                txtPhone2.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtMobileNo.Text = string.Empty;
                txtFax.Text = string.Empty;
                vOpenMode = false;
                Grid.Enabled = false;
                TxtFilter.Text = string.Empty;
                TxtFilter.Enabled = false;
                ChkInActive.Checked = false;
                txtContactPerson.Text = string.Empty;
                txtDescription.Text = string.Empty;
                txtDiscRatio.Text = string.Empty;
                TxtName.Focus();
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

                DAL.Offices obj = new DAL.Offices();
                obj.connectionstring = objDAL.connectionstring;
                dt = obj.getRecord(string.Empty);


                CmbOffice.ValueMember = "OfficeID";
                CmbOffice.DisplayMember = "Description";
                CmbOffice.DataSource = dt;


                DAL.PartyGroups  objF = new DAL.PartyGroups();
                objF.connectionstring = objDAL.connectionstring;
                dt = objF.getRecord(string.Empty);

                CmbGroups.ValueMember = "GroupID";
                CmbGroups.DisplayMember = "GroupName";

                CmbGroups.DataSource = dt;

              
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
       
     

          #region // Grid Operations
        private void LoadGrid()
        {
            try
            {

                {
                    //Grid.Rows.Clear();
                    string vWhere = string.Empty;
                    if (!string.IsNullOrEmpty(TxtFilter.Text))
                    {
                        vWhere = " AND Parties.PartyName Like '%" + TxtFilter.Text + "%'";
                    }
                    vWhere += "and  PartyID like '61%' ";
                    


                    DataTable dt = objDAL.getRecord(vWhere);
                    Grid.AutoGenerateColumns = false;
                    Grid.DataSource = dt;
                }
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
                    string vID = Grid.Rows[Grid.CurrentRow.Index].Cells["PartyID"].Value.ToString();
                    TxtPrefix.Text = vID.Substring(0, 2);

                    TxtID.Text = vID.Substring(2);            


                    DataTable dt = objDAL.getRecord(" AND PartyID=" + vID);
                    TxtID.Tag = dt.Rows[0]["GroupID"].ToString();
                    TxtID.Tag = dt.Rows[0]["OfficeID"].ToString();
                    TxtName.Text = dt.Rows[0]["PartyName"].ToString();
                    TxtAddress.Text = dt.Rows[0]["Address"].ToString();
                    txtPhone1.Text = dt.Rows[0]["Phone1"].ToString();
                    txtPhone2.Text = dt.Rows[0]["Phone2"].ToString();
                    TxtCity.Text = dt.Rows[0]["City"].ToString();
                    txtEmail.Text = dt.Rows[0]["Email"].ToString();
                    txtMobileNo.Text = dt.Rows[0]["Mobile"].ToString();
                    txtFax.Text = dt.Rows[0]["Fax"].ToString();
                    txtContactPerson.Text = dt.Rows[0]["ContactPerson"].ToString();
                    txtDiscRatio.Tag = dt.Rows[0]["DiscRatio"].ToString();
                  //  ChkInActive.Checked = Convert.ToBoolean(dt.Rows[0]["InActive"].ToString());
                    if (!string.IsNullOrEmpty(dt.Rows[0]["InActive"].ToString()))
                    {
                        ChkInActive.Checked = Convert.ToBoolean(dt.Rows[0]["InActive"].ToString());
                    }
                    else ChkInActive.Checked = false;
                    if (!string.IsNullOrEmpty(dt.Rows[0]["OfficeID"].ToString()))
                    {
                        CmbOffice.SelectedValue = dt.Rows[0]["OfficeID"].ToString();
                        //CmbOffice.SelectedText = dt.Rows[0]["Description"].ToString();
                    }
                    else
                        CmbOffice.SelectedIndex = -1;


                    if (!string.IsNullOrEmpty(dt.Rows[0]["GroupID"].ToString()))
                    {
                        CmbGroups.SelectedValue = dt.Rows[0]["GroupID"].ToString(); 
                        // CmbGroups.SelectedText = dt.Rows[0]["GroupName"].ToString();
                    }
                    else
                        CmbGroups.SelectedIndex = -1;
                    txtDescription.Tag = dt.Rows[0]["Description"].ToString();

                    vOpenMode = true;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        #endregion

     


        private void CmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtName.Text.Trim() == string.Empty)
                {


                    //MessageBox.Show(exc.Message);

                    TxtName.Focus();
                    return;

                }


                Objects.Parties obj = new Objects.Parties();
                obj.PartyID = TxtPrefix.Text + "" + TxtID.Text;
                obj.PartyName = TxtName.Text.Trim();
                obj.Address = TxtAddress.Text.Trim();
                obj.Phone1 = txtPhone1.Text.Trim();
                obj.Phone2 = txtPhone2.Text.Trim();
                obj.City = TxtCity.Text.Trim();
                obj.Mobile = txtMobileNo.Text.Trim();
                obj.Fax = txtFax.Text.Trim();
                obj.EMail = txtEmail.Text.Trim();
                obj.ContactPerson = txtContactPerson.Text.Trim();
                //obj.DiscRatio  = txtDiscRatio.Text.Trim();
                obj.Description = txtDescription.Text.Trim();
                int vDiscRatio;
                int.TryParse(txtDiscRatio.Text, out vDiscRatio);

                obj.DiscRatio = vDiscRatio;
                obj.OfficeID = int.Parse(CmbOffice.SelectedValue.ToString());
                obj.GroupID = int.Parse(CmbGroups.SelectedValue.ToString());
                obj.InActive = ChkInActive.Checked;

                //  decimal vOpDebit = 0;
                //  decimal vOpCredit = 0;


                //Insert Account
                var AccDAL = new DAL.ChartOfAccounts();
                AccDAL.connectionstring = objDAL.connectionstring;
                Objects.ChartOfAccounts objAcc = new Objects.ChartOfAccounts();
                if (!string.IsNullOrEmpty(TxtID.Tag.ToString()))
                    objAcc.AccountNo = TxtID.Tag.ToString();
                objAcc.AccountName = obj.PartyName;
                objAcc.AccountType = "Parties";
                objAcc.InActive = true;
                objAcc.AccountDepth = 2;
                objAcc.AccountNameUrdu = txtNameUrdu.Text.Trim();
                objAcc.Narration = txtDescription.Text.Trim();
                objAcc.OfficeID = Int32.Parse(CmbOffice.SelectedValue.ToString());
                objAcc.OpeningDebit = 0;
                objAcc.OpeningCredit = 0;
                objAcc.ParentAccountNo = "61";

                objAcc.ResidualValue = 0;
                objAcc.IsDetailed = false;
                objAcc.IsSold = false;
                objAcc.EntryDate = DateTime.Now;
                objAcc.AdjustedCredit = 0;
                objAcc.AdjustedDebit = 0;
                objAcc.BalFlag = false;
                objAcc.ExpFlag = false;
                objAcc.IsEditable = false;
                objAcc.IsLocked = false;
                objAcc.IsPosted = false;

                decimal vDisRatio;
                decimal.TryParse(txtDiscRatio.Text, out vDisRatio);


                objAcc.Life = vDisRatio;
                objAcc.PLFlag = Convert.ToBoolean(obj.PayablesFlag).ToString();
                objAcc.UserNo = 1;




                if (!vOpenMode)
                {
                    objAcc.AccountNo = obj.PartyID; //objDAL.getNextNo().ToString();
                    AccDAL.InsertRecord(objAcc);
                    //Insert Party
                    // obj.PartyID = objDAL.getNextNo().ToString ();
                    //  obj.AccountID= objAcc.AccountNo;

                    objDAL.InsertRecord(obj);
                }
                else
                {
                    // UPdate Opeinig in Account
                    //  AccDAL.UpdateRecord(objAcc);
                    objDAL.UpdateRecord(obj);
                }

                MessageBox.Show("SaveRecord");
                LoadGrid();
                CmdClear_Click(sender, e);


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
                //LoadGrid(CmbOffice.SelectedValue.ToString());

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void CmdSelect_Click(object sender, EventArgs e)
        {
            Grid.Enabled = true;
            TxtFilter.Enabled = true;
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

       


    }
}
