namespace BmiCalculator
{
    public partial class Form1 : Form
    {
        private double[] archieve = { 0, 0 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            double weight = Convert.ToDouble(txtWeight.Text);
            double height = (Convert.ToDouble(txtHeight.Text)) / 100;
            
            double bmi= Math.Round(weight / (height * height), 2);
            string resultMsg = $"Your BMI index is {bmi}\n";

            if (bmi < 18.5)
            {
                resultMsg += "You're underweight";
            } else if (bmi < 24.9) {
                resultMsg += "You're normal";
            } else if (bmi < 29.9) {
                resultMsg += "You're overweight";
            } else {
                resultMsg += "You're obese";
            }
            

            lblResult.Text = resultMsg;

            archieve[0] = weight;
            archieve[1] = height;

            using (StreamWriter writer = new StreamWriter("D:\\Github repositories\\Fontys-ICT-Software-Engineering-SEM1-\\Week 10\\WinForms\\BmiCalculator\\BmiCalculator\\archieve.txt"))
            {
                writer.WriteLine(archieve[0]);
                writer.WriteLine(archieve[1]);
            }
        }
    }
}