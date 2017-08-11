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
    public partial class DefParties : Form
    {
        DAL.Parties objDAL = new DAL.Parties();


        string vConnectionString = ConfigurationManager.ConnectionStrings["MyString"].ConnectionString.ToString();

        bool vOpenMode = false;

        public DefParties()
        {
            InitializeComponent();
        }
        private void Parties_Load(object sender, EventArgs e)
        {
            objDAL.connectionstring = vConnectionString;
            TxtID.Text = objDAL.getNextNoForParties().ToString();
            TxtPrefix.Text = "62";
            PopulateCombos();
            ClearFields();
            LoadGrid();
            
        }
        private void PartiesInfo_KeyDown(object sender, KeyEventArgs e)
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
        private void CmbFilterTown_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadFilterSector();
        }
        private void CmbFilterSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void PopulateCombos()
        {
            try
            {
                DataTable dt = new DataTable();

                DAL.Offices obj = new DAL.Offices();
                obj.connectionstring = objDAL.connectionstring;
                dt = obj.getRecord(string.Empty);

                CmbOffice.DataSource = dt;
                CmbOffice.ValueMember = "OfficeID";
                CmbOffice.DisplayMember = "Description";


                DAL.Towns objT = new DAL.Towns();
                objT.connectionstring = objDAL.connectionstring;
                dt = objT.getRecord(string.Empty);


                CmbTown.ValueMember = "TownID";
                CmbTown.DisplayMember = "TownName";
                CmbTown.DataSource = dt;




                DAL.PartyGroups objG = new DAL.PartyGroups();
                objG.connectionstring = objDAL.connectionstring;
                dt = objG.getRecord(string.Empty);

                CmbGroups.DataSource = dt;
                CmbGroups.ValueMember = "GroupID";
                CmbGroups.DisplayMember = "GroupName";

                DAL.Towns objF = new DAL.Towns();
                objF.connectionstring = objDAL.connectionstring;
                dt = objF.getRecord(string.Empty);


                CmbFilterTown.ValueMember = "TownID";
                CmbFilterTown.DisplayMember = "TownName";
                CmbFilterTown.DataSource = dt;




            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void loadFilterSector()
        {
            DAL.Sectors objE = new DAL.Sectors();
            objE.connectionstring = objDAL.connectionstring;
            DataTable dt = objE.getRecord("and TownID =" + CmbFilterTown.SelectedValue.ToString());

            CmbFilterSector.DataSource = dt;
            CmbFilterSector.ValueMember = "SectorID";
            CmbFilterSector.DisplayMember = "SectorName";
        }
        private void loadSectors()
        {
            DAL.Sectors objS = new DAL.Sectors();
            objS.connectionstring = objDAL.connectionstring;
            DataTable dt = objS.getRecord("and TownID =" + CmbTown.SelectedValue.ToString());

            CmbSector.DataSource = dt;
            CmbSector.ValueMember = "SectorID";
            CmbSector.DisplayMember = "SectorName";
        }
        private void CmbTown_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSectors();
        }

        #region // Control Operations
        private void ClearFields()
        {
            try
            {
               
                TxtID.Tag = string.Empty;
                txtName.Text = string.Empty;
                TxtAddress.Text = string.Empty;
                TxtCity.Text = string.Empty;
                txtPhone1.Text = string.Empty;
                txtPhone2.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtMobileNo.Text = string.Empty;
                txtFax.Text = string.Empty;
                this.txtDebitLimit.Text = "0";
                this.txtCreditLimit.Text = "0";
                vOpenMode = false;
                Grid.Enabled = false;
                TxtFilter.Text = string.Empty;
                TxtFilter.Enabled = false;
                CmbFilterSector.Enabled = false;
                CmbFilterTown.Enabled = false;
                ChkInActive.Checked = false;
                ChkVendor.Checked = false;
                txtContactPerson.Text=string .Empty;
                txtDescription.Text=string.Empty;
                txtDueDays.Text=string.Empty;
                txtDiscRatio.Text = string.Empty;
                txtName.Focus();
            }
            catch (Exception exc)
            {
                MessageBox.Show( exc.Message);
            }
        }
        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }
        #endregion


        #region // Grid Operations
        private void LoadGrid()
        {
            try
            {
                //Grid.Rows.Clear();
                string vWhere = string.Empty;
                if (!string.IsNullOrEmpty(TxtFilter.Text))
                {
                    vWhere = " AND Parties.PartyName Like '%" + TxtFilter.Text + "%'";
                }
                vWhere += "and PartyID like '62%'";
                DataTable dt = objDAL.getRecord(vWhere);
                Grid.AutoGenerateColumns = false;
                Grid.DataSource = dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show( exc.Message);
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

                   // TxtID.Text = Grid.Rows[Grid.CurrentRow.Index].Cells["PartyID"].Value.ToString();


                    DataTable dt = objDAL.getRecord(" AND PartyID=" + vID);
                    TxtID.Tag = dt.Rows[0]["PartyID"].ToString();

                    CmbGroups.SelectedValue = dt.Rows[0]["GroupID"].ToString(); // ye groupid or Ofice id Tag main na deni , name likhain yaha 
                    CmbOffice.SelectedValue  = dt.Rows[0]["OfficeID"].ToString();
                    txtName.Text = dt.Rows[0]["PartyName"].ToString();
                    TxtAddress.Text = dt.Rows[0]["Address"].ToString();
                    txtPhone1.Text = dt.Rows[0]["Phone1"].ToString();
                    txtPhone2.Text = dt.Rows[0]["Phone2"].ToString();
                    TxtCity.Text = dt.Rows[0]["City"].ToString();
                    txtEmail.Text = dt.Rows[0]["Email"].ToString();
                    txtMobileNo.Text = dt.Rows[0]["Mobile"].ToString();
                    txtFax.Text = dt.Rows[0]["Fax"].ToString();
                    txtContactPerson.Text = dt.Rows[0]["ContactPerson"].ToString();
                    txtDiscRatio.Tag = dt.Rows[0]["DiscRatio"].ToString();
                    if (dt.Rows[0]["PartyType"].ToString() == "V")
                       ChkVendor.Checked = true;
                    else
                        ChkVendor.Checked = false;
                   
                    if (!string.IsNullOrEmpty(dt.Rows[0]["OfficeID"].ToString()))
                    {
                        CmbOffice.SelectedValue = dt.Rows[0]["OfficeID"].ToString();
                        //CmbOffice.SelectedText = dt.Rows[0]["Description"].ToString();
                    }
                    else
                        CmbOffice.SelectedIndex = -1;


                    if (!string.IsNullOrEmpty(dt.Rows[0]["GroupID"].ToString()))
                    {
                        CmbGroups.SelectedValue = dt.Rows[0]["GroupID"].ToString(); // yaha dekahin selected value kya a ri hai null .. means group save nai howa

                       // CmbGroups.SelectedText = dt.Rows[0]["GroupName"].ToString();
                    }
                    else
                        CmbGroups.SelectedIndex = -1;
                    if (!string.IsNullOrEmpty(dt.Rows[0]["SectorID"].ToString()))
                    {
                        CmbSector.SelectedValue = dt.Rows[0]["SectorID"].ToString();
                       // CmbSector.SelectedText = dt.Rows[0]["SectorName"].ToString();
                    }
                    else
                        CmbSector.SelectedIndex = -1;
                    if (!string.IsNullOrEmpty(dt.Rows[0]["DueDays"].ToString()))
                    {
                        txtDueDays.Text = decimal.Parse(dt.Rows[0]["DueDays"].ToString()).ToString("G29");
                    }
                    else txtDueDays.Text = string.Empty;

                    if (!string.IsNullOrEmpty(dt.Rows[0]["InActive"].ToString()))
                    {
                        ChkInActive.Checked = Convert.ToBoolean(dt.Rows[0]["InActive"].ToString());
                    }
                    else ChkInActive.Checked = false;
                    if (!string.IsNullOrEmpty(dt.Rows[0]["DebitLimit"].ToString()))
                    {
                        txtDebitLimit.Text = decimal.Parse(dt.Rows[0]["DebitLimit"].ToString()).ToString("G29");
                    }
                    else txtDebitLimit.Text = string.Empty;

                    if (!string.IsNullOrEmpty(dt.Rows[0]["CreditLimit"].ToString()))
                    {
                        txtCreditLimit.Text = decimal.Parse(dt.Rows[0]["CreditLimit"].ToString()).ToString("G29");
                    }
                    else txtCreditLimit.Text = string.Empty;
                  //  ChkVendor.Checked = Convert.ToBoolean(dt.Rows[0]["PartyType"].ToString());
                   // ChkInActive.Checked = Convert.ToBoolean(dt.Rows[0]["InActive"].ToString());
                   // txtDueDays.Text = dt.Rows[0]["DueDays"].ToString();
                   // txtDebitLimit.Text = decimal.Parse(dt.Rows[0]["DebitLimit"].ToString()).ToString("G29");
                  //  txtCreditLimit.Text = decimal.Parse(dt.Rows[0]["CreditLimit"].ToString()).ToString("G29");
                    txtDescription.Text = dt.Rows[0]["Description"].ToString();// tag her jaga use na krain ... jaha es ki zarorat hai bs wahha , tag or text differ hain aik dosry sy
                    vOpenMode = true;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        #endregion


        #region // Buttons Click
        private void CmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void CmdOpen_Click(object sender, EventArgs e)
        {
            Grid.Enabled = true;
            TxtFilter.Enabled = true;
            CmbFilterTown.Enabled = true;
            CmbFilterSector.Enabled = true;
        }
        private void CmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!vOpenMode) return;

                DialogResult dMsg = MessageBox.Show("Are you Sure To Delete!!!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dMsg == DialogResult.No) return;

               
                if (!string.IsNullOrEmpty(TxtID.Tag.ToString()))
                {
                    var AccDAL = new DAL.ChartOfAccounts();
                    AccDAL.connectionstring = objDAL.connectionstring;


                    DAL.Parties obj = new DAL.Parties ();
                    obj.connectionstring = objDAL.connectionstring;
                    obj.DeleteRecord (Int32.Parse (TxtID.Tag.ToString()));
                }
             

                MessageBox.Show("Record Deleted Successfully.", "Task Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);              

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
        private void CmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Party Name.");
                    txtName.Focus();
                    return;
                }


                Objects.Parties obj = new Objects.Parties();
                obj.PartyID = TxtPrefix.Text + "" + TxtID.Text;
                obj.PartyName = txtName.Text.Trim();
                obj.Phone1 = txtPhone1.Text.Trim();
                obj.Phone2  = txtPhone2.Text.Trim();
                obj.City = TxtCity.Text.Trim();
                obj.Address = TxtAddress.Text.Trim();
                obj.EMail = txtEmail.Text.Trim();
                int vDueDays;
                int.TryParse(txtDueDays.Text,  out vDueDays);

                obj.DueDays = vDueDays;
                int vDiscRatio;
                int.TryParse(txtDiscRatio.Text, out vDiscRatio);

                obj.DiscRatio = vDiscRatio;
                obj.Description = txtDescription.Text.Trim();
                obj.ContactPerson = txtContactPerson.Text.Trim();
                obj.OfficeID = int.Parse (CmbOffice.SelectedValue.ToString());
                obj.SectorID = int.Parse (CmbSector.SelectedValue.ToString());
                obj.GroupID = int.Parse(CmbGroups.SelectedValue.ToString());// idher name likhain grou
                obj.Mobile = txtMobileNo.Text.Trim();
                obj.Fax = txtFax.Text.Trim();
                obj.InActive = ChkInActive.Checked;
              //  obj. = ChkVendor.Checked;
                if (ChkVendor.Checked == true)
                    obj.PartyType = "V"; 
                else
                   obj.PartyType = "C";
                        
                decimal vDebitLimit = 0;
                decimal vCreditLimit = 0;
                
                decimal.TryParse(this.txtDebitLimit.Text, out vDebitLimit);
                decimal.TryParse(this.txtCreditLimit.Text, out vCreditLimit);
                obj.CreditLimit = vCreditLimit;
                obj.DebitLimit = vDebitLimit;


                //Insert Account
                var AccDAL = new DAL.ChartOfAccounts();
                AccDAL.connectionstring = objDAL.connectionstring;
                Objects.ChartOfAccounts  objAcc = new Objects.ChartOfAccounts();
                if (!string.IsNullOrEmpty(TxtID.Tag.ToString()))
                objAcc.AccountNo = TxtID.Tag.ToString();
                objAcc.AccountName = obj.PartyName;
                objAcc.AccountType  = "Parties";
                objAcc.InActive  = true;
                objAcc.AccountDepth = 2;
                objAcc.AccountNameUrdu = txtNameUrdu.Text.Trim();
                objAcc.Narration = txtDescription.Text.Trim();
                objAcc.OfficeID =Int32.Parse( CmbOffice.SelectedValue.ToString());
                objAcc.OpeningDebit   = vDebitLimit;
                objAcc.OpeningCredit  = vCreditLimit;
                objAcc.ParentAccountNo = "62";
                
                objAcc.ResidualValue = decimal.Parse(vDueDays.ToString());
                objAcc.IsDetailed = false;
                objAcc.IsSold = false;
                objAcc.EntryDate = DateTime.Now;
                objAcc.AdjustedCredit = 0;
                objAcc.AdjustedDebit = 0;
                objAcc.BalFlag = false ;
                objAcc.ExpFlag = false;
                objAcc.IsEditable = false;
                objAcc.IsLocked = false;
                objAcc.IsPosted = false;

                decimal vDisRatio;
                decimal.TryParse(txtDiscRatio.Text, out vDisRatio);


                objAcc.Life = vDisRatio;
                objAcc.PLFlag =Convert.ToBoolean(obj.PayablesFlag).ToString();
                objAcc.UserNo = 1;

                   

                

                if (!vOpenMode)
                {
                    objAcc.AccountNo =  obj.PartyID; //objDAL.getNextNo().ToString();
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
               MessageBox.Show( exc.Message);
            }
        }
        #endregion

        private void CmbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

      
    }
}
