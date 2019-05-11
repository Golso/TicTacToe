using System;
using System.Windows.Forms;

namespace TicTacToeProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.setPlayerNames(player1.Text, player2.Text);
            Close();
        }
    }
}
