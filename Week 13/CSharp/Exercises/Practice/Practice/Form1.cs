using System.Diagnostics.Metrics;

namespace Practice
{
    public partial class Form1 : Form
    {
        enum Seasons
        {
            Spring = 0,
            Autumn = 1,
            Summer = 2,
            Winter = 3
        }

        private int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            counter++;

            if (counter == 4)
            {
                counter = 0;
            }

            Seasons day = (Seasons)counter;
            lblSeason.Text = day.ToString();
        }
    }
}