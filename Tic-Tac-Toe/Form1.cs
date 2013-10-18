using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Inputbox
{
    public partial class TicTacToe : Form
    {
        private int teller;
        private int score1;
        private int score2;
        public TicTacToe()

        {
            InitializeComponent();
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            score1 = 0;
            score2 = 0;
            lblscore1.Text = Convert.ToString(score1);
            lblscore2.Text = Convert.ToString(score2);
        }
        private void reset()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            speler1.ForeColor = Color.Red;
            speler2.ForeColor = Color.Black;
            teller = 1;
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
            lblscore2.Text = "0";
            lblscore1.Text = "0";
        }

        public void My_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Enabled = false;
            if (teller % 2 == 0)
            {
                teller++;
                button.Text = "X";
                check();
                speler1.ForeColor = Color.Red;
                speler2.ForeColor = Color.Black;
            }
            else
            {
                teller++;
                button.Text = "O";
                check();
                speler2.ForeColor = Color.Red;
                speler1.ForeColor = Color.Black;
            }
        }
        private void check()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X" || button1.Text == "X" && button5.Text == "X" && button9.Text == "X" || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X" || button3.Text == "X" && button6.Text == "X" && button9.Text == "X" || button1.Text == "X" && button5.Text == "X" && button7.Text == "X"
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X" || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                    MessageBox.Show("Speler 2 heeft gewonnen!");
                    score2 += 1;
                    lblscore2.Text = Convert.ToString(score2);
               
                 DialogResult result = MessageBox.Show("Wil je nog een spel spelen?", "Spel gedaan!", MessageBoxButtons.YesNo);
                 if (result == DialogResult.Yes)
                 {
                     reset();
                 }
                 else
                 {
                     if (score1 > score2)
                     {
                         MessageBox.Show("Speler 1 is de winnaar!");
                     }
                     if (score1 == score2)
                     {
                         MessageBox.Show("Gelijkspel!");
                     }
                     if (score1 < score2)
                     {
                         MessageBox.Show("Speler 2 is de winnaar!");
                     }
                     this.Close();
            }
                
        }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O" || button1.Text == "O" && button5.Text == "O" && button9.Text == "O" || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                || button2.Text == "O" && button5.Text == "O" && button8.Text == "O" || button3.Text == "O" && button6.Text == "O" && button9.Text == "O" || button1.Text == "O" && button5.Text == "O" && button7.Text == "O"
                || button4.Text == "O" && button5.Text == "O" && button6.Text == "O" || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Speler 1 heeft gewonnen!");
                score1 += 1;
                lblscore1.Text = Convert.ToString(score1);

                DialogResult result = MessageBox.Show("Wil je nog een spel spelen?", "Spel gedaan!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    reset();
                }
                else
                {
                    if (score1 >= score2)
                    {
                        MessageBox.Show("Speler 1 is de winnaar!");
                    }
                    else
                    {
                        MessageBox.Show("Speler 2 is de winnaar!");
                    }
                    this.Close();
                }
                
            }
    }
    }
}
