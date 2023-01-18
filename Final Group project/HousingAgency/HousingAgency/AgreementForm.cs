using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using HousingAgency;

namespace HousingAgency
{
    public partial class AgreementForm : Form
    {
        DashboardView dv;
        List<Agreement> MyAgreement;

        public AgreementForm(DashboardView dv)
        {
            InitializeComponent();
            MyAgreement = new List<Agreement>();
            this.dv = dv;
            groupbxAgreementsAdmin.Visible = dv.isAdmin();
            UpdateListBox();
        }

        // Class methods
        private void UpdateListBox()
        {
            lbAgreements.Items.Clear();

            foreach (var item in MyAgreement)
            {
                lbAgreements.Items.Add(item.Display());
            }
        }

        private void DeleteAgreement(int index)
        {
            MyAgreement.RemoveAt(index);
        }

        private void btnAddAgreement_Click(object sender, EventArgs e)
        {
            string agreement = txtAgreement.Text;
            Agreement newAgreement = new Agreement();
            newAgreement.SetAgreement(agreement);
            MyAgreement.Add(newAgreement);
            SaveData();

            UpdateListBox();
            txtAgreement.Text = "";
        }

        //private void btnAgreementsApprove_Click(object sender, EventArgs e)
        //{}

        //private void btnAgreementsDisapprove_Click(object sender, EventArgs e)
        //{}

        //private void btnAgreementsDelete_Click(object sender, EventArgs e)
        //{}

        private void SaveData()
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                // fs = new FileStream("C:\\Users\\panay\\Desktop\\Project\\software-housing-project\\HousingAgency\\text filles for dashboard\\Agreement.txt", FileMode.OpenOrCreate, FileAccess.Write);
                fs = new FileStream("Agreement.txt", FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);

                string agreement = txtAgreement.Text;

                sw.WriteLine(agreement);


            }
            catch (IOException ex)
            { MessageBox.Show("Error writing file"); }
            finally
            { if (sw != null) { sw.Close(); } }
        }

        private void btnAgreementsApprove_Click_1(object sender, EventArgs e)
        {
            int ind = lbAgreements.SelectedIndex;
            // string res = lbAgreements.Items[ind].ToString();

            MyAgreement[ind].AgreementElement += " ✔️";

            //res += " ✔️";
            //lbAgreements.Items[ind] = res;
            UpdateListBox();
        }

        private void btnAgreementsDisapprove_Click_1(object sender, EventArgs e)
        {
            int ind = lbAgreements.SelectedIndex;
            MyAgreement[ind].AgreementElement += " ❌";

            UpdateListBox();
        }

        private void btnAgreementsDelete_Click_1(object sender, EventArgs e)
        {
            int ind = lbAgreements.SelectedIndex;
            DeleteAgreement(ind);

            UpdateListBox();
        }
    }
}
