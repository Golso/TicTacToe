using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToeProject
{
    public partial class Form1 : Form
    {
        private bool turn = true; // true = X turn, false = Y turn
        private int turn_count = 0; //counts moves
        static string player1, player2;
        static int difficulty = 0;

        public Form1()
        {
            InitializeComponent();
        }
       
        public static void setPlayerNames(string p1, string p2)
        {
            if (p1 == "")
                player1 = "player 1";
            else player1 = p1;

            if (p2 == "")
                player2 = "player 2";
            else player2 = p2;
        }

        //set difficulty level of AI
        public static void setDifficulty(int diff)
        {
            difficulty = diff;
        }

        //method changing the button color and marking it by "X" or "O"
        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
                b.BackColor = Color.Cyan;
            }
            else
            {
                b.Text = "O";
                b.BackColor = Color.Red;
            }

            turn = !turn;
            turn_count++;
            b.Enabled = false;

            checkOutcome();

            if ((!turn) && (difficulty == 1))
                computerMakeMoveEasy();

            if ((!turn) && (difficulty==2))
                computerMakeMoveNormal();
        }

        private void computerMakeMoveNormal()
        {        
            Button move = null;

            move = look_for_win_or_block("O"); //look for win
            if (move == null)
            {
                move = look_for_win_or_block("X"); //look for block
                if (move == null)
                {
                    move = look_for_corner();
                    if (move == null)
                    {
                        move = look_for_free_space();
                    }
                }
            }

            if(turn_count<9)
            {
                move.PerformClick();
            }
        }

        //AI is choosing just random free space
        private void computerMakeMoveEasy()
        {
            Button move = null;
            move = look_for_free_space();

            if (turn_count < 9)
            {
                move.PerformClick();
            }
        }

        private Button look_for_free_space()
        {
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }
            }

            return null;
        }

        private Button look_for_corner()
        {
            

            if (buttonA1.Text == "")
                return buttonA1;
            if (buttonA3.Text == "")
                return buttonA3;
            if (buttonC1.Text == "")
                return buttonC1;
            if (buttonC3.Text == "")
                return buttonC3;

            return null;
        }

        //depended of mark the method is looking for winning or blocking possibility
        private Button look_for_win_or_block(string mark)
        {
            //check of vertical columns
            if ((buttonA1.Text == mark) && (buttonB1.Text == mark) && (buttonC1.Text == ""))
                return buttonC1;
            if ((buttonB1.Text == mark) && (buttonC1.Text == mark) && (buttonA1.Text == ""))
                return buttonA1;
            if ((buttonA1.Text == mark) && (buttonC1.Text == mark) && (buttonB1.Text == ""))
                return buttonB1;

            if ((buttonA2.Text == mark) && (buttonB2.Text == mark) && (buttonC2.Text == ""))
                return buttonC2;
            if ((buttonB2.Text == mark) && (buttonC2.Text == mark) && (buttonA2.Text == ""))
                return buttonA2;
            if ((buttonA2.Text == mark) && (buttonC2.Text == mark) && (buttonB2.Text == ""))
                return buttonB2;

            if ((buttonA3.Text == mark) && (buttonB3.Text == mark) && (buttonC3.Text == ""))
                return buttonC3;
            if ((buttonB3.Text == mark) && (buttonC3.Text == mark) && (buttonA3.Text == ""))
                return buttonA3;
            if ((buttonA3.Text == mark) && (buttonC3.Text == mark) && (buttonB3.Text == ""))
                return buttonB3;



            //check of horizontal columns
            if ((buttonA1.Text == mark) && (buttonA2.Text == mark) && (buttonA3.Text == ""))
                return buttonA3;
            if ((buttonA2.Text == mark) && (buttonA3.Text == mark) && (buttonA1.Text == ""))
                return buttonA1;
            if ((buttonA1.Text == mark) && (buttonA3.Text == mark) && (buttonA2.Text == ""))
                return buttonA2;

            if ((buttonC1.Text == mark) && (buttonC2.Text == mark) && (buttonC3.Text == ""))
                return buttonC3;
            if ((buttonC2.Text == mark) && (buttonC3.Text == mark) && (buttonC1.Text == ""))
                return buttonC1;
            if ((buttonC1.Text == mark) && (buttonC3.Text == mark) && (buttonC2.Text == ""))
                return buttonC2;

            if ((buttonB1.Text == mark) && (buttonB2.Text == mark) && (buttonB3.Text == ""))
                return buttonB3;
            if ((buttonB2.Text == mark) && (buttonB3.Text == mark) && (buttonB1.Text == ""))
                return buttonB1;
            if ((buttonB1.Text == mark) && (buttonB3.Text == mark) && (buttonB2.Text == ""))
                return buttonB2;

            

            //check of diagonals
            if ((buttonA1.Text == mark) && (buttonB2.Text == mark) && (buttonC3.Text == ""))
                return buttonC3;
            if ((buttonB2.Text == mark) && (buttonC3.Text == mark) && (buttonA1.Text == ""))
                return buttonA1;
            if ((buttonA1.Text == mark) && (buttonC3.Text == mark) && (buttonB2.Text == ""))
                return buttonB2;

            if ((buttonA3.Text == mark) && (buttonB2.Text == mark) && (buttonC1.Text == ""))
                return buttonC1;
            if ((buttonB2.Text == mark) && (buttonC1.Text == mark) && (buttonA3.Text == ""))
                return buttonA3;
            if ((buttonA3.Text == mark) && (buttonC1.Text == mark) && (buttonB2.Text == ""))
                return buttonB2;

            return null;
        }

        //checking if there is a winner
        private void checkOutcome()
        {
            bool result = false;


            //horizontal
            if ((buttonA1.Text == buttonA2.Text) && (buttonA2.Text == buttonA3.Text) && (!buttonA1.Enabled))
            {
                result = true;
                buttonEffect(buttonA1, buttonA2, buttonA3);
            }
            else if ((buttonB1.Text == buttonB2.Text) && (buttonB2.Text == buttonB3.Text) && (!buttonB1.Enabled))
            {
                result = true;
                buttonEffect(buttonB1, buttonB2, buttonB3);
            }
            else if ((buttonC1.Text == buttonC2.Text) && (buttonC2.Text == buttonC3.Text) && (!buttonC1.Enabled))
            {
                result = true;
                buttonEffect(buttonC1, buttonC2, buttonC3);
            }

            //vertical
            else if ((buttonA1.Text == buttonB1.Text) && (buttonB1.Text == buttonC1.Text) && (!buttonA1.Enabled))
            {
                result = true;
                buttonEffect(buttonA1, buttonB1, buttonC1);
            }
            else if ((buttonA2.Text == buttonB2.Text) && (buttonB2.Text == buttonC2.Text) && (!buttonA2.Enabled))
            {
                result = true;
                buttonEffect(buttonA2, buttonB2, buttonC2);
            }
            else if ((buttonA3.Text == buttonB3.Text) && (buttonB3.Text == buttonC3.Text) && (!buttonA3.Enabled))
            {
                result = true;
                buttonEffect(buttonA3, buttonB3, buttonC3);
            }

            //diagonal
            else if ((buttonA1.Text == buttonB2.Text) && (buttonB2.Text == buttonC3.Text) && (!buttonA1.Enabled))
            {
                result = true;
                buttonEffect(buttonA1, buttonB2, buttonC3);
            }
            else if ((buttonA3.Text == buttonB2.Text) && (buttonB2.Text == buttonC1.Text) && (!buttonC1.Enabled))
            {
                result = true;
                buttonEffect(buttonA3, buttonB2, buttonC1);
            }

            announceResult(result);
        }

        private void announceResult(bool result)
        {
            if (result)
            {
                disableButtons();

                string victor = "";
                if (turn)
                {
                    victor = player2;
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                }
                else
                {
                    victor = player1;
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                }
                MessageBox.Show(victor + " wins!", "Outcome");
                NewGame();
            }
            else if (turn_count == 9)
            {
                MessageBox.Show("Tie!", "Outcome");
                draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
                NewGame();
            }
        }

        private void disableButtons()
        {
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
                catch { }
            }
        }

        //changing of colors of winning buttons
        private void buttonEffect(Button b1, Button b2, Button b3)
        {
            b1.BackColor = Color.Purple;
            b2.BackColor = Color.Purple;
            b3.BackColor = Color.Purple;
        }
        
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void NewGame()
        {
            turn = true;
            turn_count = 0;


            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.BackColor = default(Color);
                }
                catch { }
            }
        }

        //method showing whose turn it is by entering on enabled button
        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else b.Text = "O";
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(b.Enabled)
                b.Text = "";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application made by Mateusz Gola - Erasmus student.", "Tic Tac Toe About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //reset of results
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            o_win_count.Text = "0";
            x_win_count.Text = "0";
            draw_count.Text = "0";
        }

        private void goBackToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rule1 = "The game is played on a grid that's 3 squares by 3 squares.";
            string rule2 = "First player is X, second player (or the computer) is O.";
            string rule3 = "Players take turns putting their marks in empty squares.";
            string rule4 = "The first player to get 3 of her marks in a row(up, down, across, or diagonally) is the winner.";
            string rules = string.Format(rule1+"{0}"+rule2+"{0}"+rule3+"{0}"+rule4, Environment.NewLine);
            MessageBox.Show(rules, "RULES FOR TIC TAC TOE");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            label1.Text = player1;
            label3.Text = player2;
        }
    }
}
