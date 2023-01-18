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
    public partial class DashboardView : Form
    {
        User usr;

        public DashboardView()
        {
            InitializeComponent();
            // usr = new User("Timo", "1234", true);
        }

        public void CreateUser(string name, string password, bool isUserAdmin)
        {
            usr = new User(name, password, isUserAdmin);
        }

        public bool isAdmin()
        {
            return usr.isValid();
        }

        private void btnToComplaintsPage_Click(object sender, EventArgs e)
        {
            var window = new Complaints(this);
            window.Show();
        }

        private void btnToAgreementsPage_Click(object sender, EventArgs e)
        {
            var window = new AgreementForm(this);
            window.Show();
        }

        private void btnToAnnouncementPage_Click(object sender, EventArgs e)
        {
            var window = new AnnouncementsForm();
            window.Show();
        }

        private void btnToCalculatorPage_Click(object sender, EventArgs e)
        {
            var window = new GroceriesCalculator();
            window.Show();
        }

        private void btnToHouseRules_Click(object sender, EventArgs e)
        {
            var window = new HomePage(this);
            window.Show();
        }

        private void ShowRecentComplaint()
        {
            listDashboardComplaints.Items.Clear();
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream("C:\\Users\\panay\\Desktop\\Project\\software-housing-project\\HousingAgency\\text filles for dashboard\\Complaints.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                string s;
                while (!sr.EndOfStream)
                {
                    s = sr.ReadLine();
                    listDashboardComplaints.Items.Add(s);
                }
            }
            catch (IOException)
            { MessageBox.Show("Error reading file"); }
            finally
            { if (sr != null) { sr.Close(); } }
        }

        private void ShowHouseRules()
        {
            listDashboardHouseRules.Items.Clear();
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream("C:\\Users\\panay\\Desktop\\Project\\software-housing-project\\HousingAgency\\text filles for dashboard\\HouseRules.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                string s;
                while (!sr.EndOfStream)
                {
                    s = sr.ReadLine();
                    listDashboardHouseRules.Items.Add(s);
                }
            }
            catch (IOException)
            { MessageBox.Show("Error reading file"); }
            finally
            { if (sr != null) { sr.Close(); } }
        }

        private void ShowRecentAnnouncement()
        {
            listDashboardAnnouncements.Items.Clear();
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream("C:\\Users\\panay\\Desktop\\Project\\software-housing-project\\HousingAgency\\text filles for dashboard\\Announcement.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                string s;
                while (!sr.EndOfStream)
                {
                    s = sr.ReadLine();
                    listDashboardAnnouncements.Items.Add(s);
                }
            }
            catch (IOException)
            { MessageBox.Show("Error reading file"); }
            finally
            { if (sr != null) { sr.Close(); } }
        }

        private void ShowRecentAgreement()
        {
            listDashboardAgreements.Items.Clear();  
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream("C:\\Users\\panay\\Desktop\\Project\\software-housing-project\\HousingAgency\\text filles for dashboard\\Agreement.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                string s;
                while (!sr.EndOfStream)
                {
                    s = sr.ReadLine();
                    listDashboardAgreements.Items.Add(s);
                }
            }
            catch (IOException)
            { MessageBox.Show("Error reading file"); }
            finally
            { if (sr != null) { sr.Close(); } }
        }

        private void btnToTaskTablePage_Click(object sender, EventArgs e)
        {
            var window = new TaskForm();
            window.Show();
        }

        private void ShowTasks()
        {
            listDashboardTasks.Items.Clear();
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream("C:\\Users\\panay\\Desktop\\Project\\software-housing-project\\HousingAgency\\text filles for dashboard\\Task.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                string s;
                while (!sr.EndOfStream)
                {
                    s = sr.ReadLine();
                    listDashboardTasks.Items.Add(s);
                }
            }
            catch (IOException)
            { MessageBox.Show("Error reading file"); }
            finally
            { if (sr != null) { sr.Close(); } }
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            ShowRecentAgreement();
            ShowRecentAnnouncement();
            ShowRecentComplaint();
            ShowTasks();
            ShowHouseRules();
        }
    }
}
