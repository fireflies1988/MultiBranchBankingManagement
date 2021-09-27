using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankingManagement
{
    static class Program
    {
        public const String PublisherName = "DESKTOP-9OUV00A";
        public const String DatabaseName = "NGANHANG";

        /// <summary>
        /// This variable is used for saving the data from vw_SubscriberServers for later use.
        /// </summary>
        public static BindingSource Subscribers = new BindingSource();
        public static String SubscriberName;
        public static String LoginName;
        public static String Password;
        public static String EmployeeID;
        public static String EmployeeName;
        public static String GroupName;

        public static LoginForm loginForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginForm = new LoginForm();
            Application.Run(loginForm);
        }

        public static String GetConnectionString(String dataSource)
        {
            return "Data Source=" + dataSource + ";Initial Catalog=" + Program.DatabaseName + ";Integrated Security=true;";
        }

        public static String GetConnectionString(String dataSource, String userID, String password)
        {
            return "Data Source=" + dataSource + ";Initial Catalog=" + Program.DatabaseName + ";User ID=" + userID + ";Password=" + password + ";";
        }

        public static SqlDataReader CreateDataReader(SqlConnection connection, String commandText)
        {
            SqlDataReader reader;
            SqlCommand command = new SqlCommand(commandText, connection);
            try
            {
                reader = command.ExecuteReader();
                return reader;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }
    }
}
