using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace BankingManagement
{
    public partial class XtraReport_ListOfAccountsOpenedForAPeriodOfTime : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_ListOfAccountsOpenedForAPeriodOfTime()
        {
            InitializeComponent();
        }

        public XtraReport_ListOfAccountsOpenedForAPeriodOfTime(DateTime from, DateTime to)
        {
            InitializeComponent();
            sqlDataSourceListOfAccountsOpened.Connection.ConnectionString = Program.GetConnectionString(Program.SubscriberName, Program.LoginName, Program.Password);
            sqlDataSourceListOfAccountsOpened.Queries[0].Parameters[1].Value = from;
            sqlDataSourceListOfAccountsOpened.Queries[0].Parameters[2].Value = to;
            sqlDataSourceListOfAccountsOpened.Fill();
        }

        public XtraReport_ListOfAccountsOpenedForAPeriodOfTime(String branchID, DateTime from, DateTime to)
        {
            InitializeComponent();
            sqlDataSourceListOfAccountsOpened.Connection.ConnectionString = Program.GetConnectionString(Program.SubscriberName, Program.LoginName, Program.Password);
            sqlDataSourceListOfAccountsOpened.Queries[0].Parameters[0].Value = branchID;
            sqlDataSourceListOfAccountsOpened.Queries[0].Parameters[1].Value = from;
            sqlDataSourceListOfAccountsOpened.Queries[0].Parameters[2].Value = to;
            sqlDataSourceListOfAccountsOpened.Fill();
        }
    }
}
