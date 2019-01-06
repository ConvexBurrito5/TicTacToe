using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe1
{
    public partial class Form1 : Form
    {
        bool turn = true; //True = X turn; False = Y 
        int turn_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Kevin & Matt!\n(ConvexBurrito & Slainlight)");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "0";
            check();
            turn = !turn;
            b.Enabled = false;
        }

        private void check()
        {
            turn_count = turn_count + 1;
            bool there_is_a_winner = false;

            //Horosonal Checks
            //A1 A2 A3
            if ((A1.Text == "") && ((A2.Text == "")) && (A3.Text== ""))
            {

            }
            else
            {
                if ((A1.Text == A2.Text) && (A2.Text == A3.Text))
                    there_is_a_winner = true;
            }

            //B1 B2 B3
            if ((B1.Text == "") && ((B2.Text == "")) && (B3.Text == ""))
            {

            }
            else
            {
                if ((B1.Text == B2.Text) && (B2.Text == B3.Text))
                    there_is_a_winner = true;
            }

            //C1 C2 C3
            if ((C1.Text == "") && ((C2.Text == "")) && (C3.Text == ""))
            {

            }
            else
            {
                if ((C1.Text == C2.Text) && (C2.Text == C3.Text))
                    there_is_a_winner = true;
            }
            
            //Vertical checks
            //A1 B1 C1
            if ((A1.Text == "") && ((B1.Text == "")) && (C1.Text == ""))
            {

            }
            else
            {
                if ((A1.Text == B1.Text) && (B1.Text == C1.Text))
                    there_is_a_winner = true;
            }
            //A2 B2 C2
            if ((A2.Text == "") && ((B2.Text == "")) && (C2.Text == ""))
            {

            }
            else
            {
                if ((A2.Text == B2.Text) && (B2.Text == C2.Text))
                    there_is_a_winner = true;
            }
            //A3 B3 C3
            if ((A3.Text == "") && ((B3.Text == "")) && (C3.Text == ""))
            {

            }
            else
            {
                if ((A3.Text == B3.Text) && (B3.Text == C3.Text))
                    there_is_a_winner = true;
            }
            //Diagional Checks
            //A1 B2 C3
            if ((A1.Text == "") && ((B2.Text == "")) && (C3.Text == ""))
            {

            }
            else
            {
                if ((A1.Text == B2.Text) && (B2.Text == C3.Text))
                    there_is_a_winner = true;
            }
            //A3 B2 C1
            if ((A3.Text == "") && ((B2.Text == "")) && (C1.Text == ""))
            {

            }
            else if((A3.Text == B2.Text) && (B2.Text == C1.Text))
                    there_is_a_winner = true;
            //all boxes full.

            //draw?
            if (turn_count == 9)
            {
                MessageBox.Show("Draw!", "Good try");
                Application.Restart();
            }

            //winer describe
            if (there_is_a_winner)
            {
                string winner = "";
                if (turn)
                    winner = "X";
                else
                    winner = "O";

                MessageBox.Show(winner + " Wins!", "Yay!");
                Application.Restart();
            }
        }

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }//end foreach
            }//endtry
            catch { }

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = Properties.Resources.space1;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
