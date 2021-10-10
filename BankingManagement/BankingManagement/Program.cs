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
        public const String Subscriber3 = "DESKTOP-9OUV00A\\MSSQLSERVER3";

        /// <summary>
        /// This variable is used for saving the data from vw_SubscriberServers for later use.
        /// </summary>
        public static BindingSource Subscribers = new BindingSource();
        public static int SelectedBranchIndex;
        public static String SubscriberName;
        public static String SubscriberDescription;
        public static String LoginName;
        public static String Password;
        public static String EmployeeID;
        public static String EmployeeName;
        public static String GroupName;
        public static String BranchID;

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

        //
        // NOTE: DON'T FORGET TO ADD A TRY CATCH STATEMENT TO ALL THESE FUNCTIONS BELOW
        //
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
            reader = cmd.ExecuteReader();
            return reader;
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

        /// <summary>
        /// Return the branch id of the branch you logged in.
        /// </summary>
        public static String GetBranchID()
        {
            using (SqlConnection connection = Program.GetConnectionToSubsciber())
            {
                String cmdText = "SELECT MACN FROM ChiNhanh";
                using (SqlDataReader reader = Program.CreateDataReader(connection, cmdText))
                {
                    reader.Read();
                    return reader.GetString(0);
                }
            }
        }

        /// <summary>
        /// Return the branch id
        /// </summary>
        public static String GetBranchID(String subscriberName, String loginName, String password)
        {
            using (SqlConnection connection = Program.GetConnection(subscriberName, loginName, password))
            {
                String cmdText = "SELECT MACN FROM ChiNhanh";
                using (SqlDataReader reader = Program.CreateDataReader(connection, cmdText))
                {
                    reader.Read();
                    return reader.GetString(0);
                }
            }
        }

        /// <summary>
        /// Create a DataTable from a query
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public static DataTable CreateDataTable(String cmd, String connectionString)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd, connection);
                sda.Fill(dt);
                return dt;
            }
        }
        //
        //
        //
    }
}
