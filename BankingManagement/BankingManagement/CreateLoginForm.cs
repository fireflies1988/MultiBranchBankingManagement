using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankingManagement
{
    public partial class CreateLoginForm : DevExpress.XtraEditors.XtraForm
    {
        private const int CB_SETCUEBANNER = 0x1703;
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);

        public CreateLoginForm()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            textBoxLoginName.Text = "";
            textBoxPassword.Text = "";
            textBoxBranch.Text = Program.SubscriberDescription;
            textBoxGroupName.Text = Program.GroupName;
            ActiveControl = textBoxLoginName;
            try
            {
                String connectionString = Program.GetConnectionString(Program.SubscriberName, Program.LoginName, Program.Password);
                DataTable dt = Program.CreateDataTable("SELECT * FROM vw_EmployeesWithoutLogins", connectionString);
                comboBoxEmployee.DataSource = dt;
                comboBoxEmployee.DisplayMember = "HOTEN";
                comboBoxEmployee.ValueMember = "MANV";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // display cue message
            comboBoxEmployee.SelectedItem = null;
            SendMessage(this.comboBoxEmployee.Handle, CB_SETCUEBANNER, 0, "Vui lòng chọn nhân viên");
        }

        private void CreateLoginForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployee.SelectedItem == null)
            {
                MessageBox.Show(this, "Vui lòng chọn nhân viên để tạo tài khoản!", "Tạo tài khoản đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxEmployee.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(textBoxLoginName.Text) || String.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show(this, "Tên đăng nhập và mật khẩu không được bỏ trống!", "Tạo tài khoản đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (SqlConnection connection = Program.GetConnectionToSubsciber())
                {
                    SqlCommand cmd = new SqlCommand("sp_Login_CreateNewLogin", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@LoginName", SqlDbType.NVarChar).Value = textBoxLoginName.Text.Trim();
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = textBoxPassword.Text.Trim();
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = comboBoxEmployee.SelectedValue;
                    cmd.Parameters.Add("@DbRole", SqlDbType.NVarChar).Value = Program.GroupName;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(this, "Tạo tài khoản đăng nhập thành công.", "Tạo tài khoản đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // reload data
                    loadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}