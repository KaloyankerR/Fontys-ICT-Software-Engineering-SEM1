using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HousingAgency
{
    public partial class GroceriesCalculator : Form
    {
        DataTable dt = new DataTable();
        double totalAmount = 0;

        public GroceriesCalculator()
        {
            InitializeComponent();

            dt.Columns.Add("Name", typeof(String));
            dt.Columns.Add("Cost", typeof(Double));
            dt.Columns.Add("Tenant", typeof(String));

            dtgrdGroceries.DataSource = dt;
            dtgrdGroceries.Columns["Name"].Width = 395;
            dtgrdGroceries.Columns["Cost"].Width = 200;
            dtgrdGroceries.Columns["Tenant"].Width = 200;
        }

        private void GetTotalAmount()
        {
            double cost = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cost += Convert.ToDouble(dt.Rows[i].ItemArray[1]);
            }

            lblTotal.Text = "Total amount: " + String.Format("{0:0.00}", cost);           
        }

        private bool CanChange()
        {
            bool firstCase = (txtName.Text != "") ? true : false;
            bool secondCase = (numupdwnCost.Text != "0.00") ? true : false;

            return (firstCase && secondCase);
        }

        private void btnAddGrocery_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            double cost = Convert.ToDouble(numupdwnCost.Text);
            string tenant = txtTenantName.Text;

            dt.Rows.Add(name, cost, tenant);
            ClearFields();
            GetTotalAmount();
        }

        private void ClearFields()
        {
            txtName.Text = "";
            numupdwnCost.Text = "0.00";
            txtTenantName.Text = "";
        }

        //private void dtgrdGroceries_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    tabPage.SelectedTab = tabPageEdit;
        //}

        private void btnChangeEdit_Click(object sender, EventArgs e)
        {
            if (CanChange())
            {
                int index = dtgrdGroceries.CurrentCell.RowIndex;
                dt.Rows[index].Delete();

                string name = txtName.Text;
                double cost = Convert.ToDouble(numupdwnCost.Text);
                string tenant = txtTenantName.Text;
            
                this.totalAmount += cost;
                dt.Rows.Add(name, cost, tenant);
            
                GetTotalAmount();
                ClearFields();
            }

        }

        private void btnDeleteEdit_Click(object sender, EventArgs e)
        {
            int index = dtgrdGroceries.CurrentCell.RowIndex;
            
            dt.Rows[index].Delete();
            GetTotalAmount();
        }


        private void cellDoubleClicked(object sender, EventArgs e)
        {
            int index = dtgrdGroceries.CurrentCell.RowIndex;
            //tabPage.SelectedTab = tabPageEdit;

            txtName.Text = dt.Rows[index].ItemArray[0].ToString();
            numupdwnCost.Text = dt.Rows[index].ItemArray[1].ToString();
            txtTenantName.Text = dt.Rows[index].ItemArray[2].ToString();
        }

    }
}
