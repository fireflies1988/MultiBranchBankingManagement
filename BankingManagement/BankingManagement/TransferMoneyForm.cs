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
    public partial class TransferMoneyForm : DevExpress.XtraEditors.XtraForm
    {
        public TransferMoneyForm()
        {
            InitializeComponent();
        }

        private void TransferMoneyForm_Load(object sender, EventArgs e)
        {
            ActiveControl = textBoxTransferorAccountNumber;
            textBoxEmployeeID.Text = Program.EmployeeID;
            textBoxEmployeeName.Text = Program.EmployeeName;
            dateTimePickerTransactionDate.Value = DateTime.Now;
        }

        private void textBoxTransferorAccountNumber_Validated(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = Program.GetConnectionToSubsciber())
                {
                    String cmdText = "EXEC sp_GD_FindCustomerInfoByAccountNumber @SOTK = '" + textBoxTransferorAccountNumber.Text + "'";
                    using (SqlDataReader reader = Program.CreateDataReader(connection, cmdText))
                    {
                        reader.Read();
                        textBoxTransferorID.Text = reader.GetString(0);
                        textBoxTransferor.Text = reader.GetString(1);

                        // Clear the error, if any, in the error provider.
                        errorProvider.SetError(textBoxTransferorAccountNumber, String.Empty);
                        panelAccountOwner1.Visible = true;
                        pictureBoxCheck1.Visible = true;
                    }
                }
            }
            catch (Exception)
            {
                // Set the error if the account number is not valid.
                errorProvider.SetError(textBoxTransferorAccountNumber, "Số tài khoản này không tồn tại!");
                panelAccountOwner1.Visible = false;
                pictureBoxCheck1.Visible = false;
            }
        }

        private void textBoxBeneficiaryAccountNumber_Validated(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = Program.GetConnectionToSubsciber())
                {
                    String cmdText = "EXEC sp_GD_FindCustomerInfoByAccountNumber @SOTK = '" + textBoxBeneficiaryAccountNumber.Text + "'";
                    using (SqlDataReader reader = Program.CreateDataReader(connection, cmdText))
                    {
                        reader.Read();
                        textBoxBeneficiaryID.Text = reader.GetString(0);
                        textBoxBeneficiary.Text = reader.GetString(1);

                        // Clear the error, if any, in the error provider.
                        errorProvider.SetError(textBoxBeneficiaryAccountNumber, String.Empty);
                        panelAccountOwner2.Visible = true;
                        pictureBoxCheck2.Visible = true;
                    }
                }
            }
            catch (Exception)
            {
                // Set the error if the account number is not valid.
                errorProvider.SetError(textBoxBeneficiaryAccountNumber, "Số tài khoản này không tồn tại!");
                panelAccountOwner2.Visible = false;
                pictureBoxCheck2.Visible = false;
            }
        }

        private void Reset()
        {
            ActiveControl = textBoxTransferorAccountNumber;
            dateTimePickerTransactionDate.Value = DateTime.Now;
            textBoxTransferorAccountNumber.ResetText();
            textBoxBeneficiaryAccountNumber.ResetText();
            textBoxAmount.ResetText();
            panelAccountOwner1.Visible = false;
            pictureBoxCheck1.Visible = false;
            panelAccountOwner2.Visible = false;
            pictureBoxCheck2.Visible = false;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxTransferorAccountNumber.Text) || String.IsNullOrWhiteSpace(textBoxAmount.Text)
                || String.IsNullOrWhiteSpace(textBoxBeneficiaryAccountNumber.Text))
            {
                MessageBox.Show(this, "Các trường bắt buộc không được bỏ trống, vui lòng điền đầy đủ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxTransferorAccountNumber.Text == textBoxBeneficiaryAccountNumber.Text)
            {
                MessageBox.Show(this, "Tài khoản chuyển và nhận không được trùng nhau!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // !!!!!!! textbox: allow number only
            if (int.Parse(textBoxAmount.Text) <= 0)
            {
                MessageBox.Show(this, "Số tiền giao dịch phải lớn hơn 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pictureBoxCheck1.Visible && pictureBoxCheck2.Visible)
            {
                try
                {
                    using (SqlConnection connection = Program.GetConnectionToSubsciber())
                    {
                        SqlCommand cmd = new SqlCommand("sp_GdChuyenTien_Transfer", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@SOTK_CHUYEN", SqlDbType.NChar).Value = textBoxTransferorAccountNumber.Text;
                        cmd.Parameters.Add("@NGAYGD", SqlDbType.DateTime).Value = dateTimePickerTransactionDate.Value;
                        cmd.Parameters.Add("@SOTIEN", SqlDbType.Money).Value = textBoxAmount.Text;
                        cmd.Parameters.Add("@SOTK_NHAN", SqlDbType.NChar).Value = textBoxBeneficiaryAccountNumber.Text;
                        cmd.Parameters.Add("@MANV", SqlDbType.NChar).Value = textBoxEmployeeID.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(this, "Giao dịch thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show(this, "Số tài khoản không hợp lệ, vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}