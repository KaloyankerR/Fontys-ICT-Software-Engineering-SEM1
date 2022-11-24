namespace MultipleForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button lbl = new Button();
            lbl.Text = "Lorem";
            lbl.Size = new Size(200, 200);

            flwLytPnl.Controls.Add(lbl);
        }
    }
}