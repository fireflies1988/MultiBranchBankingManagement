using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BankingManagement
{
    public partial class ListOfCustomersByBranchForm : DevExpress.XtraEditors.XtraForm
    {
        public ListOfCustomersByBranchForm()
        {
            InitializeComponent();
        }

        private void ListOfCustomersByBranchForm_Load(object sender, EventArgs e)
        {
            Dictionary<String, String> source = new Dictionary<string, string>();
            source.Add("BENTHANH", "Chi nhánh Bến Thành");
            source.Add("TANDINH", "Chi nhánh Tân Định");
            comboBoxBranch.DataSource = new BindingSource(source, null);
            comboBoxBranch.DisplayMember = "Value";
            comboBoxBranch.ValueMember = "Key";
            comboBoxBranch.SelectedIndex = Program.SelectedBranchIndex;

            if (Program.GroupName == "ChiNhanh")
            {
                comboBoxBranch.Enabled = false;
            }
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            XtraReport_ListOfCustomersByBranch report = new XtraReport_ListOfCustomersByBranch(comboBoxBranch.SelectedValue.ToString());
            report.xrLabelBranch.Text = ((KeyValuePair<String, String>)comboBoxBranch.SelectedItem).Value;
            ReportPrintTool rpt = new ReportPrintTool(report);
            rpt.ShowPreviewDialog();
        }
    }
}