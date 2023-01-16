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
    public partial class Register : Form
    {
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ZipcodeAndCity { get; set; }

        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Name = txtName.Text;
            this.PhoneNo = txtPhoneNo.Text;
            this.Email = txtEmail.Text != "" ? txtEmail.Text : "Not given";
            this.Address = txtAddress.Text;
            this.ZipcodeAndCity = txtZipcodeAndCity.Text;

            DialogResult = DialogResult.OK;
        }

    }
}
