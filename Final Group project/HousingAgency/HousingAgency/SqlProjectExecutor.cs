using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HousingAgency
{
    public class SqlProjectExecutor
    {
        string connString;
        SqlConnection conn;
        SqlCommand command;
        SqlDataReader dataReader;
        SqlDataAdapter adapter;

        public SqlProjectExecutor()
        {
            // Can be different for you
            connString = "Data source = DESKTOP-TK4NSQC\\SQLEXPRESS; Initial Catalog=FontysExercising; Integrated security = true";
            
            conn = new SqlConnection(connString);
        }

        public List<string> GetMembersNames()
        {
            string sql = "";
            List<string> members = new List<string>();

            conn.Open();
            sql = "Select * from HousingAgencyMembers";
            command = new SqlCommand(sql, conn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                string memberName = dataReader.GetString(0);

                members.Add(memberName);
            }

            dataReader.Close();
            command.Dispose();
            conn.Close();

            return members;
        }

        private bool isPresent(string userName)
        {
            List<string> members = GetMembersNames();

            if (members.Contains(userName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isCorrect(string userName, string userPassword)
        {
            if (isPresent(userName))
            {
                string sql, password = "";

                conn.Open();
                sql = $"Select * from HousingAgencyMembers where userName = '{userName}' ";
                command = new SqlCommand(sql, conn);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                password = dataReader.GetString(1);

                dataReader.Close();
                command.Dispose();
                conn.Close();

                if (userPassword == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool isAdmin(string userName)
        {
            string sql = "";
            bool isAdmin = false;

            conn.Open();
            sql = $"Select * from HousingAgencyMembers where userName = '{userName}' ";
            command = new SqlCommand(sql, conn);
            dataReader = command.ExecuteReader();
            dataReader.Read();
            // password = dataReader.GetString(2);
            bool isCor = dataReader.GetBoolean(2);

            isAdmin = (isCor) ? true : false;

            dataReader.Close();
            command.Dispose();
            conn.Close();

            return isAdmin;
        }
    }
}
