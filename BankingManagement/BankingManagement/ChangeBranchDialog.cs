using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankingManagement
{
    public partial class ChangeBranchDialog : DevExpress.XtraEditors.XtraForm
    {
        private String oldEmployeeID;
        private Boolean newEmployeeIDRequired;
        public ChangeBranchDialog(String oldEmployeeID)
        {
            InitializeComponent();
            this.oldEmployeeID = oldEmployeeID;
        }

        private void buttonChangeBranch_Click(object sender, EventArgs e)
        {
            //!!!!!!!!!!!!!!!!!!!!!!!! length > 10
            String newEmployeeID = textBoxNewEmployeeID.Text.Trim();
            String newBranchID;
            String subscriberName = comboBoxBranch.SelectedValue.ToString();

            if (newEmployeeIDRequired && newEmployeeID == "")
            {
                MessageBox.Show(this, "Vui lòng nhập mã nhân viên mới!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // get newBranchID
            try
            {
                newBranchID = Program.GetBranchID(subscriberName, Program.RemoteLoginName, Program.RemotePassword);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // change branch
            try
            {
                using (SqlConnection connection = Program.GetConnectionToSubsciber())
                {
                    // check new employee id
                    if (newEmployeeIDRequired)
                    {
                        int returnValue = (int)Program.GetSPReturnValue(connection, "sp_NhanVien_CheckExists", "@MANV", newEmployeeID);
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

                        // change branch
                        SqlCommand cmd = new SqlCommand("sp_NhanVien_ChangeBranch", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@OldEmployeeID", SqlDbType.NChar).Value = oldEmployeeID;
                        cmd.Parameters.Add("@NewEmployeeID", SqlDbType.NChar).Value = newEmployeeID;
                        cmd.Parameters.Add("@NewBranchID", SqlDbType.NChar).Value = newBranchID;
                        cmd.ExecuteNonQuery();
                    } 
                    else
                    {
                        SqlCommand cmd = new SqlCommand("sp_NhanVien_ChangeBranch", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@OldEmployeeID", SqlDbType.NChar).Value = oldEmployeeID;
                        cmd.Parameters.Add("@NewBranchID", SqlDbType.NChar).Value = newBranchID;
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show(this, "Chuyển chi nhánh thành công", "Chuyển chi nhánh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ChangeBranchDialog_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = Program.GetConnectionToPublisher())
                {
                    String cmdText = "SELECT * FROM vw_SubscriberServers WHERE TENSERVER <> '" + Program.SubscriberName + "'";
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmdText, connection);
                    sda.Fill(dt);
                    comboBoxBranch.DataSource = dt;
                    comboBoxBranch.DisplayMember = "TENCN";
                    comboBoxBranch.ValueMember = "TENSERVER";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Không thể kết nối với cơ sở dữ liệu!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check if a new employee is necessary
            try
            {
                using (SqlConnection connection = Program.GetConnectionToSubsciber())
                {
                    int returnValue = (int)Program.GetSPReturnValue(connection, "sp_NhanVien_ChangeBranch_CheckConditions", "@OldEmployeeID", oldEmployeeID);
                    if (returnValue == 0)
                    {
                        newEmployeeIDRequired = false;
                    }
                    else if (returnValue == 1)
                    {
                        textBoxNewEmployeeID.Visible = true;
                        label1.Visible = true;
                        label2.Visible = true;
                        newEmployeeIDRequired = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}