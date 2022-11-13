namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        protected double expressionToSolve;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            expressionToSolve = 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn9.Text;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            double expression = Convert.ToDouble(txtResult.Text);
            txtResult.Clear();
            expressionToSolve += expression;
            txtResult.Text = Convert.ToString(expressionToSolve);
        }

    }
}