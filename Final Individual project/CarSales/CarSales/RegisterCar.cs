using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSales
{
    public partial class RegisterCar : Form
    {
        public string Brand;
        public string Model;
        public string YearProduced;
        public string BasePrice;

        public RegisterCar()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Brand = txtBrand.Text;
            this.Model = txtModel.Text;
            this.YearProduced = txtYearProduced.Text;
            this.BasePrice = txtBasePrice.Text;

            DialogResult = DialogResult.OK;
        }
    }
}
