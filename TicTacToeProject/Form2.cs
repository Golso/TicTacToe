using System;
using System.Windows.Forms;

namespace TicTacToeProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ex_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void single_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
            Close();
        }

        private void two_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            Close();
        }
    }
}
