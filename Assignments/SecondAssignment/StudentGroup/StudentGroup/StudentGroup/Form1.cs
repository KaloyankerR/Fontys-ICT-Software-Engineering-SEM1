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

        private void Form1_Load(object sender, EventArgs e)
        {
            WriteInComboBoxes();
        }

        // ---------------------------
        public void WriteInListBox(List<string> members)
        {
            listbxMembers.Items.Clear();

            foreach (string member in members)
            {
                listbxMembers.Items.Add(member);
            }

        }

        public void WriteInComboBoxes()
        {
            combobxProjectGroups.Items.Clear();
            combobxProjectGroups2.Items.Clear();

            foreach (string group in sqlConn.GetProjectGroups())
            {
                combobxProjectGroups.Items.Add(group);
                combobxProjectGroups2.Items.Add(group);
            }

        }

        // ----------------------------

        private void btnShow_Click(object sender, EventArgs e)
        {
            List<string> res = sqlConn.GetGroupMembers(combobxProjectGroups.Text);
            WriteInListBox(res);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sqlConn.AddMember(txtName.Text, combobxProjectGroups.Text);
            List<string> res = sqlConn.GetMembers();
            WriteInListBox(res);

            txtName.Text = "";
            combobxProjectGroups.Text = "";
        }

        private void btnAddMember_Click_1(object sender, EventArgs e)
        {
            sqlConn.AddMember(txtName.Text, combobxProjectGroups2.Text);
            txtName.Text = "";
            combobxProjectGroups2.Text = "";

        }

        // Showing members of current project group
        private void combobxProjectGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            listbxMembers.Items.Clear();
            List<string> res = sqlConn.GetGroupMembers(combobxProjectGroups.Text);

            foreach (string member in res)
            {
                listbxMembers.Items.Add(member);
            }
        }

        private void btnAddGroupAdd_Click(object sender, EventArgs e)
        {
            sqlConn.AddProjectGroup(txtAddGroupName.Text);
            combobxProjectGroups.Items.Clear();

            foreach (string group in sqlConn.GetProjectGroups())
            {
                combobxProjectGroups.Items.Add(group);
            }

            txtAddGroupName.Text = "";
            WriteInComboBoxes();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            sqlConn.HardReset();
            WriteInComboBoxes();
        }
    }
}