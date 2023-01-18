using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HousingAgency
{
    public partial class Login : Form
    {
        Form1 f1;
        DataTable dt;
        SqlProjectExecutor sqlConn;

        public Login()
        {
            InitializeComponent();
            f1 = new Form1();
            sqlConn = new SqlProjectExecutor();
            txtPassword.PasswordChar = '*';
        }

        private void AddElements()
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (sqlConn.isCorrect(txtUsername.Text, txtPassword.Text))
            {
                DashboardView dv = new DashboardView();
                bool isUserAdmin = sqlConn.isAdmin(txtUsername.Text);
                dv.CreateUser(txtUsername.Text, txtPassword.Text, isUserAdmin);

                Hide();
                dv.Show();
            }
            else
            {
                MessageBox.Show("Incorrect details!");
            }

            // Old login (Hardcoded)
            //bool isThere = false;
            //for (int r = 0; r < dataGridView1.Rows.Count; r++)
            //{
            //    if (dataGridView1[r][0] == "asdas")
            //    {
            //            // pass
            //    }   
            //}

            //if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            //{
            //    f1.Show();
            //    this.Hide();
            //} else
            //{
            // MessageBox.Show("Incorrect details!");
            //} 
        }

        private void lblForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(
                "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe",
                "https://friendlyhousing.nl/en/contact");
        }

    }
}
