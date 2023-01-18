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
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Label txt = new Label();
            txt.Text = "Hello world";

            flwLayoutPnlRules.Controls.Add(txt);
        }
    }
}
