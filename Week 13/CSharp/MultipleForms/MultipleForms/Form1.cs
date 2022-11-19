namespace MultipleForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRedirect_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();

            this.Hide();

        }
    }
}