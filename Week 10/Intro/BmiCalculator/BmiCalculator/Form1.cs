namespace BmiCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rdbtnBG_CheckedChanged(object sender, EventArgs e)
        {
            string nationality = rdbtnBG.Text;
            lblNationality.Text = nationality;
        }

        private void rdbtnNL_CheckedChanged(object sender, EventArgs e)
        {
            string nationality = rdbtnNL.Text;
            lblNationality.Text = nationality;
        }

        private void rdbtnMan_CheckedChanged(object sender, EventArgs e)
        {
            string gender = rdbtnMan.Text;
            lblGender.Text = gender;
        }

        private void rdbtnWomen_CheckedChanged(object sender, EventArgs e)
        {
            string gender = rdbtnWomen.Text;
            lblGender.Text = gender;
        }
    }
}