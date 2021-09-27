using System.Windows.Forms;

namespace BankingManagement
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {   
            InitializeComponent();
            InitializeData();
        }

        public void InitializeData()
        {
            barStaticItemEmployeeID.Caption = Program.EmployeeID;
            barStaticItemEmployeeName.Caption = Program.EmployeeName;
            barStaticItemGroupName.Caption = Program.GroupName;
        }

        private void barButtonItemLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Dispose();
            Program.loginForm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
