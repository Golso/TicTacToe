using System;
using System.Windows.Forms;

namespace TicTacToeProject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.setPlayerNames(player1.Text, "Computer");
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.setDifficulty(1);
            playButton.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.setDifficulty(2);
            playButton.Enabled = true;
        }
    }
}
