namespace ListBoxExercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblResult.Text = comboBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstBoxDrinks.Items.Add(comboBox1.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstBoxDrinks.Items.Clear();
        }
    }
}