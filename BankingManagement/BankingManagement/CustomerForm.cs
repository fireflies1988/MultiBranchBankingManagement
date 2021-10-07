using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingManagement
{
    public partial class CustomerForm : DevExpress.XtraEditors.XtraForm
    {
        private Stack<String> undoList = new Stack<string>();
        /// <summary>
        /// Store the index of the item before adding or editing for cancel, undo purpose.
        /// </summary>
        private int position;
        /// <summary>
        /// Used to check what action is being performed, Add or Edit?
        /// </summary>
        private String originalCMND;
        private String oldCustomerInfo;
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void FillDataSet(String connectionString)
        {
            this.khachHangTableAdapter.Connection.ConnectionString = connectionString;
            this.khachHangTableAdapter.Fill(this.customerDataSet.KhachHang);
        }

        private void RefreshDataSet()
        {
            this.khachHangTableAdapter.Fill(this.customerDataSet.KhachHang);
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDataSet.KhachHang' table. You can move, or remove it, as needed.
            FillDataSet(Program.GetConnectionString(Program.SubscriberName, Program.LoginName, Program.Password));

            // load data into branch comboBox
            // remove the eventHandler for the selectedIndexchanged to prevent it from being fired when comboBoxBranch datasource is bound for the first time
            comboBoxBranch.SelectedIndexChanged -= new EventHandler(comboBoxBranch_SelectedIndexChanged);
            comboBoxBranch.DataSource = Program.Subscribers;
            comboBoxBranch.DisplayMember = "TENCN";
            comboBoxBranch.ValueMember = "TENSERVER";
            comboBoxBranch.SelectedIndex = Program.SelectedBranchIndex;
            comboBoxBranch.SelectedIndexChanged += new EventHandler(comboBoxBranch_SelectedIndexChanged);

            // give employees belonging to ChiNhanh group permission to edit data
            if (Program.GroupName == "NganHang")
            {
                barButtonItemAdd.Enabled = barButtonItemModify.Enabled = barButtonItemDelete.Enabled = false;
                barButtonItemUndo.Enabled = barButtonItemSave.Enabled = false;
            }
            else
            {
                comboBoxBranch.Enabled = false;
            }
        }

        // for adding and editing only
        private void ChangeFormAppearanceWhenAddingOrEditing(bool isBeingAddingOrEditing)
        {
            khachHangGridControl.Enabled = !isBeingAddingOrEditing;
            groupControlInformation.Enabled = isBeingAddingOrEditing;
            barButtonItemAdd.Enabled = barButtonItemModify.Enabled = barButtonItemDelete.Enabled = !isBeingAddingOrEditing;
            barButtonItemUndo.Enabled = barButtonItemRefresh.Enabled = !isBeingAddingOrEditing;
            if (isBeingAddingOrEditing)
            {
                barButtonItemSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                barButtonItemCancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                barButtonItemSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItemCancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }

            if (barButtonItemDelete.Enabled && khachHangBindingSource.Count == 0)
            {
                barButtonItemDelete.Enabled = false;
            }

            if (barButtonItemUndo.Enabled && undoList.Count == 0)
            {
                barButtonItemUndo.Enabled = false;
            }
        }

        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshDataSet();
        }

        private void comboBoxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            String subscriberName = comboBoxBranch.SelectedValue.ToString();
            String connectionString;
            if (comboBoxBranch.SelectedIndex != Program.SelectedBranchIndex)
            {
                connectionString = Program.GetConnectionString(subscriberName, Program.RemoteLoginName, Program.RemotePassword);
            }
            else
            {
                connectionString = Program.GetConnectionString(subscriberName, Program.LoginName, Program.Password);
            }

            try
            {
                FillDataSet(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Không thể kết nối với cơ sở dữ liệu của chi nhánh khác!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxBranch.SelectedIndex = Program.SelectedBranchIndex;
            }
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = khachHangBindingSource.Position;
            khachHangBindingSource.AddNew();
            textBoxBranchID.Text = Program.BranchID;
            comboBoxSex.SelectedIndex = 0;
            comboBoxSex.Text = comboBoxSex.SelectedText;
            ChangeFormAppearanceWhenAddingOrEditing(true);

            originalCMND = textBoxCMND.Text;
        }

        private void barButtonItemModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            originalCMND = textBoxCMND.Text.TrimEnd();
            oldCustomerInfo = textBoxCMND.Text + "#" + textBoxFamilyName.Text + "#" +
                        textBoxName.Text + "#" + textBoxAddress.Text + "#" + comboBoxSex.Text + "#" + 
                        dateEditDateOfIssue.EditValue + "#" +
                        textBoxPhoneNumber.Text + "#" + textBoxBranchID.Text;

            ChangeFormAppearanceWhenAddingOrEditing(true);
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String cmnd = textBoxCMND.Text.TrimEnd();

            // check if this customer have any account, if it does, not allow to delete
            try
            {
                using (SqlConnection connection = Program.GetConnectionToSubsciber())
                {
                    int returnValue = (int)Program.GetSPReturnValue(connection, "sp_KhachHang_CanDelete", "@CMND", textBoxCMND.Text);
                    if (returnValue == 0)
                    {
                        MessageBox.Show(this, "Không thể xóa khách hàng này vì có ràng buộc với các tài khoản", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (MessageBox.Show(this, "Bạn có chắc muốn xóa khách hàng này?", "Xóa khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    // !!!!!!!!!!!!!!!!!!!!! remember to handle # sign
                    String customerInfo = cmnd + "#" + textBoxFamilyName.Text + "#" +
                        textBoxName.Text + "#" + textBoxAddress.Text + "#" + comboBoxSex.Text + "#" +
                        dateEditDateOfIssue.EditValue + "#" +
                        textBoxPhoneNumber.Text + "#" + textBoxBranchID.Text;

                    khachHangBindingSource.RemoveCurrent();
                    Validate();
                    khachHangBindingSource.EndEdit();
                    khachHangTableAdapter.Update(customerDataSet.KhachHang);

                    // if delete was successful, enable undo button
                    barButtonItemUndo.Enabled = true;
                    undoList.Push(customerInfo);
                    undoList.Push("DELETE");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Xóa khách hàng không thành công!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (khachHangBindingSource.Count == 0)
            {
                barButtonItemDelete.Enabled = false;
            }
        }

        private void barButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // !!!!!!!!!!!!! login account
            if (String.IsNullOrWhiteSpace(textBoxCMND.Text) || String.IsNullOrWhiteSpace(textBoxFamilyName.Text)
                || String.IsNullOrWhiteSpace(textBoxName.Text) || String.IsNullOrWhiteSpace(textBoxAddress.Text)
                || String.IsNullOrWhiteSpace(dateEditDateOfIssue.Text))
            {
                MessageBox.Show(this, "Các trường bắt buộc không được bỏ trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check if CMND exists
            if (originalCMND != textBoxCMND.Text.TrimEnd())
            {
                // in process of editing, textBoxCMND has been changed
                // or in process of adding
                try
                {
                    using (SqlConnection connection = Program.GetConnectionToSubsciber())
                    {
                        int returnValue = (int)Program.GetSPReturnValue(connection, "sp_KhachHang_CheckExists", "@CMND", textBoxCMND.Text);
                        if (returnValue == 1)
                        {
                            MessageBox.Show(this, "CMND này đã tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (returnValue == 2)
                        {
                            MessageBox.Show(this, "CMND này đã tồn tại ở chi nhánh khác!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                Validate();
                khachHangBindingSource.EndEdit();
                khachHangTableAdapter.Update(customerDataSet.KhachHang);

                // if edit or insert was successful, enable undo button
                String newCMND = textBoxCMND.Text;
                if (originalCMND == "")
                {
                    // in insert mode
                    undoList.Push(newCMND);
                    undoList.Push("INSERT");
                }
                else
                {
                    // in edit mode
                    undoList.Push(oldCustomerInfo);
                    undoList.Push(newCMND);
                    undoList.Push("UPDATE");
                }
                RefreshDataSet();
                khachHangBindingSource.Position = khachHangBindingSource.Find("CMND", newCMND);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ChangeFormAppearanceWhenAddingOrEditing(false);
        }

        private void barButtonItemCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            khachHangBindingSource.CancelEdit();
            ChangeFormAppearanceWhenAddingOrEditing(false);

            // check what action is being performed, add or edit?
            if (originalCMND == "")
            {
                // in add mode
                khachHangBindingSource.Position = position;
            }
        }

        private void barButtonItemUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (undoList.Count > 0)
            {
                String statement = undoList.Pop();
                if (statement == "DELETE")
                {
                    String employeeInfo = undoList.Pop();
                    String[] tokens = employeeInfo.Split('#');
                    khachHangTableAdapter.Insert(tokens[0], tokens[1], tokens[2], tokens[3], tokens[4], DateTime.Parse(tokens[5]), tokens[6], tokens[7]);
                    RefreshDataSet();
                    khachHangBindingSource.Position = khachHangBindingSource.Find("CMND", tokens[0]);
                }
                else if (statement == "INSERT")
                {
                    String cmnd = undoList.Pop();
                    khachHangTableAdapter.MyDeleteFunc(cmnd);
                    RefreshDataSet();
                    khachHangBindingSource.Position = position;
                }
                else if (statement == "UPDATE")
                {
                    // !!!!!!!!!!!!! remember to handle trangThaiXoa
                    String currentCMND = undoList.Pop();
                    String oldCustomerInfo = undoList.Pop();
                    String[] tokens = oldCustomerInfo.Split('#');
                    khachHangTableAdapter.MyUpdateFunc(tokens[0], tokens[1], tokens[2], tokens[3], tokens[4], tokens[5], tokens[6], tokens[7], currentCMND);
                    RefreshDataSet();
                    khachHangBindingSource.Position = khachHangBindingSource.Find("CMND", tokens[0]);
                }
            }
            if (undoList.Count == 0) barButtonItemUndo.Enabled = false;
        }
    }
}