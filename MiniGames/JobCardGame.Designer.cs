namespace MiniGames
{
    partial class JobCardGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobCardGame));
            this.panel_info = new System.Windows.Forms.Panel();
            this.tb_info = new System.Windows.Forms.TextBox();
            this.pb_quit = new System.Windows.Forms.PictureBox();
            this.pb_retry = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.timer_lose = new System.Windows.Forms.Timer(this.components);
            this.panel_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_retry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_info
            // 
            this.panel_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(84)))));
            this.panel_info.Controls.Add(this.tb_info);
            this.panel_info.Controls.Add(this.pb_quit);
            this.panel_info.Controls.Add(this.pb_retry);
            this.panel_info.Controls.Add(this.pictureBox1);
            this.panel_info.Location = new System.Drawing.Point(274, 181);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(237, 264);
            this.panel_info.TabIndex = 0;
            // 
            // tb_info
            // 
            this.tb_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(84)))));
            this.tb_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_info.Enabled = false;
            this.tb_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tb_info.ForeColor = System.Drawing.Color.Black;
            this.tb_info.Location = new System.Drawing.Point(3, 57);
            this.tb_info.Multiline = true;
            this.tb_info.Name = "tb_info";
            this.tb_info.ReadOnly = true;
            this.tb_info.Size = new System.Drawing.Size(231, 38);
            this.tb_info.TabIndex = 3;
            this.tb_info.Text = "Info";
            this.tb_info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pb_quit
            // 
            this.pb_quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_quit.Image = ((System.Drawing.Image)(resources.GetObject("pb_quit.Image")));
            this.pb_quit.Location = new System.Drawing.Point(137, 211);
            this.pb_quit.Name = "pb_quit";
            this.pb_quit.Size = new System.Drawing.Size(100, 50);
            this.pb_quit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_quit.TabIndex = 2;
            this.pb_quit.TabStop = false;
            this.pb_quit.Click += new System.EventHandler(this.pb_quit_Click);
            // 
            // pb_retry
            // 
            this.pb_retry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_retry.Image = ((System.Drawing.Image)(resources.GetObject("pb_retry.Image")));
            this.pb_retry.Location = new System.Drawing.Point(0, 211);
            this.pb_retry.Name = "pb_retry";
            this.pb_retry.Size = new System.Drawing.Size(100, 50);
            this.pb_retry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_retry.TabIndex = 1;
            this.pb_retry.TabStop = false;
            this.pb_retry.Click += new System.EventHandler(this.pb_retry_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pb_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 43);
            this.panel1.TabIndex = 1;
            // 
            // pb_close
            // 
            this.pb_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_close.Image = ((System.Drawing.Image)(resources.GetObject("pb_close.Image")));
            this.pb_close.Location = new System.Drawing.Point(746, 4);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(38, 36);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_close.TabIndex = 0;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            // 
            // timer_lose
            // 
            this.timer_lose.Interval = 72;
            this.timer_lose.Tick += new System.EventHandler(this.timer_lose_Tick);
            // 
            // JobCardGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JobCardGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobCardGame";
            this.Load += new System.EventHandler(this.JobCardGame_Load);
            this.panel_info.ResumeLayout(false);
            this.panel_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_quit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_retry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.PictureBox pb_quit;
        private System.Windows.Forms.PictureBox pb_retry;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.TextBox tb_info;
        private System.Windows.Forms.Timer timer_lose;
    }
}