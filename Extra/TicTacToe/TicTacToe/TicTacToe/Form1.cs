namespace TicTacToe
{
    public partial class MainForm : Form
    {
        private string symbol = "X";
        private int count = 1;
        private Button[] btns;

        // private Button[] btns;
        // private Button[] btns = new Button[9];

        public MainForm()
        {
            InitializeComponent();
            InitializeBtns();
        }

        private void InitializeBtns()
        {
            btns = new Button[9] { btnGrid1, btnGrid2, 
                btnGrid3, btnGrid4, btnGrid5, btnGrid6, 
                btnGrid7, btnGrid8, btnGrid9};

            //btns = { btnGrid1, btnGrid2, btnGrid3, btnGrid4,
            //        btnGrid5, btnGrid6, btnGrid7, btnGrid8, btnGrid9};
        }

        private void NextTurn()
        {
            if (count % 2 == 0)
            {
                symbol = "X";
            } else
            {
                symbol = "O";
            }

            count++;
        }

        private bool Logic()
        {
            if ((btnGrid1.Text == btnGrid2.Text) && (btnGrid2.Text == btnGrid3.Text) && (!btnGrid2.Enabled))
                return true;
            else if ((btnGrid4.Text == btnGrid5.Text) && (btnGrid5.Text == btnGrid6.Text) && (!btnGrid5.Enabled))
                return true;
            else if ((btnGrid7.Text == btnGrid8.Text) && (btnGrid8.Text == btnGrid9.Text) && (!btnGrid8.Enabled))
                return true;

            // |||
            else if ((btnGrid1.Text == btnGrid4.Text) && (btnGrid4.Text == btnGrid7.Text) && (!btnGrid4.Enabled))
                return true;
            else if ((btnGrid2.Text == btnGrid5.Text) && (btnGrid5.Text == btnGrid8.Text) && (!btnGrid5.Enabled))
                return true;
            else if ((btnGrid3.Text == btnGrid6.Text) && (btnGrid6.Text == btnGrid9.Text) && (!btnGrid6.Enabled))
                return true;

            //X
            else if ((btnGrid1.Text == btnGrid5.Text) && (btnGrid5.Text == btnGrid9.Text) && (!btnGrid5.Enabled))
                return true;
            else if ((btnGrid3.Text == btnGrid5.Text) && (btnGrid5.Text == btnGrid7.Text) && (!btnGrid5.Enabled))
                return true;

            return false;
        }

        private void ResetBtns()
        {
            foreach (Button btn in btns)
            {
                btn.Enabled = true;
                btn.Text = "";
            }
        }

        private void ClickButton(int ind)
        {
            Button currentBtn = btns[ind];

            if (currentBtn.Enabled)
            {
                currentBtn.Text = symbol;
                currentBtn.Enabled = false;

                if (Logic())
                {
                    ResetBtns();
                    MessageBox.Show("Congrats");
                }
            }

            NextTurn();
        }

        private void btnGrid1_Click(object sender, EventArgs e)
        {
            ClickButton(0);
        }

        private void btnGrid2_Click(object sender, EventArgs e)
        {
            ClickButton(1);
        }

        private void btnGrid3_Click(object sender, EventArgs e)
        {
            ClickButton(2);
        }

        private void btnGrid4_Click(object sender, EventArgs e)
        {
            ClickButton(3);
        }

        private void btnGrid5_Click(object sender, EventArgs e)
        {
            ClickButton(4);
        }

        private void btnGrid6_Click(object sender, EventArgs e)
        {
            ClickButton(5);
        }

        private void btnGrid7_Click(object sender, EventArgs e)
        {
            ClickButton(6);
        }

        private void btnGrid8_Click(object sender, EventArgs e)
        {
            ClickButton(7);
        }

        private void btnGrid9_Click(object sender, EventArgs e)
        {
            ClickButton(8);
        }
    }
}