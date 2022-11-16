namespace ComplexStuff
{
    public partial class Form1 : Form
    {
        private string drink = "";
        private string[] alcDrinks = { "Wiskey", "Vodka", "Rakia" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkCondition()
        {
            /*
            if (chbxAge.Checked && rdbtnRakia.Checked)
            {
                this.drink = rdbtnRakia.Text;
                lblResult.Text = this.drink;
            }
            else if (rdbtnCoke.Checked)
            {
                this.drink = rdbtnCoke.Text;
                lblResult.Text = this.drink;
            }
            else
            {
                lblResult.Text = "You don't have the age for drinking alchohol :(";
            }
            */
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            bool isAlch = Array.Exists
                (this.alcDrinks, element => element == cmbDrink.Text);

            if (isAlch)
            {
                if (chbxAge.Checked)
                {
                    lbxDrinks.Items.Add(cmbDrink.Text);
                } else
                {
                    MessageBox.Show("You don't have 18");
                }
            }
            else
            {
                if (cmbDrink.Text == "Sparkling water")
                {
                    System.Media.SoundPlayer player = 
                        new System.Media.SoundPlayer(@"C:\Users\User\OneDrive\Documents\University\AndrewTateSong.wav");
                    
                    player.Play();
                }
                else
                {
                    lbxDrinks.Items.Add(cmbDrink.Text);
                }
            }

        }

        private void chbxAge_CheckedChanged(object sender, EventArgs e)
        {
            checkCondition();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbxDrinks.Items.Clear();
        }
    }
}