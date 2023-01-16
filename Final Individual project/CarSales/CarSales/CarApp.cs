using CsvFileHandling;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CarSales
{
    public partial class CarApp : Form
    {
        //private string connString = "Data source = DESKTOP-TK4NSQC\\SQLEXPRESS; Initial Catalog=FontysExercising; Integrated security = true";
        private SqlExecutor sqlEx = new SqlExecutor("Data source = DESKTOP-TK4NSQC\\SQLEXPRESS; Initial Catalog=FontysExercising; Integrated security = true");
        private CsvExecutor csvEx = new CsvExecutor("cars.csv");

        public CarApp()
        {
            InitializeComponent();

            ConfigureSales();
            WriteCars();
            WriteCustomers();
            SetListBoxValues();
            btnCarsAdd.Enabled = radioBtnOptionsCanSell.Checked;
        }

        // Sales page
        public void ConfigureSales()
        {
            /*
            Sets the textboxes in the
            beginning (Sales page)
            */

            SetSalesCars();
            SetSalesCustomers();
        }

        public void SetSalesCars()
        {
            AutoCompleteStringCollection autotxt = new AutoCompleteStringCollection();
            List<string> values = GetCarsList();

            foreach (string value in values)
            {
                autotxt.Add(value);
            }

            txtSalesCar.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSalesCar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSalesCar.AutoCompleteCustomSource = autotxt;
        }

        public void SetSalesCustomers()
        {
            AutoCompleteStringCollection autotxt = new AutoCompleteStringCollection();
            List<string> values = GetCustomersList();

            foreach (string value in values)
            {
                autotxt.Add(value);
            }

            txtSalesCustomer.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSalesCustomer.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSalesCustomer.AutoCompleteCustomSource = autotxt;
        }

        public void SetListBoxValues()
        {
            string[] lines = File.ReadAllLines("result.txt");
            listbxResult.Items.Clear();

            foreach (string line in lines)
            {
                listbxResult.Items.Add(line);
            }

        }

        // Cars Page
        public void WriteCars()
        {
            List<string[]> values = this.sqlEx.ReadCars();
            listbxCars.Items.Clear();

            foreach (string[] value in values)
            {
                listbxCars.Items.Add($"{value[0]} - {value[1]} - {value[2]} - {value[3]}$");
            }
        }

        public List<string> GetCarsList()
        {
            List<string[]> values = this.sqlEx.ReadCars();
            List<string> result = new List<string>();

            foreach (string[] value in values)
            {
                result.Add($"{value[1]} {value[2]} - {value[3]}$");
            }

            return result;
        }

        public List<string> GetCustomersList()
        {
            List<string> customersValues = this.sqlEx.ReadCustomersNames();
            return customersValues;
        }

        // Used in reading the cars
        public void InsertCarsIntoDb()
        {
            List<string[]> values = csvEx.ReadRecords();
            this.sqlEx.InsertCars(values);
        }

        public void InsertCarsIntoDb(List<string[]> values)
        {
            this.sqlEx.InsertCars(values);
        }

        // Customers page
        public void WriteCustomers()
        {
            List<string> customersValues = this.sqlEx.ReadCustomers();
            listbxCustomers.Items.Clear();

            foreach (string customer in customersValues)
            {
                listbxCustomers.Items.Add(customer);
            }
        }

        public void InsertIntoCustomers(string[] values)
        {
            this.sqlEx.InsertCustomer(values);
        }

        // Controls 
        private void btnShowCars_Click(object sender, EventArgs e)
        {
            WriteCars();
            txtCarsSearchedCar.Text = "";
        }

        private void btnCustomersRefresh_Click(object sender, EventArgs e)
        {
            WriteCustomers();
            txtCustomersSearchedCustomer.Text = "";
        }

        // ok
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register frm = new Register();
            var result = frm.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                string[] values = { frm.Name, frm.PhoneNo, frm.Email, frm.Address, frm.ZipcodeAndCity };
                this.InsertIntoCustomers(values);
                SetSalesCustomers();
                WriteCustomers();
            }
            else
            {
                MessageBox.Show("Error occured!");
            }
        }

        // can be deleted
        private void btnCarsAdd_Click(object sender, EventArgs e)
        {
            RegisterCar frm = new RegisterCar();
            var result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show(frm.Name);
            }
            else
            {
                MessageBox.Show("Error occured!");
            }

            MessageBox.Show("Already in there!");
            // Car cr = new Car("MB", "AMG", 2020, 150000);
            // csvEx.AppendRecord(cr);
        }

        // ok, but can be simplify
        private async void btnSalesSale_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> customerNames = sqlEx.ReadCustomersNames();
                if (txtSalesCar.Text == "" || txtSalesCustomer.Text == "")
                {
                    throw new Exception("You didn't fill the needed data!");
                } else if (!(customerNames.Contains(txtSalesCustomer.Text)))
                {
                    throw new Exception("Such user doesn't exist!");
                }

                string[] fileCars = File.ReadAllLines("result.txt");
                string[] carDetails = txtSalesCar.Text.Split(" - ");
                string[] customerDetails = txtSalesCustomer.Text.Split(" - "); 

                string[] lines =
                {
                    $"Car: {carDetails[0]}", $"Customer: {customerDetails[0]}", $"Date: {dateSalesSale.Text}", ""
                };

                fileCars = fileCars.Concat(lines).ToArray();
                await File.WriteAllLinesAsync("result.txt", fileCars);
                this.sqlEx.SetCarAsSold(carDetails[0]);
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill the data correctly.", "Error");
            }
            finally
            {
                txtSalesCar.Clear();
                txtSalesCustomer.Clear();
                SetListBoxValues();
                WriteCars();
            }
            
            // listBox1.Items.Add(txtSalesCar.Text + "-" +txtSalesCustomer.Text); 
        }

        // ok, but take a look
        private void btnCustomersDelete_Click(object sender, EventArgs e)
        {
            // string selectedText;

            if (listbxCustomers.SelectedIndex != -1)
            {
                string selectedText = (string)listbxCustomers.SelectedItem;  
                string pattern = @"ID:\s(.*?)\s-";
                Match match = Regex.Match(selectedText, pattern);

                if (match.Success)
                {
                    string id = match.Groups[1].Value;
                    this.sqlEx.DeleteCustomer(id);

                    // Refreshes the listbox
                    WriteCustomers();
                    return;
                }
            } 

            MessageBox.Show("No customer selected");
        }

        // ok, but can be refactored
        private void btnCarsReset_Click(object sender, EventArgs e)
        {
            List<string[]> values = csvEx.ReadRecords();
            this.sqlEx.TruncateCars();
            InsertCarsIntoDb();
            File.WriteAllText("result.txt", string.Empty);
            SetListBoxValues();
            MessageBox.Show("Cars were resetted from the file.", "Status");
        }

        private void btnCarsSearch_Click(object sender, EventArgs e)
        {
            listbxCars.Items.Clear();

            List<string[]> values = this.sqlEx.ReadCars();
            string searchTerm = txtCarsSearchedCar.Text;
            var regx = new Regex(searchTerm);

            foreach (string[] value in values)
            {
                var result = value.Where(x => regx.IsMatch(x)).ToArray();
                if (result.Any())
                    listbxCars.Items.Add($"{value[0]} - {value[1]} - {value[2]} - {value[3]}$");
            }

        }

        private void btnCustomersSearch_Click(object sender, EventArgs e)
        {
            listbxCustomers.Items.Clear();
            
            List<string> customersValues = this.sqlEx.ReadCustomers();
            string searchTerm = txtCustomersSearchedCustomer.Text;
            
            foreach(string customer in customersValues)
            {
                Match match = Regex.Match(customer, searchTerm);

                if (match.Success)
                {
                    listbxCustomers.Items.Add(customer);
                }

            }

        }

        private void radioBtnOptionsCanSell_CheckedChanged(object sender, EventArgs e)
        {
            btnCarsAdd.Enabled = radioBtnOptionsCanSell.Checked;
        }
    }
}
