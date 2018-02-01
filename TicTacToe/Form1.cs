using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximumSize = new Size(600, 600);
            label2.Text = "Player 1 ( X )";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s1;
            if(!turn)
            {
                s1 = "Player 1 ( X )";
            }
            else
            {
                s1 = "Player 2 ( O )";
            }
            label2.Text = s1;
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
            turn = !turn;
            b.Enabled = false;
            count++;
            check();
        }
        public void check()
        {
            bool matchover = false;
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (!button1.Enabled))
            {
                matchover = true;
            }
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button4.Enabled))
            {
                matchover = true;
            }
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (!button7.Enabled))
            {
                matchover = true;
            }
            else if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (!button1.Enabled))
            {
                matchover = true;
            }
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (!button2.Enabled))
            {
                matchover = true;
            }
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (!button3.Enabled))
            {
                matchover = true;
            }
            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (!button1.Enabled))
            {
                matchover = true;
            }
            else if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (!button3.Enabled))
            {
                matchover = true;
            }
            else if (count == 9)
            {
                MessageBox.Show("Match Draw !!!", "Match Over");
                disableall();
            }
            if (matchover)
            {
                disableall();
                String s;
                if (turn)
                {
                    s = "O";
                }
                else
                {
                    s = "X";
                }
                MessageBox.Show(s + " Wins !!!", "Match Over");
            }
        }
        public void disableall()
        {
            label2.Text = "Match Over";
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
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            count = 0;
            turn = true;
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Text = "";
                    b.Enabled = true;
                    label2.Text= "Player 1 ( X )";
                }
                catch { }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Ishan Mourya at Room no 404, Hostel 16, IIEST Shibpur","About");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}