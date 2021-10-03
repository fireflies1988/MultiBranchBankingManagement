using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankingManagement
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoBranchCombobox();
        }

        private void LoadDataIntoBranchCombobox()
        {
            try
            {
                using (SqlConnection connection = Program.GetConnectionToPublisher())
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM vw_SubscriberServers", connection);
                    sda.Fill(dt);
                    Program.Subscribers.DataSource = dt;
                }
                comboBoxBranch.DataSource = Program.Subscribers;
                comboBoxBranch.DisplayMember = "TENCN";
                comboBoxBranch.ValueMember = "TENSERVER";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Không thể kết nối với cơ sở dữ liệu!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void textBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLoginName.Text.Trim() == "" || textBoxPassword.Text.Trim() == "")
            {
                MessageBox.Show(this, "Tên đăng nhập và mật khẩu không được bỏ trống!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Program.SubscriberName = comboBoxBranch.SelectedValue.ToString();
            Program.SelectedBranchIndex = comboBoxBranch.SelectedIndex;
            Program.LoginName = textBoxLoginName.Text;
            Program.Password = textBoxPassword.Text;

            try
            {
                using (SqlConnection connection = Program.GetConnectionToSubsciber())
                {
                    String cmdText = "EXEC sp_Login_GetEmployeeInfo @LoginName = '" + Program.LoginName + "'";
                    using (SqlDataReader reader = Program.CreateDataReader(connection, cmdText))
                    {
                        if (reader == null) return;
                        reader.Read();
                        Program.EmployeeID = reader.GetString(0);
                        Program.EmployeeName = reader.GetString(1);
                        Program.GroupName = reader.GetString(2);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(this, "Tên đăng nhập hoặc mật khẩu không chính xác!\n" + ex.Message, "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            catch (Exception ex) // for sa
            {
                MessageBox.Show(this, ex.Message + "\n" + ex.StackTrace, "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Hide();
            new MainForm().Show();
        }


        //public void LoadBranchData()
        //{
        //    sc.Open();
        //    SqlCommand scm = new SqlCommand("SELECT * FROM vw_SubscriberServers", sc);
        //    sda.SelectCommand = scm;
        //    if (ds.Tables.Contains("branch"))
        //    {
        //        ds.Tables["branch"].Clear();
        //    }
        //    sda.Fill(ds, "branch");
        //    sc.Close();
        //}

        //public void InitializeValue()
        //{
        //    ds = new DataSet();
        //    LoadBranchData();

        //    comboBoxBranch.DataSource = ds.Tables["branch"];
        //    comboBoxBranch.DisplayMember = "TENCN";
        //    comboBoxBranch.ValueMember = "TENSERVER";
        //}
    }
}