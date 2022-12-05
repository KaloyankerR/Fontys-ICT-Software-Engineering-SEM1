namespace PersonExercise
{
    public partial class Form1 : Form
    {
        Person person;

        public Form1()
        {
            InitializeComponent();    
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            person = new Person();
            person.FirstName = txtFirstName.Text;
            person.LastName = txtLastName.Text;
            person.Gender = txtGender.Text;
            person.BirthYear = Convert.ToInt16(txtBirthYear.Text);

            lblResult.Text = person.GetInfo();
        }
    }
}