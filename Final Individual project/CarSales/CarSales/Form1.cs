using CsvFileHandling;
using CarSales;
using System;

namespace CarSales
{
    public partial class Form1 : Form
    {
        private CsvExecutor csvEx = new CsvExecutor("cars.csv");

        public Form1()
        {
            InitializeComponent();
            ListboxWrite();
        }

        private void ClearField()
        {
            txtBrand.Text = "";
            txtModel.Text = "";
            txtYear.Text = "";
            txtPrice.Text = "";
        }

        private void ListboxWrite()
        {
            List<string[]> values = csvEx.ReadRecords();
            listBox1.Items.Clear();

            foreach (string[] value in values)
            {
                listBox1.Items.Add($"{value[0]} {value[1]} - {value[2]} - {value[3]}$");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<Car> car = new List<Car>()
            {
                new Car(txtBrand.Text, txtModel.Text, Int32.Parse(txtYear.Text), float.Parse(txtPrice.Text))
            };

            ClearField();
            csvEx.AppendMultipleRecords(car);
            ListboxWrite();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string connString = "Data source = DESKTOP-TK4NSQC\\SQLEXPRESS; Initial Catalog=FontysExercising; Integrated security = true";
            SqlExecutor sqlEx = new SqlExecutor(connString);
            List<string> result = sqlEx.ReadCustomers();

            foreach(string customer in result)
            {
                listbxCustomers.Items.Add(customer);
            }

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string connString = "Data source = DESKTOP-TK4NSQC\\SQLEXPRESS; Initial Catalog=FontysExercising; Integrated security = true";
            SqlExecutor sqlEx = new SqlExecutor(connString);
            // sqlEx.InsertCustomer();
        }
    }
}