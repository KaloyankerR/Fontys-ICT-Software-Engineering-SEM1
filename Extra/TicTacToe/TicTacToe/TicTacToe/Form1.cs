namespace TicTacToe
{
    public partial class MainForm : Form
    {
        private int playerOneScore, playerTwoScore, gamesPlayed = 0;
        private string symbol = "X";
        private bool isSymbol = false;
        private Button[] btns;

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
            if (isSymbol)
            {
                symbol = "X";
                isSymbol = false;
            } else
            {
                symbol = "O";
                isSymbol = true;
            }
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

        private void ClickButton(int ind)
        {
            Button currentBtn = btns[ind];

            if (currentBtn.Enabled)
            {
                currentBtn.Text = symbol;
                currentBtn.Enabled = false;
                currentBtn.BackColor = isSymbol ? Color.Blue : Color.Red;

                if (Logic())
                {
                    MessageBox.Show("Congrats");
                    AddToHistory();
                    DetermineWinner();
                    ResetBtns();
                }
            }

            NextTurn();
        }

        private void DetermineWinner()
        {
            if (isSymbol)
            {
                playerTwoScore += 1;
            } else
            {
                playerOneScore += 1;
            }

            lblResult.Text = $"Result (X - O): {playerOneScore} - {playerTwoScore}";
        }

        private void AddToHistory()
        {
            gamesPlayed += 1;
            string res = $"Game {gamesPlayed}: player {symbol} won";

            listbxHistory.Items.Add(res);
        }

        private void ResetBtns()
        {
            foreach (Button btn in btns)
            {
                btn.Enabled = true;
                btn.Text = "";
                btn.BackColor = Color.WhiteSmoke;
            }
        }

        // Controls -----------------------------
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