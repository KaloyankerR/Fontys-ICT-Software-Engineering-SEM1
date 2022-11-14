namespace BankAccountFormsApp
{
    public partial class Form1 : Form
    {
        BankAccount client;

        public Form1()
        {
            InitializeComponent();
            client = new BankAccount();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            /*
            string name = txtName.Text;
            string password = txtPassword.Text;
            double balance = Convert.ToDouble(txtBalance.Text);
            int pin = Convert.ToInt32(txtPin.Text);

            client.SetCredentials(name, password);
            client.SetBalance(balance);
            client.SetPinNumber(pin);

            lblRepresent.Text = client.Represent();
            */
        }

    }
}