namespace HelloName.App
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGreeting_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            lblResult.Text = $"Hello {name}";
        }
    }
}