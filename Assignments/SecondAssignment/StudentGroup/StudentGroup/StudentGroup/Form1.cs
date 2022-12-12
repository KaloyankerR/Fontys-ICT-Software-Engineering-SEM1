using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StudentGroup
{
    public partial class Form1 : Form
    {
        SqlProjectExecutor sqlConn;

        public Form1()
        {
            InitializeComponent();
            ProjectGroup pg = new ProjectGroup("Team");
            pg.AddMember("Kalo");
            sqlConn = new SqlProjectExecutor();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string res = sqlConn.ReadValues();
            label1.Text = res;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sqlConn.InsertValue(txtName.Text);
            string res = sqlConn.ReadValues();
            label1.Text = res;
        }
    }
}