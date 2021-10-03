using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankingManagement
{
    static class Program
    {
        public const String PublisherName = "DESKTOP-9OUV00A";
        public const String DatabaseName = "NGANHANG";
        public const String RemoteLoginName = "HTKN";
        public const String RemotePassword = "sa";

        /// <summary>
        /// This variable is used for saving the data from vw_SubscriberServers for later use.
        /// </summary>
        public static BindingSource Subscribers = new BindingSource();
        public static int SelectedBranchIndex;
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

        public static SqlConnection GetConnectionToPublisher()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Program.GetConnectionString(Program.PublisherName);
            connection.Open();
            return connection;
        }
        
        public static SqlConnection GetConnection(String subscriberName, String loginName, String password)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Program.GetConnectionString(subscriberName, loginName, password);
            connection.Open();
            return connection;
        }

        public static SqlConnection GetConnectionToSubsciber()
        {
            return GetConnection(Program.SubscriberName, Program.LoginName, Program.Password);
        }

        public static SqlDataReader CreateDataReader(SqlConnection connection, String cmdText)
        {
            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand(cmdText, connection);
            try
            {
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static object GetSPReturnValue(SqlConnection connection, String spName, String param, String value)
        {
            SqlCommand cmd = new SqlCommand(spName, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(param, SqlDbType.NVarChar).Value = value;
            cmd.Parameters.Add("@ReturnValue", SqlDbType.NVarChar).Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            return cmd.Parameters["@ReturnValue"].Value;
        }
    }
}
