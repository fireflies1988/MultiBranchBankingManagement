using System;
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
            if (Program.GroupName == "NganHang")
            {
                ribbonPageTransaction.Visible = false;
            }
            try
            {
                Program.BranchID = Program.GetBranchID();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private Form CheckExists(Type formType)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == formType)
                {
                    return f;
                }
            }
            return null;
        }

        private void barButtonItemEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(EmployeeForm));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                f = new EmployeeForm();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItemCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(CustomerForm));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                f = new CustomerForm();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItemOpenAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(OpenAccountForm));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                f = new OpenAccountForm();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
