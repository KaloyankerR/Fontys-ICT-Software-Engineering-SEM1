using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentGroup
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
            connString = "Data source = DESKTOP-TK4NSQC\\SQLEXPRESS; Initial Catalog=FontysExercising; Integrated security = true";
            conn = new SqlConnection(connString);
        }
        
        // ---------------------- Public
        public List<string> GetMembers()
        {
            string sql = "";
            List<string> Output = new List<string>();
            conn.Open();

            sql = "Select * from Members";
            command = new SqlCommand(sql, conn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output.Add($"{dataReader.GetValue(0)} - {dataReader.GetValue(1)}\n");
            }

            dataReader.Close();
            command.Dispose();
            conn.Close();

            return Output;
        }

        public void AddMember(string Name, string ProjectGroupName)
        {
            string sql, name, projectGroup = "";
            name = Name;
            projectGroup = ProjectGroupName.Replace("\n", "");
            conn.Open();

            sql = $"Insert into Members(name, projectGroup) values('{name}', '{projectGroup}')";
            command = new SqlCommand(sql, conn);

            adapter = new SqlDataAdapter();
            adapter.InsertCommand = new SqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            conn.Close();
        }   

        public List<string> GetProjectGroups()
        {
            string sql = "";
            List<string> output = new List<string>();
            conn.Open();

            sql = "Select * from ProjectGroup";
            command = new SqlCommand(sql, conn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                output.Add($"{dataReader.GetValue(0)}\n");
            }

            dataReader.Close();
            command.Dispose();
            conn.Close();

            return output;
        }

        public void AddProjectGroup(string Name)
        {
            string sql, name = "";
            name = Name;
            conn.Open();

            sql = $"Insert into ProjectGroup(name) values('{name}')";
            command = new SqlCommand(sql, conn);

            adapter = new SqlDataAdapter();
            adapter.InsertCommand = new SqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            conn.Close();
        }

        public List<string> GetGroupMembers(string group)
        {
            string sql, groupName = "";
            groupName = group.Replace("\n", "");
            List<string> output = new List<string>();
            conn.Open();

            sql = $"select * from Members where projectGroup = '{groupName}'";
            command = new SqlCommand(sql, conn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                output.Add($"{dataReader.GetValue(1)}\n");
            }

            dataReader.Close();
            command.Dispose();
            conn.Close();

            return output;
        }

        // ---------------- Private methods
        private void DropMembers()
        {
            string sql = "";
            adapter = new SqlDataAdapter();
            conn.Open();

            sql = $"Drop table Members";
            command = new SqlCommand(sql, conn);

            adapter.InsertCommand = new SqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            conn.Close();
        } 
        
        private void DropProjectGroup()
        {
            string sql = "";
            adapter = new SqlDataAdapter();
            conn.Open();

            sql = $"Drop table ProjectGroup";
            command = new SqlCommand(sql, conn);

            adapter.InsertCommand = new SqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            conn.Close();
        }

        private void CreateMembers()
        {
            string sql = "";
            adapter = new SqlDataAdapter();
            conn.Open();

            sql = "create table Members (\r\n\tstudentNumber int NOT NULL PRIMARY KEY IDENTITY(1, 1),\r\n\tname varchar(55) NOT NULL,\r\n\tprojectGroup varchar(55) NOT NULL FOREIGN KEY REFERENCES ProjectGroup(name)\r\n);";
            command = new SqlCommand(sql, conn);

            adapter.InsertCommand = new SqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            conn.Close();
        }
        
        private void CreateProjectGroup()
        {
            string sql = "";
            adapter = new SqlDataAdapter();
            conn.Open();

            sql = "create table ProjectGroup (\r\n\t-- projectGroupNumber int NOT NULL PRIMARY KEY IDENTITY(1, 1),\r\n\tname varchar(55) NOT NULL PRIMARY KEY\r\n);";
            command = new SqlCommand(sql, conn);

            adapter.InsertCommand = new SqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            conn.Close();
        }

        // ----------------- Other
        public void HardReset()
        {
            // Dropping
            DropMembers();
            DropProjectGroup();

            // Creating
            CreateProjectGroup();
            CreateMembers();
        }

    }
}
