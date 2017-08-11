using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraBiz
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void saleReturnReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profitReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void activityReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mniOffices_Click(object sender, EventArgs e)
        {
            Form vForm = new Defination.DefOffices();            
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniTowns_Click(object sender, EventArgs e)
        {
            Form vForm = new Defination.DefTowns();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniSectors_Click(object sender, EventArgs e)
        {           
                Form vForm = new Defination.DefSectors();
                vForm.StartPosition = FormStartPosition.CenterScreen;
                vForm.Show();        
        }

        private void mniOfficeSectors_Click(object sender, EventArgs e)
        {
            Form vForm = new Defination.DefOfficeSectors ();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show(); 
        }

        private void mniCompanies_Click(object sender, EventArgs e)
        {
            Form vForm = new Defination.DefCompanies();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniCompanyGroups_Click(object sender, EventArgs e)
        {
            Form vForm = new Defination.DefGroups();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniProducts_Click(object sender, EventArgs e)
        {
            Form vForm = new Defination.DefProducts();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mntTradesOffers_Click(object sender, EventArgs e)
        {
            Form vForm = new Defination.FrmTradeOffers();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniSalesmenSectors_Click(object sender, EventArgs e)
        {
            Form vForm = new Defination.DefSalesmanSectors();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniOpeningStock_Click(object sender, EventArgs e)
        {
            Form vForm = new Defination.OpeningStock();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniProductBarCodes_Click(object sender, EventArgs e)
        {
            Form vForm = new Defination.DefProductBarcodes();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniTransports_Click(object sender, EventArgs e)
        {
            Form vForm = new Defination.DefTransport();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniPartyGroups_Click(object sender, EventArgs e)
        {
            Form vForm = new Defination.DefPartyGroups();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniVendors_Click(object sender, EventArgs e)
        {
            Form vForm = new Defination.DefVendors();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniCustomers_Click(object sender, EventArgs e)
        {
            Form vForm = new Defination.DefParties ();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniSalesmen_Click(object sender, EventArgs e)
        {
            Form vForm = new Defination.DefSalesmen();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniDefineFormula_Click(object sender, EventArgs e)
        {
            Form vForm = new Defination.FrmDefineFormula();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniCompanyDiscounts_Click(object sender, EventArgs e)
        {
            Form vForm = new Defination.DefCompanyDiscounts();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniPackings_Click(object sender, EventArgs e)
        {
            Form vForm = new Defination.DefPackings();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniSalesRegister_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptSalesRegisterIW ();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniSalesSummary_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptSalesSummary();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniProductWiseSaleWnp_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptProductWiseSaleWnp();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniProductWiseSale_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptProductWiseSales();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniCompanyWiseSales_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptCompanyWiseSale();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniProductSaleLedger_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptSalesLedger();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniProductSaleLedgerSteel_Click(object sender, EventArgs e)
        {

            Form vForm = new Reports.pmtSalesLedgrSteel();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniSalesAndStockStatements_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptSalesStockStatement();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniPrintInvoiceinbatch_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptPrintInvoiceBatch();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniPartyReceivablesAdvance_Click(object sender, EventArgs e)
        {

            Form vForm = new Reports.RptPartyReceivablesAdvance();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniPartyReceivablesAdvanceSummary_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptPartyReceivablesAdvanceSummary();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mnuRptWastageInvoice_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.pmtWastageInvoiceReport();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniPartyBalances_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptPartyBalnances();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniCompanySaleRecovery_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptCompanySaleRecovery();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniUserSalesSummary_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptUserSaleSummary();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniSaleReturnRegister_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptSalesReturnRegisterIW();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniSaleReturnSummary_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptSaleReturnSummary();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniProductSaleReturnLedger_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptSaleReturnLedger();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mneCompanywiseprofits_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptCompanyWiseProfit();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mneCustomerWiseProfits_Click(object sender, EventArgs e)
        {

            Form vForm = new Reports.RptCustomerWiseProfit();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mneDailyProfits_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptDailyDetailedProfits();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mneInvoiceDetailedProfits_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptInvoiceDetailedProfit();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mneInvoiceWiseProfits_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptInvoiceWiseProfit();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mneProductWiseProfits_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptProductWiseProfits();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniSalesmanSummary_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptSalesmanSummary();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniSalesmanMonthlyPerfomance_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptSalesmanMonthlyPerfomance();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniSalesmanCommision_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptSalesmanCommision();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniSalesmanStockStatement_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptSalesmanStockStatement();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniDailySaleStatement_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptDailySaleSheet();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mnrSalesmanRecoveryRegister_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptSalesmanRecoveryRegister();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniPurchaseRegisterDW_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.pmtPurchaseRegisterDW();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniPurchaseRegisterIW_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.pmtPurchaseRegisterIW();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniPurchaseSummary_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.pmtPurchaseSummary();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniProductPurchaseLedger_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.pmtPurchaseLedger();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniProductWisePurchase_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptProductWisePurchases();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniPurchaseReturnRegister_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.pmtPurchaseReturnRegister();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniPurchaseReturnSummary_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.pmtPurchaseReturnSummary();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniProductPurReturnLedger_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.pmtPurchaseReturnLedger();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniCurrentStock_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.pmtCurrentStock();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniOpeningStockRpt_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.pmtOpeningStock();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniSMCurrentStockRpt_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.pmtSMCurrentStock();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniStockIssueRegister_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptStockIssueRegister();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniStockReturnRegister_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptStockReturnRegister();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniTownsList_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.pmtOnlyTownsList();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniSectorsList_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.pmtOnlySectorsList();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniSalesmanSectorsList_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.pmtSalesmanSectorList();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniOnlyPartyList_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.pmtOnlyPartyList();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniPartyList_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.pmtPartyListdetailed();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniStockCountSheet_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptStockCountSheet();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniProductPriceList_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptProductPriceList();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniBarCodePrinting_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptBarCodePrinting();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniCompanyWiseProductList_Click(object sender, EventArgs e)
        {
            Form vForm = new Reports.RptCompanyWiseProductList();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniPromises_Click(object sender, EventArgs e)
        {
            Form vForm = new Defination.frmPromises();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniPurchaseOrder_Click(object sender, EventArgs e)
        {
            Form vForm = new Invoicing.PurchaseOrder();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniPurchaseInvoice_Click(object sender, EventArgs e)
        {
            Form vForm = new Invoicing.PurchaseInvoice();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniPurchaseInvoiceSizeWise_Click(object sender, EventArgs e)
        {
            Form vForm = new Invoicing.PurchaseSizewise();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniCompanyDiscountCustomerWise_Click(object sender, EventArgs e)
        {
            Form vForm = new Invoicing.FrmCompanyDiscountCustomerWise();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniExceedInvoice_Click(object sender, EventArgs e)
        {
            Form vForm = new Invoicing.FrmExceedInvoice();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniPurchaseReturnInvoice_Click(object sender, EventArgs e)
        {
            Form vForm = new Invoicing.PurchaseReturnInvoice();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mniStockIssue_Click(object sender, EventArgs e)
        {
            Form vForm = new Invoicing.StockIssue();
            vForm.StartPosition = FormStartPosition.CenterScreen;
            vForm.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
