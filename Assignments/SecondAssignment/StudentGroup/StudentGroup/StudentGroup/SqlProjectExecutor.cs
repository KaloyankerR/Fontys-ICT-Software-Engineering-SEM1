using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
        public string ReadValues()
        {
            String sql, Output = "";
            conn.Open();

            sql = "Select * from Students";
            command = new SqlCommand(sql, conn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            }

            dataReader.Close();
            command.Dispose();
            conn.Close();

            return Output;
        }

        public void InsertValue(string Name)
        {
            String sql, name = "";
            name = Name;
            conn.Open();


            sql = $"Insert into Students (FirstName, LastName) values ('{name}', 'Testov')";
            command = new SqlCommand(sql, conn);

            adapter = new SqlDataAdapter();
            adapter.InsertCommand = new SqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            conn.Close();
        }   

    }
}
