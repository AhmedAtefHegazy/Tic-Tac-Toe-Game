namespace Tic_Tac_Toe_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.PB2 = new System.Windows.Forms.PictureBox();
            this.PB8 = new System.Windows.Forms.PictureBox();
            this.PB9 = new System.Windows.Forms.PictureBox();
            this.PB4 = new System.Windows.Forms.PictureBox();
            this.PB5 = new System.Windows.Forms.PictureBox();
            this.PB6 = new System.Windows.Forms.PictureBox();
            this.PB3 = new System.Windows.Forms.PictureBox();
            this.PB7 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB7)).BeginInit();
            this.SuspendLayout();
            // 
            // PB1
            // 
            this.PB1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_symbol;
            this.PB1.Location = new System.Drawing.Point(396, 106);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(115, 91);
            this.PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB1.TabIndex = 0;
            this.PB1.TabStop = false;
            this.PB1.Tag = "1";
            this.PB1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PB2
            // 
            this.PB2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_symbol;
            this.PB2.Location = new System.Drawing.Point(528, 106);
            this.PB2.Name = "PB2";
            this.PB2.Size = new System.Drawing.Size(115, 91);
            this.PB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB2.TabIndex = 2;
            this.PB2.TabStop = false;
            this.PB2.Tag = "2";
            this.PB2.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // PB8
            // 
            this.PB8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB8.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_symbol;
            this.PB8.Location = new System.Drawing.Point(528, 321);
            this.PB8.Name = "PB8";
            this.PB8.Size = new System.Drawing.Size(115, 91);
            this.PB8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB8.TabIndex = 3;
            this.PB8.TabStop = false;
            this.PB8.Tag = "8";
            this.PB8.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PB9
            // 
            this.PB9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB9.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_symbol;
            this.PB9.Location = new System.Drawing.Point(660, 321);
            this.PB9.Name = "PB9";
            this.PB9.Size = new System.Drawing.Size(115, 91);
            this.PB9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB9.TabIndex = 4;
            this.PB9.TabStop = false;
            this.PB9.Tag = "9";
            this.PB9.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // PB4
            // 
            this.PB4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB4.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_symbol;
            this.PB4.Location = new System.Drawing.Point(396, 215);
            this.PB4.Name = "PB4";
            this.PB4.Size = new System.Drawing.Size(115, 91);
            this.PB4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB4.TabIndex = 5;
            this.PB4.TabStop = false;
            this.PB4.Tag = "4";
            this.PB4.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // PB5
            // 
            this.PB5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB5.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_symbol;
            this.PB5.Location = new System.Drawing.Point(528, 215);
            this.PB5.Name = "PB5";
            this.PB5.Size = new System.Drawing.Size(115, 91);
            this.PB5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB5.TabIndex = 6;
            this.PB5.TabStop = false;
            this.PB5.Tag = "5";
            this.PB5.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // PB6
            // 
            this.PB6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB6.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_symbol;
            this.PB6.Location = new System.Drawing.Point(660, 215);
            this.PB6.Name = "PB6";
            this.PB6.Size = new System.Drawing.Size(115, 91);
            this.PB6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB6.TabIndex = 7;
            this.PB6.TabStop = false;
            this.PB6.Tag = "6";
            this.PB6.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // PB3
            // 
            this.PB3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB3.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_symbol;
            this.PB3.Location = new System.Drawing.Point(660, 106);
            this.PB3.Name = "PB3";
            this.PB3.Size = new System.Drawing.Size(115, 91);
            this.PB3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB3.TabIndex = 8;
            this.PB3.TabStop = false;
            this.PB3.Tag = "3";
            this.PB3.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // PB7
            // 
            this.PB7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB7.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_symbol;
            this.PB7.Location = new System.Drawing.Point(396, 321);
            this.PB7.Name = "PB7";
            this.PB7.Size = new System.Drawing.Size(115, 91);
            this.PB7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB7.TabIndex = 9;
            this.PB7.TabStop = false;
            this.PB7.Tag = "7";
            this.PB7.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 32F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(388, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 55);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tic-Tac-Toe  Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(137, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 48);
            this.label2.TabIndex = 11;
            this.label2.Text = "Turn";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPlayer.Location = new System.Drawing.Point(107, 115);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(160, 48);
            this.lblPlayer.TabIndex = 12;
            this.lblPlayer.Text = "Player 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(114, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 48);
            this.label4.TabIndex = 13;
            this.label4.Text = "Winner";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Lime;
            this.lblWinner.Location = new System.Drawing.Point(80, 225);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(215, 48);
            this.lblWinner.TabIndex = 14;
            this.lblWinner.Text = "In Progress";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Black;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Gold;
            this.btnRestart.Location = new System.Drawing.Point(85, 280);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(205, 51);
            this.btnRestart.TabIndex = 15;
            this.btnRestart.Text = "Restart Game";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB7);
            this.Controls.Add(this.PB3);
            this.Controls.Add(this.PB6);
            this.Controls.Add(this.PB5);
            this.Controls.Add(this.PB4);
            this.Controls.Add(this.PB9);
            this.Controls.Add(this.PB8);
            this.Controls.Add(this.PB2);
            this.Controls.Add(this.PB1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.PictureBox PB2;
        private System.Windows.Forms.PictureBox PB8;
        private System.Windows.Forms.PictureBox PB9;
        private System.Windows.Forms.PictureBox PB4;
        private System.Windows.Forms.PictureBox PB5;
        private System.Windows.Forms.PictureBox PB6;
        private System.Windows.Forms.PictureBox PB3;
        private System.Windows.Forms.PictureBox PB7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnRestart;
    }
}

