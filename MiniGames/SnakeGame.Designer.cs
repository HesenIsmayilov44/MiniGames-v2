namespace MiniGames
{
    partial class SnakeGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnakeGame));
            this.timer_GameLoop = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_highScore = new System.Windows.Forms.Label();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.p_gameOver = new System.Windows.Forms.Panel();
            this.lbl_brokenHighScore = new System.Windows.Forms.Label();
            this.btn_gameList = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            this.lbl_gameOver = new System.Windows.Forms.Label();
            this.lbl_lastKey = new System.Windows.Forms.Label();
            this.snakeHeadLeft = new System.Windows.Forms.Label();
            this.snakeHeadRight = new System.Windows.Forms.Label();
            this.snakeHeadDown = new System.Windows.Forms.Label();
            this.snakeHeadUp = new System.Windows.Forms.Label();
            this.pb_info = new System.Windows.Forms.PictureBox();
            this.apple = new System.Windows.Forms.Label();
            this.snakeTail = new System.Windows.Forms.Label();
            this.p_gameOver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_info)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_GameLoop
            // 
            this.timer_GameLoop.Tick += new System.EventHandler(this.timer_GameLoop_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 5);
            this.panel1.TabIndex = 0;
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.Color.Red;
            this.lbl_score.Location = new System.Drawing.Point(11, 13);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(92, 25);
            this.lbl_score.TabIndex = 1;
            this.lbl_score.Text = "Score: 0";
            // 
            // lbl_highScore
            // 
            this.lbl_highScore.AutoSize = true;
            this.lbl_highScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_highScore.ForeColor = System.Drawing.Color.Red;
            this.lbl_highScore.Location = new System.Drawing.Point(782, 13);
            this.lbl_highScore.Name = "lbl_highScore";
            this.lbl_highScore.Size = new System.Drawing.Size(79, 25);
            this.lbl_highScore.TabIndex = 2;
            this.lbl_highScore.Text = "Best: 0";
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_speed.ForeColor = System.Drawing.Color.Red;
            this.lbl_speed.Location = new System.Drawing.Point(376, 13);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(98, 25);
            this.lbl_speed.TabIndex = 5;
            this.lbl_speed.Text = "Speed: 0";
            // 
            // p_gameOver
            // 
            this.p_gameOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.p_gameOver.Controls.Add(this.lbl_brokenHighScore);
            this.p_gameOver.Controls.Add(this.btn_gameList);
            this.p_gameOver.Controls.Add(this.btn_restart);
            this.p_gameOver.Controls.Add(this.lbl_gameOver);
            this.p_gameOver.Location = new System.Drawing.Point(300, 95);
            this.p_gameOver.Name = "p_gameOver";
            this.p_gameOver.Size = new System.Drawing.Size(247, 335);
            this.p_gameOver.TabIndex = 11;
            this.p_gameOver.Visible = false;
            // 
            // lbl_brokenHighScore
            // 
            this.lbl_brokenHighScore.AutoSize = true;
            this.lbl_brokenHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brokenHighScore.ForeColor = System.Drawing.Color.Red;
            this.lbl_brokenHighScore.Location = new System.Drawing.Point(50, 74);
            this.lbl_brokenHighScore.Name = "lbl_brokenHighScore";
            this.lbl_brokenHighScore.Size = new System.Drawing.Size(149, 24);
            this.lbl_brokenHighScore.TabIndex = 5;
            this.lbl_brokenHighScore.Text = "New High Score";
            this.lbl_brokenHighScore.Visible = false;
            // 
            // btn_gameList
            // 
            this.btn_gameList.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            this.btn_gameList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_gameList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gameList.FlatAppearance.BorderSize = 0;
            this.btn_gameList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gameList.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gameList.ForeColor = System.Drawing.Color.White;
            this.btn_gameList.Location = new System.Drawing.Point(61, 227);
            this.btn_gameList.Name = "btn_gameList";
            this.btn_gameList.Size = new System.Drawing.Size(127, 40);
            this.btn_gameList.TabIndex = 4;
            this.btn_gameList.Text = "Game List";
            this.btn_gameList.UseVisualStyleBackColor = false;
            this.btn_gameList.Click += new System.EventHandler(this.btn_gameList_Click);
            // 
            // btn_restart
            // 
            this.btn_restart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_restart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_restart.FlatAppearance.BorderSize = 0;
            this.btn_restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restart.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restart.ForeColor = System.Drawing.Color.White;
            this.btn_restart.Location = new System.Drawing.Point(61, 158);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(127, 40);
            this.btn_restart.TabIndex = 3;
            this.btn_restart.Text = "Restart";
            this.btn_restart.UseVisualStyleBackColor = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // lbl_gameOver
            // 
            this.lbl_gameOver.AutoSize = true;
            this.lbl_gameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gameOver.ForeColor = System.Drawing.Color.Red;
            this.lbl_gameOver.Location = new System.Drawing.Point(16, 22);
            this.lbl_gameOver.Name = "lbl_gameOver";
            this.lbl_gameOver.Size = new System.Drawing.Size(217, 39);
            this.lbl_gameOver.TabIndex = 0;
            this.lbl_gameOver.Text = "Game Over!";
            // 
            // lbl_lastKey
            // 
            this.lbl_lastKey.AutoSize = true;
            this.lbl_lastKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastKey.ForeColor = System.Drawing.Color.Red;
            this.lbl_lastKey.Location = new System.Drawing.Point(581, 13);
            this.lbl_lastKey.Name = "lbl_lastKey";
            this.lbl_lastKey.Size = new System.Drawing.Size(60, 25);
            this.lbl_lastKey.TabIndex = 12;
            this.lbl_lastKey.Text = "none";
            // 
            // snakeHeadLeft
            // 
            this.snakeHeadLeft.AutoSize = true;
            this.snakeHeadLeft.Image = global::MiniGames.Properties.Resources.snakeHeadLeft1;
            this.snakeHeadLeft.Location = new System.Drawing.Point(170, 522);
            this.snakeHeadLeft.Name = "snakeHeadLeft";
            this.snakeHeadLeft.Size = new System.Drawing.Size(35, 13);
            this.snakeHeadLeft.TabIndex = 10;
            this.snakeHeadLeft.Text = "label1";
            this.snakeHeadLeft.Visible = false;
            // 
            // snakeHeadRight
            // 
            this.snakeHeadRight.AutoSize = true;
            this.snakeHeadRight.Image = global::MiniGames.Properties.Resources.snakeHeadRight1;
            this.snakeHeadRight.Location = new System.Drawing.Point(129, 522);
            this.snakeHeadRight.Name = "snakeHeadRight";
            this.snakeHeadRight.Size = new System.Drawing.Size(35, 13);
            this.snakeHeadRight.TabIndex = 9;
            this.snakeHeadRight.Text = "label1";
            this.snakeHeadRight.Visible = false;
            // 
            // snakeHeadDown
            // 
            this.snakeHeadDown.AutoSize = true;
            this.snakeHeadDown.Image = global::MiniGames.Properties.Resources.snakeHeadDown1;
            this.snakeHeadDown.Location = new System.Drawing.Point(88, 522);
            this.snakeHeadDown.Name = "snakeHeadDown";
            this.snakeHeadDown.Size = new System.Drawing.Size(35, 13);
            this.snakeHeadDown.TabIndex = 8;
            this.snakeHeadDown.Text = "label1";
            this.snakeHeadDown.Visible = false;
            // 
            // snakeHeadUp
            // 
            this.snakeHeadUp.AutoSize = true;
            this.snakeHeadUp.Image = global::MiniGames.Properties.Resources.snakeHeadUp1;
            this.snakeHeadUp.Location = new System.Drawing.Point(47, 522);
            this.snakeHeadUp.Name = "snakeHeadUp";
            this.snakeHeadUp.Size = new System.Drawing.Size(35, 13);
            this.snakeHeadUp.TabIndex = 7;
            this.snakeHeadUp.Text = "label1";
            this.snakeHeadUp.Visible = false;
            // 
            // pb_info
            // 
            this.pb_info.BackgroundImage = global::MiniGames.Properties.Resources.SneakInfo;
            this.pb_info.Location = new System.Drawing.Point(438, 419);
            this.pb_info.Name = "pb_info";
            this.pb_info.Size = new System.Drawing.Size(450, 150);
            this.pb_info.TabIndex = 6;
            this.pb_info.TabStop = false;
            // 
            // apple
            // 
            this.apple.AutoSize = true;
            this.apple.Image = global::MiniGames.Properties.Resources.apple;
            this.apple.Location = new System.Drawing.Point(784, 536);
            this.apple.Name = "apple";
            this.apple.Size = new System.Drawing.Size(0, 13);
            this.apple.TabIndex = 4;
            this.apple.Visible = false;
            // 
            // snakeTail
            // 
            this.snakeTail.AutoSize = true;
            this.snakeTail.Image = global::MiniGames.Properties.Resources.snakeTile;
            this.snakeTail.Location = new System.Drawing.Point(863, 536);
            this.snakeTail.Name = "snakeTail";
            this.snakeTail.Size = new System.Drawing.Size(0, 13);
            this.snakeTail.TabIndex = 3;
            this.snakeTail.Visible = false;
            // 
            // SnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(900, 570);
            this.Controls.Add(this.lbl_lastKey);
            this.Controls.Add(this.p_gameOver);
            this.Controls.Add(this.snakeHeadLeft);
            this.Controls.Add(this.snakeHeadRight);
            this.Controls.Add(this.snakeHeadDown);
            this.Controls.Add(this.snakeHeadUp);
            this.Controls.Add(this.pb_info);
            this.Controls.Add(this.lbl_speed);
            this.Controls.Add(this.apple);
            this.Controls.Add(this.snakeTail);
            this.Controls.Add(this.lbl_highScore);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SnakeGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SnakeGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SnakeGame_FormClosing);
            this.Load += new System.EventHandler(this.SnakeGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SnakeGame_KeyDown);
            this.p_gameOver.ResumeLayout(false);
            this.p_gameOver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_GameLoop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_highScore;
        private System.Windows.Forms.Label snakeTail;
        private System.Windows.Forms.Label apple;
        private System.Windows.Forms.Label lbl_speed;
        private System.Windows.Forms.PictureBox pb_info;
        private System.Windows.Forms.Label snakeHeadUp;
        private System.Windows.Forms.Label snakeHeadDown;
        private System.Windows.Forms.Label snakeHeadRight;
        private System.Windows.Forms.Label snakeHeadLeft;
        private System.Windows.Forms.Panel p_gameOver;
        private System.Windows.Forms.Label lbl_brokenHighScore;
        private System.Windows.Forms.Button btn_gameList;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Label lbl_gameOver;
        private System.Windows.Forms.Label lbl_lastKey;
    }
}