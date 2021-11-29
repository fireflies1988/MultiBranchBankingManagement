using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankingManagement
{
    public partial class OpenAccountForm : DevExpress.XtraEditors.XtraForm
    {
        public OpenAccountForm()
        {
            InitializeComponent();
        }

        private void OpenAccountForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Connection.ConnectionString = Program.GetConnectionString(Program.Subscriber3, Program.RemoteLoginName, Program.RemotePassword);
            this.khachHangTableAdapter.Fill(this.accountDataSet.KhachHang);

            // TODO: This line of code loads data into the 'accountDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.GetConnectionString(Program.SubscriberName, Program.LoginName, Program.Password);
            this.taiKhoanTableAdapter.Fill(this.accountDataSet.TaiKhoan);

            dateTimePickerOpenDate.Value = DateTime.Now;
        }

        private void RefreshDataSet()
        {
            this.khachHangTableAdapter.Fill(this.accountDataSet.KhachHang);
            this.taiKhoanTableAdapter.Fill(this.accountDataSet.TaiKhoan);
        }

        // for opening an account
        private void ChangeFormAppearance(bool inProcessOfOpeningAccount)
        {
            khachHangGridControl.Enabled = !inProcessOfOpeningAccount;
            groupControlAccountInfo.Visible = inProcessOfOpeningAccount;
            barButtonItemOpenAccount.Enabled = barButtonItemRefresh.Enabled = !inProcessOfOpeningAccount;
            if (inProcessOfOpeningAccount)
            {
                barButtonItemFinish.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                barButtonItemCancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                barButtonItemFinish.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItemCancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }

        private void barButtonItemOpenAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangeFormAppearance(true);
            taiKhoanBindingSource.AddNew();
            textBoxBranchID.Text = Program.BranchID;
            textBoxCMND.Text = ((DataRowView)khachHangBindingSource.Current)["CMND"].ToString();
            dateTimePickerOpenDate.Value = DateTime.Now;
        }

        private void barButtonItemCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChangeFormAppearance(false);
            taiKhoanBindingSource.CancelEdit();
        }

        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshDataSet();
        }

        private void barButtonItemFinish_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxAccountNumber.Text) || String.IsNullOrWhiteSpace(textBoxBalance.Text))
            {
                MessageBox.Show(this, "Các trường bắt buộc không được bỏ trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            // !!!!!!!!!!!!!!!!!!!!!!!!! input number only
            try
            {
                using (SqlConnection connection = Program.GetConnectionToSubsciber())
                {
                    int returnValue = (int)Program.GetSPReturnValue(connection, "sp_TaiKhoan_CheckExists", "@SOTK", textBoxAccountNumber.Text);
                    if (returnValue == 1)
                    {
                        MessageBox.Show(this, "Số tài khoản này đã tồn tại!", "Mở tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Validate();
                taiKhoanBindingSource.EndEdit();
                taiKhoanTableAdapter.Update(accountDataSet.TaiKhoan);
                this.taiKhoanTableAdapter.Fill(this.accountDataSet.TaiKhoan);
                MessageBox.Show(this, "Mở tài khoản mới thành công.", "Mở tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ChangeFormAppearance(false);
        }
    }
}