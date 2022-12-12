using System.IO;
using System.Data.SqlClient;

namespace WritingInFiles
{
    public partial class Form1 : Form
    {
        StreamWriter sw;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            string path = "D:\\Github repositories\\Fontys-ICT-Software-Engineering-SEM1-\\demo.txt";

            // string createText = "proba";

            // File.WriteAllText(path, txtText.Text);
            File.AppendAllText(path, txtText.Text + Environment.NewLine);

            // string readText = File.ReadAllText(path);
            txtText.Text = "";
        }

    }
}