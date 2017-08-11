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

namespace Invoicing
{
    public partial class PurchaseOrder : Form
    {

        DAL.PurOrder objDAL = new DAL.PurOrder();

        public PurchaseOrder()
        {
            InitializeComponent();
        }
        private void CmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            // LoadGrid Aik funtion hai to bnaya he nai howa . es liye nai use kr sakty es ko .. na he zarorat hai 

            //LoadGrid(CmbCompany.SelectedValue.ToString());
        }
        private void TxtCustomerID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCustomerID.Text)) TxtCustomerName.Text = string.Empty;
            else
            {
                string vWhere = string.Empty;
                vWhere = "AND Parties.PartyID = " + TxtCustomerID.Text;
                DAL.Parties obj = new DAL.Parties();

                obj.connectionstring = objDAL.connectionstring; //System.Configuration.ConfigurationSettings.GetConfig(string).ConnectionStrings["MyString"].ConnectionString;
                //DataTable dt = obj.getParties(vWhere);
                DataTable dt = obj.getRecord(vWhere);

                if (dt.Rows.Count > 0)
                {
                    TxtCustomerID.Text = dt.Rows[0]["PartyID"].ToString(); // vForm.MyID;
                    TxtCustomerName.Text = dt.Rows[0]["PartyName"].ToString();// vForm.MyName;

                }
            }
        }
        private void txtCustomer_KeyDown(object sender, KeyEventArgs e)
        {

            // esi code ko follow kr lian 

            if (e.KeyCode == Keys.F1)
            {
              //  Search.SchParties vForm = new Search.SchParties();
             //   vForm.IsVendor = true;
             //   vForm.IsCustomer = false;
             //   vForm.ShowDialog();
             //   if (!string.IsNullOrEmpty(vForm.MyID))
                {
               //     TxtCustomerID.Text = vForm.MyID;
                //    TxtCustomerName.Text = vForm.MyName;
                    // Txt_ProductID.Focus();
                }
            }
            else
            {
                // ye bhi aik funtion hai pahly es ko create kr lain

                //GoToNextCont(sender, e);
            }
        }
        private void txtVendor_KeyDown(object sender, KeyEventArgs e)
        {

            // esi code ko follow kr lian 

            if (e.KeyCode == Keys.F1)
            {
                //Search.SchParties vForm = new Search.SchParties();
              //  vForm.IsVendor = true;
              //  vForm.IsCustomer = false;
             //   vForm.ShowDialog();
             //   if (!string.IsNullOrEmpty(vForm.MyID))
                {
               //     TxtVendorID.Text = vForm.MyID;
               //     TxtVendorName.Text = vForm.MyName;
                    // Txt_ProductID.Focus();
                }
            }
            else
            {


                GoToNextCont(sender, e);
            }
        }

        private void GoToNextCont(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void txtVendorID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtVendorID.Text)) TxtVendorName.Text = string.Empty;
            else
            {
                string vWhere = string.Empty;
                vWhere = "AND Parties.PartyID = " + TxtVendorID.Text;
                DAL.Parties  obj = new DAL.Parties ();

                obj.connectionstring = objDAL.connectionstring; //System.Configuration.ConfigurationSettings.GetConfig(string).ConnectionStrings["MyString"].ConnectionString;
                //DataTable dt = obj.getParties(vWhere);
                DataTable dt = obj.getRecord(vWhere);

                if (dt.Rows.Count > 0)
                {
                    TxtVendorID.Text = dt.Rows[0]["PartyID"].ToString(); // vForm.MyID;
                    TxtVendorName.Text = dt.Rows[0]["PartyName"].ToString();// vForm.MyName;

                }
            }
        }
        private void CmbOffice_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadGrid(CmbOffice.SelectedValue.ToString());
        }
        private void txtSalesmenID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtSMID.Text)) TxtSMName.Text = string.Empty;
            else
            {
                string vWhere = string.Empty;
                vWhere = "AND Parties.PartyID = " + TxtVendorID.Text;
                DAL.Parties  obj = new DAL.Parties ();

                obj.connectionstring = objDAL.connectionstring; //System.Configuration.ConfigurationSettings.GetConfig(string).ConnectionStrings["MyString"].ConnectionString;
                //DataTable dt = obj.getParties(vWhere);
                DataTable dt = obj.getRecord(vWhere);

                if (dt.Rows.Count > 0)
                {
                    TxtSMID.Text = dt.Rows[0]["PartyID"].ToString(); // vForm.MyID;
                    TxtSMName.Text = dt.Rows[0]["PartyName"].ToString();// vForm.MyName;

                }

            }
        }
        private void txtSalesmen_KeyDown(object sender, KeyEventArgs e)
        {

            // esi code ko follow kr lian 

            if (e.KeyCode == Keys.F1)
            {
                //Search.SchParties vForm = new Search.SchParties();
               // vForm.IsVendor = true;
               // vForm.IsCustomer = false;
              //  vForm.ShowDialog();
              //  if (!string.IsNullOrEmpty(vForm.MyID))
                {
            //        TxtSMID.Text = vForm.MyID;
              //      TxtSMName.Text = vForm.MyName;
             //       //Txt_ProductID.Focus();
                }
            }
            else
            {
                GoToNextCont(sender, e);
            }
        }

        
             private void txt_ProductID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtProductID.Text))
            {
               // ClearBodyControls();
            }
            else
            {
             
                string vWhere = string.Empty;
                vWhere = "AND Products.ProductID = " + TxtProductID.Text;
                DAL.PurOrder  obj = new DAL.PurOrder();
                obj.connectionstring = "";// System.Configuration.ConfigurationManager.ConnectionStrings["MyString"].ConnectionString;
                DataTable dt = obj.getRecord(vWhere);

                if(dt.Rows.Count > 0)
                {
                    TxtProductID.Text = dt.Rows[0]["ProductID"].ToString(); // vForm.MyID;
                    TxtProductName.Text = dt.Rows[0]["ProductName"].ToString();// vForm.MyName;
                    TxtPack.Text = dt.Rows[0]["UnitTitle"].ToString(); //vForm.MyUnitName;
                    TxtPack.Tag = dt.Rows[0]["UnitID"].ToString(); //vForm.MyUnitID.ToString();
                    TxtQty.Tag = dt.Rows[0]["Units"].ToString(); //vForm.MyMultiplier.ToString("G29");
                    TxtPrice.Text = decimal.Parse( dt.Rows[0]["PurchasePrice"].ToString()).ToString("G29"); //Math.Round(vForm.MyPurPrice, 2).ToString("G29");
                    //txt_Qty.Focus();
                }
               

            }               
        }

             private void PurchaseOrder_Load(object sender, EventArgs e)
             {

             }

    }
}

