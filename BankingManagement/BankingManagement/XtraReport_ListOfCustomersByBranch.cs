using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace BankingManagement
{
    public partial class XtraReport_ListOfCustomersByBranch : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_ListOfCustomersByBranch()
        {
            InitializeComponent();
        }

        public XtraReport_ListOfCustomersByBranch(String branchID)
        {
            InitializeComponent();
            sqlDataSourceListOfCustomersByBranch.Connection.ConnectionString = Program.GetConnectionString(Program.SubscriberName, Program.LoginName, Program.Password);
            sqlDataSourceListOfCustomersByBranch.Queries[0].Parameters[0].Value = branchID;
            sqlDataSourceListOfCustomersByBranch.Fill();
        }
    }
}
