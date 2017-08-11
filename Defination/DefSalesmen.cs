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
    public partial class DefSalesmen : Form
    {

        DAL.Salesmen objDAL = new DAL.Salesmen();


        string vConnectionString = ConfigurationManager.ConnectionStrings["MyString"].ConnectionString.ToString();

        bool vOpenMode = false;

        public DefSalesmen()
        {
            InitializeComponent();
        }
        private void DefSalesmen_Load(object sender, EventArgs e)
        {

            objDAL.connectionstring = vConnectionString;

            TxtID.Text = objDAL.getNextNo().ToString();
            TxtPrefix.Text = "63";
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
                CmdClear_Click_1(null, null);
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

               // TxtID.Text = string.Empty;
                TxtID.Tag = string.Empty;
                TxtName.Text = string.Empty;
                TxtName.Tag = string.Empty;
                TxtAddress.Text = string.Empty;
                TxtAddress.Tag = string.Empty;
                TxtCity.Text = string.Empty;
                TxtCity.Tag = string.Empty;
                txtPhone1.Text = string.Empty;
                txtPhone1.Tag = string.Empty;
                txtMobileNo.Text = string.Empty;
                txtNIC.Text = string.Empty;
                txtCommisionRatio.Text = string.Empty;
                vOpenMode = false;
                Grid.Enabled = false;
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
                        vWhere = " AND Salemen.SalesmanName Like '%" + TxtFilter.Text + "%'";
                    }
                
                    


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
                    
                    string vID = Grid.Rows[Grid.CurrentRow.Index].Cells["SalesmanID"].Value.ToString();
                    TxtPrefix.Text = vID.Substring(0, 2);

                    TxtID.Text = vID.Substring(2);

                    DataTable dt = objDAL.getRecord(" AND SalesmanID=" + vID);
                   // TxtID.Tag = dt.Rows[0]["SalesmanID"].ToString();
                    TxtName.Text = dt.Rows[0]["SalesmanName"].ToString();
                    TxtAddress.Text = dt.Rows[0]["Address"].ToString();
                    TxtCity.Text = dt.Rows[0]["City"].ToString();
                    txtPhone1.Text = dt.Rows[0]["Phone"].ToString();  
                    txtMobileNo.Text = dt.Rows[0]["Mobile"].ToString();
                    txtNIC.Text = dt.Rows[0]["NIC"].ToString();
                 //   txtCommisionRatio.Tag = dt.Rows[0]["CommissionRatio"].ToString();
                    if (!string.IsNullOrEmpty(dt.Rows[0]["CommissionRatio"].ToString()))
                    {
                        txtCommisionRatio.Text = decimal.Parse(dt.Rows[0]["CommissionRatio"].ToString()).ToString("G29");
                    }
                    else txtCommisionRatio.Text = string.Empty;
                    txtDesignation.Tag = dt.Rows[0]["Designation"].ToString();

                    if (!string.IsNullOrEmpty(dt.Rows[0]["OfficeID"].ToString()))
                    {
                        CmbOffice.SelectedValue = dt.Rows[0]["OfficeID"].ToString();
                        //CmbOffice.SelectedText = dt.Rows[0]["Description"].ToString();
                    }
                    else
                        CmbOffice.SelectedIndex = -1;
                   
                  //  ChkInActive.Checked = Convert.ToBoolean(dt.Rows[0]["InActive"].ToString());
                    if (!string.IsNullOrEmpty(dt.Rows[0]["IsStockHolder"].ToString()))
                    {
                        chkStockHolder.Checked = Convert.ToBoolean(dt.Rows[0]["IsStockHolder"].ToString());
                    }
                    else chkStockHolder.Checked = false;

                    if (!string.IsNullOrEmpty(dt.Rows[0]["IsStaff"].ToString()))
                    {
                        chkStaff.Checked = Convert.ToBoolean(dt.Rows[0]["IsStaff"].ToString());
                    }
                    else chkStaff.Checked = false;
                  

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


                Objects.Salesmen obj = new Objects.Salesmen();
                obj.SalesmanID = TxtPrefix.Text+" "+TxtID.Text;
                obj.SalesmanName = TxtName.Text.Trim();
                obj.Address = TxtAddress.Text.Trim();
                obj.Phone = txtPhone1.Text.Trim();
                obj.City = TxtCity.Text.Trim();
                obj.Mobile = txtMobileNo.Text.Trim();
                obj.NIC = txtNIC.Text.Trim();
               // obj.CommissionRatio = decimal.Parse(txtCommisionRatio.Text.ToString());
                int vCommRatio;
                int.TryParse(txtCommisionRatio.Text, out vCommRatio);

                obj.CommissionRatio = vCommRatio;
                obj.IsStockHolder = chkStockHolder.Checked;
                obj.IsStaff = chkStaff.Checked;
                obj.OfficeID = int.Parse(CmbOffice.SelectedValue.ToString());
                obj.Designation = txtDesignation.Text.Trim();

               // decimal vOpDebit = 0;
                //decimal vOpCredit = 0;

                //Insert Account
                var AccDAL = new DAL.ChartOfAccounts();
                AccDAL.connectionstring = objDAL.connectionstring;
                Objects.ChartOfAccounts objAcc = new Objects.ChartOfAccounts();

               // if (!string.IsNullOrEmpty(TxtID.Tag.ToString()))
                    objAcc.AccountNo = obj.SalesmanID;
                objAcc.AccountName = obj.SalesmanName;
                objAcc.AccountType = "Parties";
                objAcc.InActive = true;
                objAcc.AccountDepth = 1;
                objAcc.AccountNameUrdu = "";
                objAcc.Narration = "";
                objAcc.OfficeID = Int32.Parse(CmbOffice.SelectedValue.ToString());
                objAcc.OpeningDebit = 0;
                objAcc.OpeningCredit = 0;
                objAcc.ParentAccountNo = "63";

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

               decimal vCommissionRatio;
               decimal.TryParse(txtCommisionRatio.Text, out vCommissionRatio);


               objAcc.Life = vCommissionRatio;
                objAcc.PLFlag = "";
                objAcc.UserNo = 1;


                if (!vOpenMode)
                {
                    objAcc.AccountNo = obj.SalesmanID; //objDAL.getNextNo().ToString();
                    AccDAL.InsertRecord(objAcc);
                    objDAL.InsertRecord(obj);
                }
                else
                {
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


        private void CmdClear_Click_1(object sender, EventArgs e)
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

       }
        #endregion


     

 }

