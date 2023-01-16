using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace CarSales
{
    public class SqlExecutor
    {
        private string connString;
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader dataReader;
        private SqlDataAdapter adapter;

        public SqlExecutor(string connString)
        {
            this.connString = connString;
            this.conn =new SqlConnection(connString);
        }

        public void CreateTables()
        {
            try
            {
                CreateCustomersTable();
                CreateCarsTable();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        private void CreateCarsTable()
        {
            string sql = "";

            try
            {
                adapter = new SqlDataAdapter();
                conn.Open();

                sql = "create table Cars (" +
                    "CarId int primary key identity(1, 1)," +
                    "Brand varchar(55) not null," +
                    "Model varchar(55) not null," +
                    "YearProduced int not null," +
                    "BasePrice float not null," +
                    "Sold bit)";
                cmd = new SqlCommand(sql, conn);

                adapter.InsertCommand = new SqlCommand(sql, conn);
                adapter.InsertCommand.ExecuteNonQuery();
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        private void CreateCustomersTable()
        {
            string sql = "";

            try
            {
                adapter = new SqlDataAdapter();
                conn.Open();

                sql = "create table Customers (" +
                    "customerId int primary key identity(1, 1)," +
                    "firstName varchar(30) not null," +
                    "lastName varchar(30) not null," +
                    "phoneNumber int not null," +
                    "email varchar(55)," +
                    "customerAddress varchar(55) not null," +
                    "zipcode varchar(15)," +
                    "city varchar(25) not null)";
                cmd = new SqlCommand(sql, conn);

                adapter.InsertCommand = new SqlCommand(sql, conn);
                adapter.InsertCommand.ExecuteNonQuery();
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        // Used in reading the cars
        public void InsertCars(List<string[]> values)
        {
            string sql;

            try
            {
                conn.Open();

                foreach (string[] value in values)
                {
                    sql = $"insert into Cars(Brand, Model, YearProduced, BasePrice, Sold)" +
                    $"values('{value[0]}', '{value[1]}', {value[2]}, {value[3]}, null)";
                    cmd = new SqlCommand(sql, conn);

                    adapter = new SqlDataAdapter();
                    adapter.InsertCommand = new SqlCommand(sql, conn);
                    adapter.InsertCommand.ExecuteNonQuery();
                }
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public void TruncateCars()
        {
            // string sql;

            try
            {
                conn.Open();

                string sql = $"truncate table Cars";
                cmd = new SqlCommand(sql, conn);

                adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand(sql, conn);
                adapter.InsertCommand.ExecuteNonQuery();
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public void InsertCustomer(string[] insertValues)
        {
            string sql;

            try
            {
                conn.Open();

                sql = $"insert into Customer(Name, PhoneNo, Email, CustomerAddress, ZipcodeAndCity)" +
                $"values('{insertValues[0]}', 123, '{insertValues[2]}', '{insertValues[3]}', '{insertValues[4]}')";
                cmd = new SqlCommand(sql, conn);

                adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand(sql, conn);
                adapter.InsertCommand.ExecuteNonQuery();
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
           
        }

        public List<string[]> ReadCars()
        {
            string sql = "";
            List<string[]> output = new List<string[]>();
            conn.Open();

            sql = "select * from Cars where Sold is null";
            cmd = new SqlCommand(sql, conn);
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                string id = dataReader.GetValue(0).ToString();
                string brand = dataReader.GetValue(1).ToString();
                string model = dataReader.GetValue(2).ToString();
                string price = dataReader.GetValue(4).ToString();

                string[] cars = new string[] { id, brand, model, price };
                output.Add(cars);
                //output.Add({dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetValue(2), dataReader.GetValue(4)});
            }

            dataReader.Close();
            cmd.Dispose();
            conn.Close();

            return output;
        }

        public List<string> ReadCustomers()
        {
            string sql = "";
            List<string> output = new List<string>();
            conn.Open();

            sql = "Select * from Customer";
            cmd = new SqlCommand(sql, conn);
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                output.Add($"ID: {dataReader.GetValue(0)} - Name: {dataReader.GetValue(1)} - Address: {dataReader.GetValue(4)}");
            }

            dataReader.Close();
            cmd.Dispose();
            conn.Close();

            return output;
        }

        public List<string> ReadCustomersNames()
        {
            string sql = "";
            List<string> output = new List<string>();
            conn.Open();

            sql = "Select * from Customer";
            cmd = new SqlCommand(sql, conn);
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                output.Add($"{dataReader.GetValue(1)} - {dataReader.GetValue(0)}");
            }

            dataReader.Close();
            cmd.Dispose();
            conn.Close();

            return output;
        }

        public void SetCarAsSold(string name)
        {
            string sql;

            try
            {
                conn.Open();

                sql = $"update Cars set Sold = 1 where CONCAT(Brand, ' ', Model) = '{name}'";
                cmd = new SqlCommand(sql, conn);

                adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand(sql, conn);
                adapter.InsertCommand.ExecuteNonQuery();
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        public void DeleteCustomer(string id)
        {
            string sql;

            try
            {
                conn.Open();

                sql = $"delete from Customer where CustomerId = '{id}'";
                cmd = new SqlCommand(sql, conn);

                adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand(sql, conn);
                adapter.InsertCommand.ExecuteNonQuery();
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }


    }
}
