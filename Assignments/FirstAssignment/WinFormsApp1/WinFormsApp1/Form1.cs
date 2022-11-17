namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string brand = "Tates' Bugatti";
        private int speed = 0;
        private int maxSpeed = 240;

        private string brandSecond = "Babushka Lada";
        private int speedSecond = 0;
        private int maxSpeedSecond = 100;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblResult.Text = $"{this.brand} speed is {this.speed} and" +
                $"has a maximum speed of {this.maxSpeed}";

            lblSecondCar.Text = $"{this.brandSecond} speed is {this.speedSecond} and" +
                $"has a maximum speed of {this.maxSpeedSecond}";
        }

        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            this.speed += 7;
            if (this.speed > this.maxSpeed)
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

        private void btnAccelerate2_Click(object sender, EventArgs e)
        {
            this.speedSecond += 7;
            if (this.speedSecond > this.maxSpeedSecond)
            {
                this.speedSecond -= 7;
                MessageBox.Show("Your car isn't that fast, slow down");
            }

            lblSecondCar.Text = $"{this.brandSecond} speed is {this.speedSecond} and" +
                $"has a maximum speed of {this.maxSpeedSecond}";
        }

        private void btnBreak2_Click(object sender, EventArgs e)
        {
            this.speedSecond -= 10;
            if (this.speedSecond < 0)
            {
                this.speedSecond += 10;
                MessageBox.Show("Your car cannot go slower");
            }

            lblSecondCar.Text = $"{this.brandSecond} speed is {this.speedSecond} and" +
                $"has a maximum speed of {this.maxSpeedSecond}";
        }
    }
}