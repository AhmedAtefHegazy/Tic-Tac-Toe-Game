using System.Drawing;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum enPlayer { P1, P2 };

        enPlayer Player;

        enPlayer UpdateNextPlayer(enPlayer Player)
        {
            if (Player == enPlayer.P1)
            {
                Player = enPlayer.P2;
                lblPlayer.Text = "Player 2";
            }

            else if (Player == enPlayer.P2)
            {
                Player = enPlayer.P1;
                lblPlayer.Text = "Player 1";
            }

            if (PB1.Enabled == false && PB8.Enabled == false && PB2.Enabled == false
                && PB9.Enabled == false && PB4.Enabled == false
                && PB5.Enabled == false && PB6.Enabled == false &&
                PB3.Enabled == false && PB7.Enabled == false)
            {
                lblPlayer.Text = "Game Over";

            }

            UpdateGameWinner();
            return Player;
        }

        void UpdateGameWinner()
        {
            if (

                ((PB1.Tag == PB2.Tag) && (PB1.Tag == PB3.Tag) && Player == enPlayer.P1)
                || ((PB4.Tag == PB5.Tag) && (PB4.Tag == PB6.Tag) && Player == enPlayer.P1)
                || ((PB7.Tag == PB8.Tag) && (PB7.Tag == PB9.Tag) && Player == enPlayer.P1)
                || ((PB1.Tag == PB5.Tag) && (PB1.Tag == PB9.Tag) && Player == enPlayer.P1)
                || ((PB3.Tag == PB5.Tag) && (PB3.Tag == PB7.Tag) && Player == enPlayer.P1)
                || ((PB1.Tag == PB4.Tag) && (PB1.Tag == PB7.Tag) && Player == enPlayer.P1)
                || ((PB2.Tag == PB5.Tag) && (PB2.Tag == PB8.Tag) && Player == enPlayer.P1)
                || ((PB3.Tag == PB6.Tag) && (PB3.Tag == PB9.Tag) && Player == enPlayer.P1)
                )
            {
                lblWinner.Text = "Player 1";
                MessageBox.Show((lblWinner.Text + " is the Winner"), "Game Over");
                lblPlayer.Text = "Game Over";
                PB1.Enabled = false;
                PB2.Enabled = false;
                PB3.Enabled = false;
                PB4.Enabled = false;
                PB5.Enabled = false;
                PB6.Enabled = false;
                PB7.Enabled = false;
                PB8.Enabled = false;
                PB9.Enabled = false;
            }

            else if (

                       ((PB1.Tag == PB2.Tag) && (PB1.Tag == PB3.Tag) && Player == enPlayer.P2)
                       || ((PB4.Tag == PB5.Tag) && (PB4.Tag == PB6.Tag) && Player == enPlayer.P2)
                       || ((PB7.Tag == PB8.Tag) && (PB7.Tag == PB9.Tag) && Player == enPlayer.P2)
                       || ((PB1.Tag == PB5.Tag) && (PB1.Tag == PB9.Tag) && Player == enPlayer.P2)
                       || ((PB3.Tag == PB5.Tag) && (PB3.Tag == PB7.Tag) && Player == enPlayer.P2)
                       || ((PB1.Tag == PB4.Tag) && (PB1.Tag == PB7.Tag) && Player == enPlayer.P2)
                       || ((PB2.Tag == PB5.Tag) && (PB2.Tag == PB8.Tag) && Player == enPlayer.P2)
                       || ((PB3.Tag == PB6.Tag) && (PB3.Tag == PB9.Tag) && Player == enPlayer.P2)
                       )
            {
                lblWinner.Text = "Player 2";
                MessageBox.Show((lblWinner.Text + " is the Winner"), "Game Over");
                lblPlayer.Text = "Game Over";
                PB1.Enabled = false;
                PB2.Enabled = false;
                PB3.Enabled = false;
                PB4.Enabled = false;
                PB5.Enabled = false;
                PB6.Enabled = false;
                PB7.Enabled = false;
                PB8.Enabled = false;
                PB9.Enabled = false;
            }



            else if (lblPlayer.Text == "Game Over")
            {
                lblWinner.Text = "Draw";
                lblWinner.ForeColor = Color.Red;
            }
        }

        void UpdateImageAndTags(byte NumberOfImage)
        {
            switch (NumberOfImage)
            {
                case 1:

                    if (Player == enPlayer.P1)
                    {
                        PB1.Image = Resources.X;
                        PB1.Tag = "X";
                        PB1.Enabled = false;

                    }

                    else if (Player == enPlayer.P2)
                    {
                        PB1.Image = Resources.O;
                        PB1.Tag = "O";
                        PB1.Enabled = false;
                    }

                    break;

                case 2:

                    if (Player == enPlayer.P1)
                    {
                        PB2.Image = Resources.X;
                        PB2.Tag = "X";
                        PB2.Enabled = false;

                    }

                    else if (Player == enPlayer.P2)
                    {
                        PB2.Image = Resources.O;
                        PB2.Tag = "O";
                        PB2.Enabled = false;
                    }

                    break;
                case 3:

                    if (Player == enPlayer.P1)
                    {
                        PB3.Image = Resources.X;
                        PB3.Tag = "X";
                        PB3.Enabled = false;

                    }

                    else if (Player == enPlayer.P2)
                    {
                        PB3.Image = Resources.O;
                        PB3.Tag = "O";
                        PB3.Enabled = false;
                    }

                    break;
                case 4:

                    if (Player == enPlayer.P1)
                    {
                        PB4.Image = Resources.X;
                        PB4.Tag = "X";
                        PB4.Enabled = false;

                    }

                    else if (Player == enPlayer.P2)
                    {
                        PB4.Image = Resources.O;
                        PB4.Tag = "O";
                        PB4.Enabled = false;
                    }

                    break;
                case 5:

                    if (Player == enPlayer.P1)
                    {
                        PB5.Image = Resources.X;
                        PB5.Tag = "X";
                        PB5.Enabled = false;

                    }

                    else if (Player == enPlayer.P2)
                    {
                        PB5.Image = Resources.O;
                        PB5.Tag = "O";
                        PB5.Enabled = false;
                    }

                    break;
                case 6:

                    if (Player == enPlayer.P1)
                    {
                        PB6.Image = Resources.X;
                        PB6.Tag = "X";
                        PB6.Enabled = false;

                    }

                    else if (Player == enPlayer.P2)
                    {
                        PB6.Image = Resources.O;
                        PB6.Tag = "O";
                        PB6.Enabled = false;
                    }

                    break;
                case 7:

                    if (Player == enPlayer.P1)
                    {
                        PB7.Image = Resources.X;
                        PB7.Tag = "X";
                        PB7.Enabled = false;

                    }

                    else if (Player == enPlayer.P2)
                    {
                        PB7.Image = Resources.O;
                        PB7.Tag = "O";
                        PB7.Enabled = false;
                    }

                    break;
                case 8:

                    if (Player == enPlayer.P1)
                    {
                        PB8.Image = Resources.X;
                        PB8.Tag = "X";
                        PB8.Enabled = false;

                    }

                    else if (Player == enPlayer.P2)
                    {
                        PB8.Image = Resources.O;
                        PB8.Tag = "O";
                        PB8.Enabled = false;
                    }

                    break;
                case 9:

                    if (Player == enPlayer.P1)
                    {
                        PB9.Image = Resources.X;
                        PB9.Tag = "X";
                        PB9.Enabled = false;

                    }

                    else if (Player == enPlayer.P2)
                    {
                        PB9.Image = Resources.O;
                        PB9.Tag = "O";
                        PB9.Enabled = false;
                    }

                    break;

                default:
                    break;
            }

        }

        void ResetGame()
        {
            lblPlayer.Text = "Player 1";
            lblWinner.Text = "In Progress";
            lblWinner.ForeColor = Color.Lime;

            PB1.Image = Resources.question_mark_symbol;
            PB2.Image = Resources.question_mark_symbol;
            PB3.Image = Resources.question_mark_symbol;
            PB4.Image = Resources.question_mark_symbol;
            PB5.Image = Resources.question_mark_symbol;
            PB6.Image = Resources.question_mark_symbol;
            PB7.Image = Resources.question_mark_symbol;
            PB8.Image = Resources.question_mark_symbol;
            PB9.Image = Resources.question_mark_symbol;


            PB1.Enabled = true;
            PB2.Enabled = true;
            PB3.Enabled = true;
            PB4.Enabled = true;
            PB5.Enabled = true;
            PB6.Enabled = true;
            PB7.Enabled = true;
            PB8.Enabled = true;
            PB9.Enabled = true;


            PB1.Tag = "1";
            PB2.Tag = "2";
            PB3.Tag = "3";
            PB4.Tag = "4";
            PB5.Tag = "5";
            PB6.Tag = "6";
            PB7.Tag = "7";
            PB8.Tag = "8";
            PB9.Tag = "9";

            Player = enPlayer.P1;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.Goldenrod;

            Pen pen = new Pen(color, 10);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 390, 205, 780, 205);
            e.Graphics.DrawLine(pen, 390, 313, 780, 313);
            e.Graphics.DrawLine(pen, 520, 100, 520, 415);
            e.Graphics.DrawLine(pen, 652, 100, 652, 415);
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            UpdateImageAndTags(1);
            Player = UpdateNextPlayer(Player);

        }

        private void pictureBox3_Click(object sender, System.EventArgs e)
        {
            UpdateImageAndTags(2);

            Player = UpdateNextPlayer(Player);
        }

        private void pictureBox8_Click(object sender, System.EventArgs e)
        {
            UpdateImageAndTags(3);

            Player = UpdateNextPlayer(Player);
        }

        private void pictureBox5_Click(object sender, System.EventArgs e)
        {
            UpdateImageAndTags(4);

            Player = UpdateNextPlayer(Player);
        }

        private void pictureBox6_Click(object sender, System.EventArgs e)
        {
            UpdateImageAndTags(5);

            Player = UpdateNextPlayer(Player);
        }

        private void pictureBox7_Click(object sender, System.EventArgs e)
        {
            UpdateImageAndTags(6);

            Player = UpdateNextPlayer(Player);
        }

        private void pictureBox9_Click(object sender, System.EventArgs e)
        {
            UpdateImageAndTags(7);

            Player = UpdateNextPlayer(Player);
        }

        private void pictureBox2_Click(object sender, System.EventArgs e)
        {
            UpdateImageAndTags(8);

            Player = UpdateNextPlayer(Player);
        }

        private void pictureBox4_Click(object sender, System.EventArgs e)
        {
            UpdateImageAndTags(9);

            Player = UpdateNextPlayer(Player);
        }

        private void btnRestart_Click(object sender, System.EventArgs e)
        {
            ResetGame();
        }
    }
}
