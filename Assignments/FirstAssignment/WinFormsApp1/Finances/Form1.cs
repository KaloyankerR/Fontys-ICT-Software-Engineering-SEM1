namespace Finances
{
    public partial class Form1 : Form
    {
        List<string[]> expenses = new List<string[]>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // GetInfo();
        }

        public string GetInfo()
        {
            for (int i = 0; i < this.expenses.Count; i++)
            {
                lsbxExpenses.Items.Add($"{this.expenses[i][0]} - {this.expenses[i][1]}");
            }

            return "Ebi si maikata";
        }

        private void btnAddExpenses_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || numupdwnAmount.Text == "0.00")
            {
                MessageBox.Show("Please enter data in the Expenses form", "No data");

            } else
            {
                string[] dataToAdd = { txtName.Text, numupdwnAmount.Text };
                this.expenses.Add(dataToAdd);
                lsbxExpenses.Items.Add($"{txtName.Text} - {numupdwnAmount.Text}$");

                txtName.Text = "";
                numupdwnAmount.Text = "0.00";
                    
            }
        }

        private void btnShowExpenses_Click(object sender, EventArgs e)
        {
            if (!(lsbxExpenses.Items.Count == this.expenses.Count))
            {
                lsbxExpenses.Items.Clear();
                this.GetInfo();
            }
            
        }

        private void btnClearExpenses_Click(object sender, EventArgs e)
        {
            lsbxExpenses.Items.Clear();
        }

        private void btnShowSameExpenses_Click(object sender, EventArgs e)
        {
            if (numupdwnSameExpenses.Text != "0.00")
            {
                lsbxExpenses.Items.Clear();

                for (int i = 0; i < this.expenses.Count; i++)
                {
                    if (this.expenses[i][1] == numupdwnSameExpenses.Text)
                    {
                        lsbxExpenses.Items.Add
                            ($"{this.expenses[i][0]} - {this.expenses[i][1]}");
                    }
                }

            }
            
        }

        // Not used
    }
}