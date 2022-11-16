namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string brand = "Tates' Bugatti";
        private int speed = 0;
        private int maxSpeed = 240;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            this.speed += 7;
            if (speed > maxSpeed)
            {
                this.speed -= 7;
                MessageBox.Show("Your car isn't that fast, slow down");
            }

            lblResult.Text = $"{this.brand} speed is {this.speed} and" +
                $"has a maximum speed of {this.maxSpeed}";
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            /*
            this.speed = (this.speed - 10 < 0) ? 
                this.speed : this.speed - 10;
            */
            this.speed -= 10;
            if (speed < 0)
            {
                this.speed += 10;
                MessageBox.Show("Your car cannot go slower");
            }

            lblResult.Text = $"{this.brand} speed is {this.speed} and" +
                $"has a maximum speed of {this.maxSpeed}";
        }
    }
}