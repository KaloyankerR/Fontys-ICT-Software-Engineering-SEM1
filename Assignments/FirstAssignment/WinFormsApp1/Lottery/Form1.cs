namespace Lottery
{
    public partial class Form1 : Form
    {
        Lottery lottery;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMaxValue.Text = "0";
            txtNrNums.Text = "0";
        }

        private void btnCreateObj_Click(object sender, EventArgs e)
        {
            int maxValue = Convert.ToInt16(txtMaxValue.Text);
            int nr = Convert.ToInt16(txtNrNums.Text);

            this.lottery = new Lottery(maxValue, nr);
            btnDraw.Enabled = true;
            btnDrawAll.Enabled = true;
        }

        private void txtMaxValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            string result = lottery.DrawNextNumber().ToString();

            lstbxNumbers.Items.Clear();
            lstbxNumbers.Items.Add($"The number drawn is {result}");
        }
    }
}