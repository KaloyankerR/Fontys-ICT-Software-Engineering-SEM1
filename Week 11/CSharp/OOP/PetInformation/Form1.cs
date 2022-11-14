using System.Data;

namespace PetInformation
{
    public partial class Form1 : Form
    {
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("Name", typeof(String));
            dt.Columns.Add("Type", typeof(String));
            dt.Columns.Add("Description", typeof(String));

            dataGridView1.DataSource = dt;
            
            dataGridView1.Columns["Name"].Width = 225;
            dataGridView1.Columns["Type"].Width = 225;
            //dataGridView1.Columns["Description"].Width = 149;

            dataGridView1.Columns["Description"].Visible = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtName.Text, txtPet.Text, txtDescription.Text);
            txtName.Clear();
            txtPet.Clear();
            txtDescription.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dt.Rows[index].Delete();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                txtName.Text = dt.Rows[index].ItemArray[0].ToString();
                txtPet.Text = dt.Rows[index].ItemArray[1].ToString();
                txtDescription.Text = dt.Rows[index].ItemArray[2].ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPet.Clear();
            txtDescription.Clear();
        }
    }
}