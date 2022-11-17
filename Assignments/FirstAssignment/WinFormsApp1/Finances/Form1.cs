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
            GetInfo();
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
            string[] dataToAdd = { txtName.Text, numupdwnAmount.Text };
            this.expenses.Add(dataToAdd);
            // lsbxExpenses.Items.Add($"{this.expenses[i][0]} - {this.expenses[i][1]}");
        
            txtName.Text = "";
            numupdwnAmount.Text = "";
        }

        private void lsbxExpenses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}