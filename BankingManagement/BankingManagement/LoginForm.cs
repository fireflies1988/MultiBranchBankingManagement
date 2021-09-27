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
            Program.SubscriberName = comboBoxBranch.SelectedValue.ToString();
        }

        private void LoadDataIntoBranchCombobox()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                try
                {
                    connection.ConnectionString = Program.GetConnectionString(Program.PublisherName);
                    connection.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM vw_SubscriberServers", connection);
                    sda.Fill(dt);
                    Program.Subscribers.DataSource = dt;
                    comboBoxBranch.DataSource = Program.Subscribers;
                    comboBoxBranch.DisplayMember = "TENCN";
                    comboBoxBranch.ValueMember = "TENSERVER";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể kết nối với cơ sở dữ liệu!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private void textBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.SubscriberName = comboBoxBranch.SelectedValue.ToString();
            Console.WriteLine(Program.SubscriberName);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLoginName.Text.Trim() == "" || textBoxPassword.Text.Trim() == "")
            {
                MessageBox.Show(this, "Tên đăng nhập và mật khẩu không được bỏ trống!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SqlConnection connection = new SqlConnection())
            {
                try
                {
                    connection.ConnectionString = Program.GetConnectionString(Program.SubscriberName, textBoxLoginName.Text, textBoxPassword.Text);
                    connection.Open();
                    Program.LoginName = textBoxLoginName.Text;
                    Program.Password = textBoxPassword.Text;
                    String commandText = "EXEC sp_Login_GetEmployeeInfo '" + Program.LoginName + "'";
                    using (SqlDataReader reader = Program.CreateDataReader(connection, commandText))
                    {
                        if (reader == null) return;
                        reader.Read();
                        Program.EmployeeID = reader.GetString(0);
                        Program.EmployeeName = reader.GetString(1);
                        Program.GroupName = reader.GetString(2);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(this, "Tên đăng nhập hoặc mật khẩu không chính xác!\n" + ex.Message, "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message + "\n" + ex.StackTrace, "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
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