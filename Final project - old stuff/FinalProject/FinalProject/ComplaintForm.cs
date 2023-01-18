using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ComplaintForm : Form
    {
        public static ComplaintForm instance;
        public TextBox tbAuthor;
        public TextBox tbTopic;

        public ComplaintForm()
        {
            InitializeComponent();
            instance = this;
            tbAuthor = txtAuthor;
            tbTopic = txtTopic;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1.instance.dt.Rows.Add(txtAuthor, txtTopic);
        }
    }
}
