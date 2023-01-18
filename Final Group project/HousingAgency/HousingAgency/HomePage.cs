using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace HousingAgency
{
    public partial class HomePage : Form
    {
        DashboardView dv;
        // User user = new User("admin", "admin", true);

        public HomePage(DashboardView dv)
        {
            InitializeComponent();
            this.dv = dv;
            if (!dv.isAdmin())
            {
                tabControlHomePage.TabPages.Remove(this.tabHouseRulesBackend);
            }
            // tabHouseRulesBackend.Visible = dv.isAdmin();
        }

        //public bool GetIsAdmin()
        //{
        //    return user.IsAdmin;
        //}

        public void linkToLandLord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://friendlyhousing.nl/en/contact",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        public void btnCreateRule_Click(object sender, EventArgs e)
        {
            string description = richRules.Text;
            int id = Convert.ToInt32(numIDRule.Text);
            HouseRule rule = new HouseRule(id, description);
            listRules.Items.Add(rule.GetInfo());
            richRules.Clear();
            SaveDataRules();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listRules.Items.Clear();
        }

        private void btnDeleteRule_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(numRuleIndex.Text);
            listRules.Items.RemoveAt(index - 1);
            numRuleIndex.Text = "0";
        }

        private void SaveDataRules()
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream("C:\\Users\\panay\\Desktop\\Project\\software-housing-project\\HousingAgency\\text filles for dashboard\\HouseRules.txt", FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);
                foreach (var rule in listRules.Items)
                {
                    sw.WriteLine(rule);
                }

            }
            catch (IOException ex)
            { MessageBox.Show("Error writing file"); }
            finally
            { if (sw != null) { sw.Close(); } }
        }
    }
}
