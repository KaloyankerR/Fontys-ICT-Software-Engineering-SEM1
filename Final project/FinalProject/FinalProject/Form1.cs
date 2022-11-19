using System.Data;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        DataTable table;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Author", typeof(String));
            table.Columns.Add("Header", typeof(String));

            dtgrdComplaints.DataSource = table;
            // dtgrdComplaints.Columns["Header"]
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ComplaintForm complaintForm = new ComplaintForm();
            complaintForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}