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
                lblTurn.Text = "Player 2";
            }

            else if (Player == enPlayer.P2)
            {
                Player = enPlayer.P1;
                lblTurn.Text = "Player 1";
            }

            if (PB1.Enabled == false && PB8.Enabled == false && PB2.Enabled == false
                && PB9.Enabled == false && PB4.Enabled == false
                && PB5.Enabled == false && PB6.Enabled == false &&
                PB3.Enabled == false && PB7.Enabled == false)
            {
                lblTurn.Text = "Game Over";

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
                MessageBox.Show("Game Over", "Game Over");
                lblTurn.Text = "Game Over";
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
                MessageBox.Show("Game Over", "Game Over");
                lblTurn.Text = "Game Over";
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



            else if (lblTurn.Text == "Game Over")
            {
                lblWinner.Text = "Draw";
                lblWinner.ForeColor = Color.Red;
                MessageBox.Show("Game Over", "Game Over");
            }
        }

        void UpdateImageAndTags(PictureBox pictureBox)
        {

            if (Player == enPlayer.P1)
            {
                pictureBox.Image = Resources.X;
                pictureBox.Tag = "X";
                pictureBox.Enabled = false;

            }

            else if (Player == enPlayer.P2)
            {
                pictureBox.Image = Resources.O;
                pictureBox.Tag = "O";
                pictureBox.Enabled = false;
            }

        }

        void ResetGame()
        {
            lblTurn.Text = "Player 1";
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
            Color color = Color.White;

            Pen pen = new Pen(color, 10);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 300, 212, 680, 212);
            e.Graphics.DrawLine(pen, 300, 319, 680, 319);
            e.Graphics.DrawLine(pen, 425, 110, 425, 420);
            e.Graphics.DrawLine(pen, 555, 110, 555, 420);
        }

        private void btnRestart_Click(object sender, System.EventArgs e)
        {
            ResetGame();
        }

        private void pictureBox_Click(object sender, System.EventArgs e)
        {
            UpdateImageAndTags((PictureBox)sender);

            Player = UpdateNextPlayer(Player);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://ahmedatefhegazy.github.io/portfolio");
        }
    }
}
