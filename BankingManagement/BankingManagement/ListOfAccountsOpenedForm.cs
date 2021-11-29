using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BankingManagement
{
    public partial class ListOfAccountsOpenedForm : DevExpress.XtraEditors.XtraForm
    {
        public ListOfAccountsOpenedForm()
        {
            InitializeComponent();
        }

        private void ListOfAccountsOpenedForm_Load(object sender, EventArgs e)
        {
            Dictionary<String, String> source = new Dictionary<string, string>();
            source.Add("BENTHANH", "Chi nhánh Bến Thành");
            source.Add("TANDINH", "Chi nhánh Tân Định");
            source.Add("", "Tất cả các chi nhánh");
            comboBoxBranch.DataSource = new BindingSource(source, null);
            comboBoxBranch.DisplayMember = "Value";
            comboBoxBranch.ValueMember = "Key";
            comboBoxBranch.SelectedIndex = Program.SelectedBranchIndex;

            dateTimePickerFrom.Value = DateTime.Now;
            dateTimePickerTo.Value = DateTime.Now;

            if (Program.GroupName == "ChiNhanh")
            {
                comboBoxBranch.Enabled = false;
            }
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            String branchID = comboBoxBranch.SelectedValue.ToString();
            XtraReport_ListOfAccountsOpenedForAPeriodOfTime report;
            if (!branchID.Equals(""))
            {
                report = new XtraReport_ListOfAccountsOpenedForAPeriodOfTime(branchID, dateTimePickerFrom.Value, dateTimePickerTo.Value);
            }
            else
            {
                report = new XtraReport_ListOfAccountsOpenedForAPeriodOfTime(dateTimePickerFrom.Value, dateTimePickerTo.Value);
            }
            report.xrLabelBranch.Text = ((KeyValuePair<String, String>)comboBoxBranch.SelectedItem).Value;
            report.xrLabelFrom.Text = dateTimePickerFrom.Text;
            report.xrLabelTo.Text = dateTimePickerTo.Text;
            ReportPrintTool rpt = new ReportPrintTool(report);
            rpt.ShowPreviewDialog();
        }
    }
}