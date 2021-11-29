using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace BankingManagement
{
    public partial class XtraReport_AccountStatementForAPeriodOfTime : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport_AccountStatementForAPeriodOfTime()
        {
            InitializeComponent();
        }

        public XtraReport_AccountStatementForAPeriodOfTime(String accountNumber, DateTime from, DateTime to)
        {
            InitializeComponent();
            sqlDataSourceAccountStatement.Connection.ConnectionString = Program.GetConnectionString(Program.SubscriberName, Program.LoginName, Program.Password);
            sqlDataSourceAccountStatement.Queries[0].Parameters[0].Value = accountNumber;
            sqlDataSourceAccountStatement.Queries[0].Parameters[1].Value = from;
            sqlDataSourceAccountStatement.Queries[0].Parameters[2].Value = to;
            sqlDataSourceAccountStatement.Fill();
        }
    }
}
