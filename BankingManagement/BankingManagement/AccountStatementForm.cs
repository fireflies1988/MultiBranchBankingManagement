using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace BankingManagement
{
    public partial class AccountStatementForm : DevExpress.XtraEditors.XtraForm
    {
        private const int CB_SETCUEBANNER = 0x1703;
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);

        public AccountStatementForm()
        {
            InitializeComponent();
        }

        private void LoadDataIntoAccountNumberComboBox()
        {
            this.taiKhoanTableAdapter.Fill(this.accountDataSet.TaiKhoan);

            // display cue message
            comboBoxAccountNumber.SelectedItem = null;
            SendMessage(this.comboBoxAccountNumber.Handle, CB_SETCUEBANNER, 0, "Vui lòng chọn một tài khoản");
        }

        private void AccountStatementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.GetConnectionString(Program.SubscriberName, Program.LoginName, Program.Password);
            LoadDataIntoAccountNumberComboBox();

            dateTimePickerFrom.Value = DateTime.Now;
            dateTimePickerTo.Value = DateTime.Now;
        }

        private void simpleButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadDataIntoAccountNumberComboBox();
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            if (comboBoxAccountNumber.SelectedItem == null)
            {   
                if (comboBoxAccountNumber.Text == "")
                {
                    MessageBox.Show(this, "Vui lòng chọn tài khoản để xem!", "Sao kê giao dịch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Số tài khoản bạn nhập không tồn tại, vui lòng chọn lại!", "Sao kê giao dịch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                comboBoxAccountNumber.Focus();
                return;
            }

            String accountNumber = comboBoxAccountNumber.Text;
            XtraReport_AccountStatementForAPeriodOfTime report =
                new XtraReport_AccountStatementForAPeriodOfTime(accountNumber, dateTimePickerFrom.Value, dateTimePickerTo.Value);
            report.xrLabelAccountNumber.Text = accountNumber;
            report.xrLabelFrom.Text = dateTimePickerFrom.Text;
            report.xrLabelTo.Text = dateTimePickerTo.Text;
            ReportPrintTool rpt = new ReportPrintTool(report);
            rpt.ShowPreviewDialog();
        }
    }
}