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
        private String branchID;
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Connection.ConnectionString = Program.GetConnectionString(Program.SubscriberName, Program.LoginName, Program.Password);
            this.khachHangTableAdapter.Fill(this.customerDataSet.KhachHang);

            // Index was out of range. Remember to catch is this error (Already catched)
            // save branchID
            if (khachHangBindingSource.Count == 0)
            {
                try
                {
                    using (SqlConnection connection = Program.GetConnectionToSubsciber())
                    {
                        String cmdText = "SELECT MACN FROM ChiNhanh";
                        using (SqlDataReader reader = Program.CreateDataReader(connection, cmdText))
                        {
                            if (reader == null) return;
                            reader.Read();
                            branchID = reader.GetString(0);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                branchID = ((DataRowView)khachHangBindingSource[0])["MACN"].ToString();
            }

            // load data into branch comboBox
            // remove the eventHandler for the selectedIndexchanged to prevent it from being fired when comboBoxBranch datasource is bound for the first time
            comboBoxBranch.DataSource = Program.Subscribers;
            comboBoxBranch.DisplayMember = "TENCN";
            comboBoxBranch.ValueMember = "TENSERVER";
            comboBoxBranch.SelectedIndex = Program.SelectedBranchIndex;

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
    }
}