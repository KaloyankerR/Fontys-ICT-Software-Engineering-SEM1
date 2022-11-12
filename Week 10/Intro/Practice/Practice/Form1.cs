namespace Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void celsiusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double celsiusValue = Double.Parse(celsiusTextBox.Text);
            double result = (celsiusValue * 9 / 5);

        }

        private void fahrenheitTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}