using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Tic_Tac_Toe
{
    public partial class TicTacToe : Form
    {
        //Constructor
        public TicTacToe()
        {
            InitializeComponent();
        }


        //Variables
        private bool player1Turn = true;
        private int turnCount = 0;
        private int playerOScore = 0;
        private int playerXScore = 0;


        //Methods
        private void labelCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void ButtonsOff()
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
        }


        private void ButtonsOn()
        {
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
        }


        private void ResetBox()
        {
            pictureBox1.Image = ResetImage.Image;
            pictureBox2.Image = ResetImage.Image;
            pictureBox3.Image = ResetImage.Image;
            pictureBox4.Image = ResetImage.Image;
            pictureBox5.Image = ResetImage.Image;
            pictureBox6.Image = ResetImage.Image;
            pictureBox7.Image = ResetImage.Image;
            pictureBox8.Image = ResetImage.Image;
            pictureBox9.Image = ResetImage.Image;
        }

        private void DisplayXAndO(PictureBox Box)
        {
            if (player1Turn)
            {
                //import "X" image and switch player turns
                Box.Image = PicX.Image;
                player1Turn = false;
                turnCount++;
                Box.Enabled = false;
            }
            else
            {
                //import "O" image and switch player turns
                Box.Image = PicO.Image;
                player1Turn = true;
                turnCount++;
                Box.Enabled = false;
            }
        }


        private void GameLogic()
        {
            //X Wins

            if (pictureBox1.Image == PicX.Image && pictureBox2.Image == PicX.Image && pictureBox3.Image == PicX.Image)
            {
                MessageBox.Show("'X' is the WINNER!!!", "X Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonsOff();
                playerXScore++;
            }

            else if (pictureBox4.Image == PicX.Image && pictureBox5.Image == PicX.Image && pictureBox6.Image == PicX.Image)
            {
                MessageBox.Show("'X' is the WINNER!!!", "X Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonsOff();
                playerXScore++;
            }

            else if (pictureBox7.Image == PicX.Image && pictureBox8.Image == PicX.Image && pictureBox9.Image == PicX.Image)
            {
                MessageBox.Show("'X' is the WINNER!!!", "X Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonsOff();
                playerXScore++;
            }

            else if (pictureBox1.Image == PicX.Image && pictureBox4.Image == PicX.Image && pictureBox7.Image == PicX.Image)
            {
                MessageBox.Show("'X' is the WINNER!!!", "X Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonsOff();
                playerXScore++;
            }

            else if (pictureBox2.Image == PicX.Image && pictureBox5.Image == PicX.Image && pictureBox8.Image == PicX.Image)
            {
                MessageBox.Show("'X' is the WINNER!!!", "X Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonsOff();
                playerXScore++;
            }

            else if (pictureBox3.Image == PicX.Image && pictureBox6.Image == PicX.Image && pictureBox9.Image == PicX.Image)
            {
                MessageBox.Show("'X' is the WINNER!!!", "X Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonsOff();
                playerXScore++;
            }

            else if (pictureBox1.Image == PicX.Image && pictureBox5.Image == PicX.Image && pictureBox9.Image == PicX.Image)
            {
                MessageBox.Show("'X' is the WINNER!!!", "X Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonsOff();
                playerXScore++;
            }

            else if (pictureBox3.Image == PicX.Image && pictureBox5.Image == PicX.Image && pictureBox7.Image == PicX.Image)
            {
                MessageBox.Show("'X' is the WINNER!!!", "X Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonsOff();
                playerXScore++;
            }

            //O Wins

            else if (pictureBox1.Image == PicO.Image && pictureBox2.Image == PicO.Image && pictureBox3.Image == PicO.Image)
            {
                MessageBox.Show("'O' is the WINNER!!!", "X Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonsOff();
                playerOScore++;
            }

            else if (pictureBox4.Image == PicO.Image && pictureBox5.Image == PicO.Image && pictureBox6.Image == PicO.Image)
            {
                MessageBox.Show("'O' is the WINNER!!!", "X Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonsOff();
                playerOScore++;
            }

            else if (pictureBox7.Image == PicO.Image && pictureBox8.Image == PicO.Image && pictureBox9.Image == PicO.Image)
            {
                MessageBox.Show("'O' is the WINNER!!!", "X Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonsOff();
                playerOScore++;
            }

            else if (pictureBox1.Image == PicO.Image && pictureBox4.Image == PicO.Image && pictureBox7.Image == PicO.Image)
            {
                MessageBox.Show("'O' is the WINNER!!!", "X Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonsOff();
                playerOScore++;
            }

            else if (pictureBox2.Image == PicO.Image && pictureBox5.Image == PicO.Image && pictureBox8.Image == PicO.Image)
            {
                MessageBox.Show("'O' is the WINNER!!!", "X Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonsOff();
                playerOScore++;
            }

            else if (pictureBox3.Image == PicO.Image && pictureBox6.Image == PicO.Image && pictureBox9.Image == PicO.Image)
            {
                MessageBox.Show("'O' is the WINNER!!!", "X Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonsOff();
                playerOScore++;
            }

            else if (pictureBox1.Image == PicO.Image && pictureBox5.Image == PicO.Image && pictureBox9.Image == PicO.Image)
            {
                MessageBox.Show("'O' is the WINNER!!!", "X Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonsOff();
                playerOScore++;
            }

            else if (pictureBox3.Image == PicO.Image && pictureBox5.Image == PicO.Image && pictureBox7.Image == PicO.Image)
            {
                MessageBox.Show("'O' is the WINNER!!!", "X Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonsOff();
                playerOScore++;
            }

            //Draw

            else if (turnCount == 9)
            {
                MessageBox.Show("It's a tie!!!", "Draw", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ButtonsOff();
            }

            labelScoreX.Text = playerXScore.ToString();
            labelScoreO.Text = playerOScore.ToString();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DisplayXAndO(pictureBox1);
            GameLogic();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DisplayXAndO(pictureBox2);
            GameLogic();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DisplayXAndO(pictureBox3);
            GameLogic();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DisplayXAndO(pictureBox4);
            GameLogic();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DisplayXAndO(pictureBox5);
            GameLogic();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DisplayXAndO(pictureBox6);
            GameLogic();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            DisplayXAndO(pictureBox7);
            GameLogic();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            DisplayXAndO(pictureBox8);
            GameLogic();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            DisplayXAndO(pictureBox9);
            GameLogic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            turnCount = 0;
            ResetBox();
            ButtonsOn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playerXScore = 0;
            playerOScore = 0;
            labelScoreX.Text = "0";
            labelScoreO.Text = "0";
        }
    }
}
