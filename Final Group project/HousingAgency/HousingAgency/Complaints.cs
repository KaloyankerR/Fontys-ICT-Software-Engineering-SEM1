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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HousingAgency
{
    public partial class Complaints : Form
    {
        DashboardView dv;
        ComplaintModel myComplaint;
        DataTable dt = new DataTable();

        public Complaints(DashboardView instanceDv)
        {
            InitializeComponent();
            dt.Columns.Add("Level", typeof(String));
            dt.Columns.Add("Title", typeof(String));
            dt.Columns.Add("Description", typeof(String));

            dtgViewComplaints.DataSource = dt;
            dtgViewComplaints.Columns["Level"].Width = 150;
            dtgViewComplaints.Columns["Title"].Width = 300;
            dtgViewComplaints.Columns["Description"].Width = 500;

            dv = instanceDv;
            //tabPageEditComplaint.Visible = dv.isAdmin();
        }


        private void btnSubmitComplaint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTxtDescriptionComplaint.Text) || string.IsNullOrEmpty(richtxtTitleComplaint.Text) || string.IsNullOrEmpty(comBComplaintLevel.Text))
            { return; }

            string level = comBComplaintLevel.Text;
            string title = richtxtTitleComplaint.Text;
            string description = richTxtDescriptionComplaint.Text;
            ComplaintModel myComplaint = new ComplaintModel(level, title, description);

            dt.Rows.Add(myComplaint.GetLevel(), myComplaint.GetTitle(), myComplaint.Getdescription());
            SaveData();
            ClearFields();
        }
        private void ClearFields()
        {
            comBComplaintLevel.Text = "";
            richTxtDescriptionComplaint.Text = "";
            richtxtTitleComplaint.Text = "";
        }

        private void btnDeleteComplaint_Click(object sender, EventArgs e)
        {
            int index = dtgViewComplaints.CurrentCell.RowIndex;
            dt.Rows[index].Delete();
        }

        private void btnEditComplain_Click(object sender, EventArgs e)
        {
            int index = dtgViewComplaints.CurrentCell.RowIndex;

            string level = comBComplaintLevel.Text;
            string title = richtxtTitleComplaint.Text;
            string description = richTxtDescriptionComplaint.Text;

           if (comBComplaintLevel.Text != "" && richtxtTitleComplaint.Text != "" && richTxtDescriptionComplaint.Text != "")
            {
                dt.Rows[index].Delete();
                ComplaintModel myComplaint = new ComplaintModel(level, title, description);
                dt.Rows.Add(myComplaint.GetLevel(), myComplaint.GetTitle(), myComplaint.Getdescription());
            }
            else
            {
                MessageBox.Show("Not enough data provided!", "ERROR");
            }
            ClearFields();
        }

        private void dtgViewComplaints_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControlForComplaints.SelectedTab = tabPageAddComplaint;
        }

        private void SaveData()
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream("C:\\Users\\panay\\Desktop\\Project\\software-housing-project\\HousingAgency\\text filles for dashboard\\Complaints.txt", FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);
                string level = comBComplaintLevel.Text;
                string title = richtxtTitleComplaint.Text;
                string description = richTxtDescriptionComplaint.Text;

                sw.WriteLine(level + " " + title + " " + description);
                    

            }
            catch (IOException ex)
            { MessageBox.Show("Error writing file"); }
            finally
            { if (sw != null) { sw.Close(); } }
        }

    }
}
