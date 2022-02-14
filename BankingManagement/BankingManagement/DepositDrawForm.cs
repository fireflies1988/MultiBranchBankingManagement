using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankingManagement
{
    public partial class DepositWithdrawForm : DevExpress.XtraEditors.XtraForm
    {
        public DepositWithdrawForm()
        {
            InitializeComponent();
        }

        private void DepositWithdrawForm_Load(object sender, EventArgs e)
        {
            // binding combobox to dictionary
            Dictionary<String, String> source = new Dictionary<string, string>();
            source.Add("GT", "Gởi tiền");
            source.Add("RT", "Rút tiền");
            comboBoxType.DataSource = new BindingSource(source, null);
            comboBoxType.DisplayMember = "Value";
            comboBoxType.ValueMember = "Key";

            ActiveControl = comboBoxType;
            textBoxEmployeeID.Text = Program.EmployeeID;
            textBoxEmployeeName.Text = Program.EmployeeName;
            dateTimePickerTransactionDate.Value = DateTime.Now;
        }

        private void Reset()
        {
            ActiveControl = comboBoxType;
            comboBoxType.SelectedIndex = 0;
            dateTimePickerTransactionDate.Value = DateTime.Now;
            textBoxAccountNumber.ResetText();
            numericUpDownAmount.Value = 100000;
            panelAccountOwner.Visible = false;
            pictureBoxCheck.Visible = false;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxAccountNumber.Text))
            {
                MessageBox.Show(this, "Các trường bắt buộc không được bỏ trống, vui lòng điền đầy đủ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pictureBoxCheck.Visible)
            {
                try
                {
                    using (SqlConnection connection = Program.GetConnectionToSubsciber())
                    {
                        SqlCommand cmd = new SqlCommand("sp_GdGoiRut_WithdrawDeposit", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@SOTK", SqlDbType.NChar).Value = textBoxAccountNumber.Text;
                        cmd.Parameters.Add("@LOAIGD", SqlDbType.NChar).Value = comboBoxType.SelectedValue;
                        cmd.Parameters.Add("@NGAYGD", SqlDbType.DateTime).Value = dateTimePickerTransactionDate.Value;
                        cmd.Parameters.Add("@SOTIEN", SqlDbType.Money).Value = numericUpDownAmount.Value;
                        cmd.Parameters.Add("@MANV", SqlDbType.NChar).Value = textBoxEmployeeID.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(this, "Giao dịch thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Giao dịch không thành công.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show(this, "Số tài khoản không hợp lệ, vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void textBoxAccountNumber_Validated(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = Program.GetConnectionToSubsciber())
                {
                    String cmdText = "EXEC sp_GD_FindCustomerInfoByAccountNumber @SOTK = '" + textBoxAccountNumber.Text + "'";
                    using (SqlDataReader reader = Program.CreateDataReader(connection, cmdText))
                    {
                        reader.Read();
                        textBoxCMND.Text = reader.GetString(0);
                        textBoxAccountOwner.Text = reader.GetString(1);

                        // Clear the error, if any, in the error provider.
                        errorProvider.SetError(textBoxAccountNumber, String.Empty);
                        panelAccountOwner.Visible = true;
                        pictureBoxCheck.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                // Set the error if the account number is not valid.
                errorProvider.SetError(textBoxAccountNumber, "Số tài khoản này không tồn tại!");
                panelAccountOwner.Visible = false;
                pictureBoxCheck.Visible = false;
            }
        }

        private void textBoxAccountNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxHandler.AcceptsOnlyNumbers(sender, e);
        }
    }
}