namespace TimerApp
{
    public partial class TimerForm : Form
    {
        public TimerForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            // MessageBox.Show(DateTime.Now.ToString());
            lblResult.Text = DateTime.Now.ToString();
        }
    }
}