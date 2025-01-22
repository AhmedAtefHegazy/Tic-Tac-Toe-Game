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

        enPlayer ReturnNextPlayer(enPlayer Player)
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


            return Player;
        }

        void UpdateGameWinner()
        {
            if ((PB1.Image == Resources.X) && (PB2.Image == Resources.X) && (PB3.Image == Resources.X))
            {
                lblWinner.Text = "Player 1";
            }
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

            if (Player == enPlayer.P1)
            {
                PB1.Image = Resources.X;
                PB1.Enabled = false;

            }

            else if (Player == enPlayer.P2)
            {
                PB1.Image = Resources.O;
                PB1.Enabled = false;
            }

            Player = ReturnNextPlayer(Player);

            UpdateGameWinner();
        }

        private void pictureBox3_Click(object sender, System.EventArgs e)
        {

            if (Player == enPlayer.P1)
            {
                PB2.Image = Resources.X;
                PB2.Enabled = false;

            }

            else if (Player == enPlayer.P2)
            {
                PB2.Image = Resources.O;
                PB2.Enabled = false;
            }

            Player = ReturnNextPlayer(Player);

            UpdateGameWinner();
        }

        private void pictureBox8_Click(object sender, System.EventArgs e)
        {

            if (Player == enPlayer.P1)
            {
                PB3.Image = Resources.X;
                PB3.Enabled = false;

            }

            else if (Player == enPlayer.P2)
            {
                PB3.Image = Resources.O;
                PB3.Enabled = false;
            }

            Player = ReturnNextPlayer(Player);

            UpdateGameWinner();
        }

        private void pictureBox5_Click(object sender, System.EventArgs e)
        {

            if (Player == enPlayer.P1)
            {
                PB4.Image = Resources.X;
                PB4.Enabled = false;

            }

            else if (Player == enPlayer.P2)
            {
                PB4.Image = Resources.O;
                PB4.Enabled = false;
            }

            Player = ReturnNextPlayer(Player);

            UpdateGameWinner();
        }

        private void pictureBox6_Click(object sender, System.EventArgs e)
        {

            if (Player == enPlayer.P1)
            {
                PB5.Image = Resources.X;
                PB5.Enabled = false;

            }

            else if (Player == enPlayer.P2)
            {
                PB5.Image = Resources.O;
                PB5.Enabled = false;
            }

            Player = Player = ReturnNextPlayer(Player);

            UpdateGameWinner();
        }

        private void pictureBox7_Click(object sender, System.EventArgs e)
        {

            if (Player == enPlayer.P1)
            {
                PB6.Image = Resources.X;
                PB6.Enabled = false;

            }

            else if (Player == enPlayer.P2)
            {
                PB6.Image = Resources.O;
                PB6.Enabled = false;
            }

            Player = ReturnNextPlayer(Player);

            UpdateGameWinner();
        }

        private void pictureBox9_Click(object sender, System.EventArgs e)
        {

            if (Player == enPlayer.P1)
            {
                PB7.Image = Resources.X;
                PB7.Enabled = false;

            }

            else if (Player == enPlayer.P2)
            {
                PB7.Image = Resources.O;
                PB7.Enabled = false;
            }

            Player = ReturnNextPlayer(Player);

            UpdateGameWinner();
        }

        private void pictureBox2_Click(object sender, System.EventArgs e)
        {

            if (Player == enPlayer.P1)
            {
                PB8.Image = Resources.X;
                PB8.Enabled = false;

            }

            else if (Player == enPlayer.P2)
            {
                PB8.Image = Resources.O;
                PB8.Enabled = false;
            }

            Player = ReturnNextPlayer(Player);

            UpdateGameWinner();
        }

        private void pictureBox4_Click(object sender, System.EventArgs e)
        {

            if (Player == enPlayer.P1)
            {
                PB9.Image = Resources.X;
                PB9.Enabled = false;

            }

            else if (Player == enPlayer.P2)
            {
                PB9.Image = Resources.O;
                PB9.Enabled = false;
            }

            Player = ReturnNextPlayer(Player);

            UpdateGameWinner();
        }
    }
}
