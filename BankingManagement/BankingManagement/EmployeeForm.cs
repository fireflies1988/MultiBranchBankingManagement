using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankingManagement
{
    public partial class EmployeeForm : DevExpress.XtraEditors.XtraForm
    {
        private Stack<String> undoList = new Stack<string>();
        /// <summary>
        /// Store the index of the item before adding or editing for cancel, undo purpose.
        /// </summary>
        private int position;
        /// <summary>
        /// Used to check what action is being performed, Add or Edit?
        /// </summary>
        private String originalEmployeeID;
        private String oldEmployeeInfo;

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void FillDataSet(String connectionString)
        {

            bankDataSet.Clear();

            // TODO: This line of code loads data into the 'bankDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Connection.ConnectionString = connectionString;
            this.nhanVienTableAdapter.Fill(this.bankDataSet.NhanVien);

            // TODO: This line of code loads data into the 'bankDataSet.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            this.gdChuyenTienTableAdapter.Connection.ConnectionString = connectionString;
            this.gdChuyenTienTableAdapter.Fill(this.bankDataSet.GD_CHUYENTIEN);

            // TODO: This line of code loads data into the 'bankDataSet.GD_GOIRUT' table. You can move, or remove it, as needed.
            this.gdGoiRutTableAdapter.Connection.ConnectionString = connectionString;
            this.gdGoiRutTableAdapter.Fill(this.bankDataSet.GD_GOIRUT);
        }

        private void RefreshDataSet()
        {

            bankDataSet.Clear();

            // TODO: This line of code loads data into the 'bankDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.bankDataSet.NhanVien);

            // TODO: This line of code loads data into the 'bankDataSet.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            this.gdChuyenTienTableAdapter.Fill(this.bankDataSet.GD_CHUYENTIEN);

            // TODO: This line of code loads data into the 'bankDataSet.GD_GOIRUT' table. You can move, or remove it, as needed.
            this.gdGoiRutTableAdapter.Fill(this.bankDataSet.GD_GOIRUT);
        }

        private void RefreshFKTables()
        {
            // TODO: This line of code loads data into the 'bankDataSet.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            this.gdChuyenTienTableAdapter.Fill(this.bankDataSet.GD_CHUYENTIEN);

            // TODO: This line of code loads data into the 'bankDataSet.GD_GOIRUT' table. You can move, or remove it, as needed.
            this.gdGoiRutTableAdapter.Fill(this.bankDataSet.GD_GOIRUT);
        }

        private void RefreshPKTable()
        {
            bankDataSet.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'bankDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.bankDataSet.NhanVien);

            bankDataSet.EnforceConstraints = true;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            //bankDataSet.EnforceConstraints = false;
            String connectionString = Program.GetConnectionString(Program.SubscriberName, Program.LoginName, Program.Password);
            FillDataSet(connectionString);

            // Index was out of range. Remember to catch is this error (Already catched)
            // stored branchID
            //if (nhanVienBindingSource.Count == 0)
            //{
            //    try
            //    {
            //        branchID = Program.GetBranchID();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //}
            //else
            //{
            //    branchID = ((DataRowView)nhanVienBindingSource[0])["MACN"].ToString();
            //}

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
                barButtonItemUndo.Enabled = barButtonItemSave.Enabled = barButtonItemChangeBranch.Enabled = false;
            }
            else
            {
                comboBoxBranch.Enabled = false;
            }
        }

        // for adding and editing only
        private void ChangeFormAppearanceWhenAddingOrEditing(bool isBeingAddingOrEditing)
        {
            nhanVienGridControl.Enabled = !isBeingAddingOrEditing;
            groupControlInformation.Enabled = isBeingAddingOrEditing;
            barButtonItemAdd.Enabled = barButtonItemModify.Enabled = barButtonItemDelete.Enabled = !isBeingAddingOrEditing;
            barButtonItemUndo.Enabled = barButtonItemChangeBranch.Enabled = barButtonItemRefresh.Enabled = !isBeingAddingOrEditing;
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

            if (barButtonItemDelete.Enabled && nhanVienBindingSource.Count == 0)
            {
                barButtonItemDelete.Enabled = false;
            }

            if (barButtonItemUndo.Enabled && undoList.Count == 0)
            {
                barButtonItemUndo.Enabled = false;
            }
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = nhanVienBindingSource.Position;
            nhanVienBindingSource.AddNew();
            textBoxBranchID.Text = Program.BranchID;
            comboBoxSex.SelectedIndex = 0;
            comboBoxSex.Text = comboBoxSex.SelectedText;
            checkBoxDeleted.Checked = false;
            ChangeFormAppearanceWhenAddingOrEditing(true);

            originalEmployeeID = textBoxEmployeeID.Text;
        }

        private void barButtonItemCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nhanVienBindingSource.CancelEdit();
            ChangeFormAppearanceWhenAddingOrEditing(false);

            // check what action is being performed, add or edit?
            if (originalEmployeeID == "")
            {
                // in add mode
                nhanVienBindingSource.Position = position;
            }
        }

        private void barButtonItemModify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int checkState = checkBoxDeleted.Checked ? 1 : 0;
            originalEmployeeID = textBoxEmployeeID.Text.TrimEnd();
            oldEmployeeInfo = textBoxEmployeeID.Text + "#" + textBoxFamilyName.Text + "#" +
                        textBoxName.Text + "#" + textBoxAddress.Text + "#" + comboBoxSex.Text + "#" +
                        textBoxPhoneNumber.Text + "#" + textBoxBranchID.Text + "#" + checkState;
            Console.WriteLine(oldEmployeeInfo);

            ChangeFormAppearanceWhenAddingOrEditing(true);
        }

        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshDataSet();
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // !!!!!!!!!!!!!!!!!!!!! Login account
            if (gdChuyenTienBindingSource.Count > 0)
            {
                MessageBox.Show(this, "Không thể xóa nhân viên này vì có ràng buộc với các giao dịch chuyển tiền!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (gdGoiRutBindingSource.Count > 0)
            {
                MessageBox.Show(this, "Không thể xóa nhân viên này vì có ràng buộc với các giao dịch gởi rút tiền!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show(this, "Bạn có chắc muốn xóa nhân viên này?", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    // !!!!!!!!!!!!!!!!!!!!! remember to handle # sign
                    int checkState = checkBoxDeleted.Checked ? 1 : 0;
                    String employeeInfo = textBoxEmployeeID.Text + "#" + textBoxFamilyName.Text + "#" +
                        textBoxName.Text + "#" + textBoxAddress.Text + "#" + comboBoxSex.Text + "#" +
                        textBoxPhoneNumber.Text + "#" + textBoxBranchID.Text + "#" + checkState;

                    nhanVienBindingSource.RemoveCurrent();
                    Validate();
                    nhanVienBindingSource.EndEdit();
                    nhanVienTableAdapter.Update(bankDataSet.NhanVien);

                    // if delete was successful, enable undo button
                    barButtonItemUndo.Enabled = true;
                    undoList.Push(employeeInfo);
                    undoList.Push("DELETE");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Xóa nhân viên không thành công!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (nhanVienBindingSource.Count == 0)
            {
                barButtonItemDelete.Enabled = false;
            }
        }

        private void barButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // !!!!!!!!!!!!! login account
            if (String.IsNullOrWhiteSpace(textBoxEmployeeID.Text) || String.IsNullOrWhiteSpace(textBoxFamilyName.Text)
                || String.IsNullOrWhiteSpace(textBoxName.Text) || String.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                MessageBox.Show(this, "Các trường bắt buộc không được bỏ trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check if EmployeeID exists
            if (originalEmployeeID != textBoxEmployeeID.Text.TrimEnd())
            {
                // in process of editing, textBoxEmployeeID has been changed
                // or in process of adding
                try
                {
                    using (SqlConnection connection = Program.GetConnectionToSubsciber())
                    {
                        int returnValue = (int)Program.GetSPReturnValue(connection, "sp_NhanVien_CheckExists", "@MANV", textBoxEmployeeID.Text);
                        if (returnValue == 1)
                        {
                            MessageBox.Show(this, "Mã nhân viên này đã tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (returnValue == 2)
                        {
                            MessageBox.Show(this, "Mã nhân viên này đã tồn tại ở chi nhánh khác!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                nhanVienBindingSource.EndEdit();
                nhanVienTableAdapter.Update(bankDataSet.NhanVien);

                // if edit or insert was successful, enable undo button
                String newEmployeeID = textBoxEmployeeID.Text;
                if (originalEmployeeID == "")
                {
                    // in insert mode
                    RefreshPKTable();
                    undoList.Push(newEmployeeID);
                    undoList.Push("INSERT");
                }
                else
                {
                    // in edit mode
                    RefreshDataSet();
                    undoList.Push(oldEmployeeInfo);
                    undoList.Push(newEmployeeID);
                    undoList.Push("UPDATE");
                }
                nhanVienBindingSource.Position = nhanVienBindingSource.Find("MANV", newEmployeeID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ChangeFormAppearanceWhenAddingOrEditing(false);
        }

        private void comboBoxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            String subscriberName = comboBoxBranch.SelectedValue.ToString();
            String connectionString;
            //if (subscriberName == "System.Data.DataRowView") return;

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

        private void barButtonItemUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (undoList.Count > 0)
            {
                String statement = undoList.Pop();
                if (statement == "DELETE")
                {
                    String employeeInfo = undoList.Pop();
                    String[] tokens = employeeInfo.Split('#');
                    nhanVienTableAdapter.Insert(tokens[0], tokens[1], tokens[2], tokens[3], tokens[4], tokens[5], tokens[6], 0);
                    RefreshPKTable();
                    nhanVienBindingSource.Position = nhanVienBindingSource.Find("MANV", tokens[0]);
                }
                else if (statement == "INSERT")
                {
                    String employeeID = undoList.Pop();
                    nhanVienTableAdapter.MyDeleteFunc(employeeID);
                    RefreshPKTable();
                    nhanVienBindingSource.Position = position;
                }
                else if (statement == "UPDATE")
                {
                    String currentEmployeeID = undoList.Pop();
                    String oldEmployeeInfo = undoList.Pop();
                    String[] tokens = oldEmployeeInfo.Split('#');
                    nhanVienTableAdapter.MyUpdateFunc(tokens[0], tokens[1], tokens[2], tokens[3], tokens[4], tokens[5], tokens[6], int.Parse(tokens[7]), currentEmployeeID);
                    RefreshDataSet();
                    nhanVienBindingSource.Position = nhanVienBindingSource.Find("MANV", tokens[0]);
                }
            }
            if (undoList.Count == 0) barButtonItemUndo.Enabled = false;
        }

        private void barButtonItemChangeBranch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkBoxDeleted.Checked)
            {
                MessageBox.Show(this, "Không thể chuyển chi nhánh nhân viên ở trạng thái xóa!", "Chuyển chi nhánh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                String oldEmployeeID = ((DataRowView)nhanVienBindingSource.Current)["MANV"].ToString();
                new ChangeBranchDialog(oldEmployeeID).ShowDialog();
                RefreshPKTable();
                nhanVienBindingSource.Position = nhanVienBindingSource.Find("MANV", oldEmployeeID);
            }
        }
    }
}