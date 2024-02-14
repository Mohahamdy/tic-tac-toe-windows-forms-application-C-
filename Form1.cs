namespace XO_Form
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turnCount = 0;
        int scoreX = 0;
        int scoreO = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            clearButtons();
            scoreO = 0;
            scoreX = 0;
            btn_scoreO.Text = "0";
            btn_scoreX.Text = "0";
        }

        private void click_btn(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;

            b.Enabled = false;

            turnCount++;

            checkForWinner();
        }

        private void checkForWinner()
        {
            bool Winner = false;

            if (btn1.Text == btn2.Text && btn2.Text == btn3.Text && !btn1.Enabled)
                Winner = true;

            else if (btn4.Text == btn5.Text && btn5.Text == btn6.Text && !btn4.Enabled)
                Winner = true;

            else if (btn7.Text == btn8.Text && btn8.Text == btn9.Text && !btn7.Enabled)
                Winner = true;


            else if (btn1.Text == btn4.Text && btn4.Text == btn7.Text && !btn1.Enabled)
                Winner = true;

            else if (btn2.Text == btn5.Text && btn5.Text == btn8.Text && !btn2.Enabled)
                Winner = true;

            else if (btn3.Text == btn6.Text && btn6.Text == btn9.Text && !btn3.Enabled)
                Winner = true;

            else if (btn1.Text == btn5.Text && btn5.Text == btn9.Text && !btn1.Enabled)
                Winner = true;

            else if (btn3.Text == btn5.Text && btn5.Text == btn7.Text && !btn3.Enabled)
                Winner = true;


            if (Winner)
            {
                if (turn)
                {
                    scoreO++;
                    btn_scoreO.Text = scoreO.ToString();
                    MessageBox.Show("Player O Wins", "WINNER !!");
                }

                else
                {
                    scoreX++;
                    btn_scoreX.Text = scoreX.ToString();
                    MessageBox.Show("Player X wins", "Winner !!");
                }
                    
                clearButtons();
            }
            else
            {
                if (turnCount == 9)
                {
                    MessageBox.Show("DRAW !!!!", "OH !!");
                    clearButtons();
                }
            }

        }

        private void clearButton(Button B)
        {
            B.Text = "";
            B.Enabled = true;
        }

        private void clearButtons()
        {
            clearButton(btn1);
            clearButton(btn2);
            clearButton(btn3);
            clearButton(btn4);
            clearButton(btn5);
            clearButton(btn6);
            clearButton(btn7);
            clearButton(btn8);
            clearButton(btn9);

            turn = true;
            turnCount = 0;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            clearButtons();
        }
    }
}
