using StudentGroup;

namespace LoginDemo
{
    public partial class Form1 : Form
    {
        SqlProjectExecutor sqlConn;

        public Form1()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            sqlConn = new SqlProjectExecutor();
        }

        private void WriteInListBox()
        {
            lsbxMemberNames.Items.Clear();

            foreach (string name in sqlConn.GetMemberNames())
            {
                lsbxMemberNames.Items.Add(name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WriteInListBox();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (sqlConn.isCorrect(txtName.Text, txtPassword.Text))
            {
                lblResult.Text = "Yeah bodyy";
            }
            else
            {
                lblResult.Text = "Nah";
            }

            WriteInListBox();
        }

    }
}