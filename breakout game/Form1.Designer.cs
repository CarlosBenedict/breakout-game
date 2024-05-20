namespace breakout_game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtScore = new Label();
            player = new PictureBox();
            ball = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox15 = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            SuspendLayout();
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtScore.ForeColor = SystemColors.Control;
            txtScore.Location = new Point(12, 9);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(98, 31);
            txtScore.TabIndex = 0;
            txtScore.Text = "Score: 0";
            // 
            // player
            // 
            player.BackColor = SystemColors.ButtonFace;
            player.Location = new Point(373, 550);
            player.Name = "player";
            player.Size = new Size(100, 32);
            player.TabIndex = 1;
            player.TabStop = false;
            // 
            // ball
            // 
            ball.BackColor = Color.FromArgb(0, 0, 192);
            ball.Location = new Point(410, 354);
            ball.Name = "ball";
            ball.Size = new Size(23, 22);
            ball.TabIndex = 2;
            ball.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.Location = new Point(118, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 32);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "blocks";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonFace;
            pictureBox2.Location = new Point(637, 77);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 32);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "blocks";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonFace;
            pictureBox3.Location = new Point(505, 77);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 32);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "blocks";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ButtonFace;
            pictureBox4.Location = new Point(373, 77);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 32);
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "blocks";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ButtonFace;
            pictureBox5.Location = new Point(249, 77);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 32);
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "blocks";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.ButtonFace;
            pictureBox6.Location = new Point(249, 134);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 32);
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "blocks";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = SystemColors.ButtonFace;
            pictureBox7.Location = new Point(373, 134);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(100, 32);
            pictureBox7.TabIndex = 11;
            pictureBox7.TabStop = false;
            pictureBox7.Tag = "blocks";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = SystemColors.ButtonFace;
            pictureBox8.Location = new Point(505, 134);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(100, 32);
            pictureBox8.TabIndex = 10;
            pictureBox8.TabStop = false;
            pictureBox8.Tag = "blocks";
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = SystemColors.ButtonFace;
            pictureBox9.Location = new Point(637, 134);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(100, 32);
            pictureBox9.TabIndex = 9;
            pictureBox9.TabStop = false;
            pictureBox9.Tag = "blocks";
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = SystemColors.ButtonFace;
            pictureBox10.Location = new Point(118, 134);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(100, 32);
            pictureBox10.TabIndex = 8;
            pictureBox10.TabStop = false;
            pictureBox10.Tag = "blocks";
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = SystemColors.ButtonFace;
            pictureBox11.Location = new Point(249, 197);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(100, 32);
            pictureBox11.TabIndex = 17;
            pictureBox11.TabStop = false;
            pictureBox11.Tag = "blocks";
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = SystemColors.ButtonFace;
            pictureBox12.Location = new Point(373, 197);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(100, 32);
            pictureBox12.TabIndex = 16;
            pictureBox12.TabStop = false;
            pictureBox12.Tag = "blocks";
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = SystemColors.ButtonFace;
            pictureBox13.Location = new Point(505, 197);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(100, 32);
            pictureBox13.TabIndex = 15;
            pictureBox13.TabStop = false;
            pictureBox13.Tag = "blocks";
            // 
            // pictureBox14
            // 
            pictureBox14.BackColor = SystemColors.ButtonFace;
            pictureBox14.Location = new Point(637, 197);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(100, 32);
            pictureBox14.TabIndex = 14;
            pictureBox14.TabStop = false;
            pictureBox14.Tag = "blocks";
            // 
            // pictureBox15
            // 
            pictureBox15.BackColor = SystemColors.ButtonFace;
            pictureBox15.Location = new Point(118, 197);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(100, 32);
            pictureBox15.TabIndex = 13;
            pictureBox15.TabStop = false;
            pictureBox15.Tag = "blocks";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += mainGameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(815, 594);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox14);
            Controls.Add(pictureBox15);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(ball);
            Controls.Add(player);
            Controls.Add(txtScore);
            Name = "Form1";
            Text = "Form1";
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtScore;
        private PictureBox player;
        private PictureBox ball;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private System.Windows.Forms.Timer gameTimer;
    }
}