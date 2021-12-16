using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankingManagement
{
    public partial class AccountForm : DevExpress.XtraEditors.XtraForm
    {
        private Stack<String> undoList = new Stack<string>();

        public AccountForm()
        {
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountDataSet.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.GetConnectionString(Program.SubscriberName, Program.LoginName, Program.Password);
            this.taiKhoanTableAdapter.Fill(this.accountDataSet.TaiKhoan);

            // give employees belonging to ChiNhanh group permission to edit data
            if (Program.GroupName == "NganHang")
            {
                barButtonItemDelete.Enabled = false;
            }
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // no rows selected
            if (gridViewAccount.SelectedRowsCount == 0) return;

            String accountNumber = gridViewAccount.GetRowCellValue(gridViewAccount.FocusedRowHandle, "SOTK").ToString();
            String idNumber = gridViewAccount.GetRowCellValue(gridViewAccount.FocusedRowHandle, "CMND").ToString();
            String balance = gridViewAccount.GetRowCellValue(gridViewAccount.FocusedRowHandle, "SODU").ToString();
            String branchId = gridViewAccount.GetRowCellValue(gridViewAccount.FocusedRowHandle, "MACN").ToString();
            String openDate = gridViewAccount.GetRowCellValue(gridViewAccount.FocusedRowHandle, "NGAYMOTK").ToString();

            // check if this account have any transactions, if it does, not allow to delete
            try
            {
                using (SqlConnection connection = Program.GetConnectionToSubsciber())
                {
                    int returnValue = (int)Program.GetSPReturnValue(connection, "sp_TaiKhoan_CanDelete", "@SOTK", accountNumber);
                    if (returnValue == 0)
                    {
                        MessageBox.Show(this, "Không thể xóa tài khoản này vì có ràng buộc với các giao dịch.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // confirm delete
            if (MessageBox.Show(this, "Bạn có chắc muốn xóa tài khoản này?", "Xóa tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    // for undo purpose
                    String accountInfo = accountNumber + "#" + idNumber + "#" + balance + "#" + branchId + "#" + openDate;

                    taiKhoanBindingSource.RemoveCurrent();
                    Validate();
                    taiKhoanBindingSource.EndEdit();
                    taiKhoanTableAdapter.Update(accountDataSet.TaiKhoan);

                    // if delete was successful, enable undo button
                    barButtonItemUndo.Enabled = true;
                    undoList.Push(accountInfo);
                    undoList.Push("DELETE");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Xóa tài khoản không thành công!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (taiKhoanBindingSource.Count == 0)
            {
                barButtonItemDelete.Enabled = false;
            }
        }

        private void barButtonItemUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (undoList.Count > 0)
            {
                String statement = undoList.Pop();
                if (statement == "DELETE")
                {
                    String accountInfo = undoList.Pop();
                    String[] tokens = accountInfo.Split('#');
                    taiKhoanTableAdapter.Insert(tokens[0], tokens[1], decimal.Parse(tokens[2]), tokens[3], DateTime.Parse(tokens[4]));
                    this.taiKhoanTableAdapter.Fill(this.accountDataSet.TaiKhoan);
                    taiKhoanBindingSource.Position = taiKhoanBindingSource.Find("SOTK", tokens[0]);
                }
            }
            if (undoList.Count == 0) barButtonItemUndo.Enabled = false;
        }

        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.taiKhoanTableAdapter.Fill(this.accountDataSet.TaiKhoan);
        }
    }
}