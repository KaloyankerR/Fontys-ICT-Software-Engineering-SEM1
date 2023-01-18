using System.Data;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        DataTable table;
        ComplaintForm complaintForm = new ComplaintForm();
        public static Form1 instance;
        public DataTable dt;

        public Form1()
        {
            InitializeComponent();
            instance = this;
            dt = table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Author", typeof(String));
            table.Columns.Add("Topic", typeof(String));

            dtgrdComplaints.DataSource = table;
            dtgrdComplaints.Columns["Author"].Width = 475;
            dtgrdComplaints.Columns["Topic"].Width = 475;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.complaintForm.ShowDialog();
        }

        public void AddData(string author, string topic)
        {
            table.Rows.Add(author, topic);
            complaintForm.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}