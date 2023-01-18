using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HousingAgency
{
    public partial class AnnouncementsForm : Form
    {
        Announcement announcement;
        string[] displayItems;
        //ListViewItem listView;
        List<string[]> savedData = new List<string[]>();
        public AnnouncementsForm()
        {
            InitializeComponent();

        }
        
        private void btnSendData_Click(object sender, EventArgs e)
        {

            string title = txtbTitle.Text;
            string descritption = txtbDescription.Text;
            announcement = new Announcement(title, descritption);

            displayItems = new string[3];
            displayItems[0] = announcement.GetDate();
            displayItems[1] = announcement.GetTitle();
            displayItems[2] = announcement.GetDiscription();
            //listView = new ListViewItem(displayItems);
            //lvDisplay.Items.Add(listView);
            savedData.Add(displayItems);
            //dgbDisplay.Rows.Insert(0,displayItems);
            refreshdisplay();
            SaveData();
            txtbTitle.Text = "";
            txtbDescription.Text = "";
            MessageBox.Show("Announcement added!", "Thank you");
        }

        public void refreshdisplay()
        {
           dgbDisplay.Rows.Clear();
           foreach (string[] data in savedData)
            {
                dgbDisplay.Rows.Insert(0, data);
            } 
        }

        private void SaveData()
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream("C:\\Users\\panay\\Desktop\\Project\\software-housing-project\\HousingAgency\\text filles for dashboard\\Announcement.txt", FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);

                string title = txtbTitle.Text;
                string descritption = txtbDescription.Text;

                sw.WriteLine(title + " " + descritption);


            }
            catch (IOException ex)
            { MessageBox.Show("Error writing file"); }
            finally
            { if (sw != null) { sw.Close(); } }
        }
    }
}
