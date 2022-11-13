namespace Movies
{
    public partial class Form1 : Form
    {
        private int locationElement = 12;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Label lbl = new Label();
            lbl.Text = $"New - {locationElement}";
            Controls.Add(lbl);
            lbl.Location = new Point(12, locationElement);
            locationElement += 25;
        }
    }
}