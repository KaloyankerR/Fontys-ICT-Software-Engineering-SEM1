using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    public partial class AddForm : Form
    {
        //public AddForm(Bakery b)
        //{
        //    InitializeComponent();
        //}

        public AddForm()
        {
            InitializeComponent();
            cbbBreadFilter.SelectedIndex = 1;
        }

        public string GetName()
        {
            return tbxName.Text;
        }

        public string GetBread()
        {
            return cbbBreadFilter.Text;
        }

        public string GetIngredients()
        {
            return richtbxIngredients.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbxName.Text != "" && richtbxIngredients.Text != "")
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.No;
            }
            Close();

            //MainForm mainFrm = new MainForm();
            //string txt = tbxName.Text;
            //mainFrm.AddSandwich(txt);
        }
    }
}
