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
    public partial class TaskForm : Form
    {

        List<Task> tasks = new List<Task>();
        
        public TaskForm()
        {
            InitializeComponent();
        }

        private void btnAssignTaskMemebr_Click(object sender, EventArgs e)
        {
            string user = cmbUsers.Text;
            string description = txbDescription.Text;
            tasks.Add(new Task(user,description));
            txbDescription.Clear();
            UpdateTaskDisplay();
            SaveData();
        }

        private void UpdateTaskDisplay()
        {
            lbDisplayTasks.Items.Clear();
            foreach(Task task in tasks)
            {
                lbDisplayTasks.Items.Add(task.GetInfo()); 
            }
        }

        private void btnRemoveFromTask_Click(object sender, EventArgs e)
        {
            try
            {
                int index = lbDisplayTasks.SelectedIndex;
                tasks.RemoveAt(index);
            }
            catch { }
            finally
            {
                UpdateTaskDisplay();
            }
            
            
        }

        private void SaveData()
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream("C:\\Users\\panay\\Desktop\\Project\\software-housing-project\\HousingAgency\\text filles for dashboard\\Task.txt", FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);
                foreach (var task in lbDisplayTasks.Items)
                {
                    sw.WriteLine(task);
                }

            }
            catch (IOException ex)
            { MessageBox.Show("Error writing file"); }
            finally
            { if (sw != null) { sw.Close(); } }
        }
    }
}
