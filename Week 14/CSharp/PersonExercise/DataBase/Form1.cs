using System.Data.SqlClient;

namespace DataBase
{
    public partial class Form1 : Form
    {
        SqlConnection conn;

        public Form1()
        {
            InitializeComponent();

            conn = new SqlConnection("server=mssqlstud.fhict.local;database=dbi500862;uid=dbi500862;password=Mkw4PQHJeU;");
            
            string sql = "SELECT email FROM user ORDER BY email;";
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();

            label1.Text = sql;

            conn.Close();
        }


    }
}