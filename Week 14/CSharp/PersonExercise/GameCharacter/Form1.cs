namespace GameCharacter
{
    public partial class Form1 : Form
    {
        GameCharacter game;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtHealth.Text != string.Empty)
            {
                game = new GameCharacter(txtName.Text, Convert.ToInt32(txtHealth.Text));
            } else
            {
                game = new GameCharacter(txtName.Text);
            }

            txtName.Enabled = false;
            txtHealth.Enabled = false;
            btnSubmit.Enabled = false;
            lblResult.Text = game.GetInfo();
        }

        private void btnDamage_Click(object sender, EventArgs e)
        {
            game.ReceivedDamage(Convert.ToInt32(txtDamage.Text));
            txtDamage.Text = "";
            lblResult.Text = game.GetInfo();
        }
    }
}