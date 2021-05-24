namespace MiniGames
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pb_bg = new System.Windows.Forms.PictureBox();
            this.timer_loading = new System.Windows.Forms.Timer(this.components);
            this.lbl_continue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bg)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_bg
            // 
            this.pb_bg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_bg.BackgroundImage")));
            this.pb_bg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_bg.Location = new System.Drawing.Point(0, 0);
            this.pb_bg.Name = "pb_bg";
            this.pb_bg.Size = new System.Drawing.Size(884, 561);
            this.pb_bg.TabIndex = 0;
            this.pb_bg.TabStop = false;
            this.pb_bg.Click += new System.EventHandler(this.pb_bg_Click);
            // 
            // timer_loading
            // 
            this.timer_loading.Interval = 5;
            this.timer_loading.Tick += new System.EventHandler(this.timer_loading_Tick);
            // 
            // lbl_continue
            // 
            this.lbl_continue.AutoSize = true;
            this.lbl_continue.BackColor = System.Drawing.Color.Black;
            this.lbl_continue.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_continue.ForeColor = System.Drawing.Color.White;
            this.lbl_continue.Location = new System.Drawing.Point(360, 459);
            this.lbl_continue.Name = "lbl_continue";
            this.lbl_continue.Size = new System.Drawing.Size(144, 18);
            this.lbl_continue.TabIndex = 1;
            this.lbl_continue.Text = "Press any Key -->";
            this.lbl_continue.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lbl_continue);
            this.Controls.Add(this.pb_bg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Games";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Click += new System.EventHandler(this.Main_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pb_bg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_bg;
        private System.Windows.Forms.Timer timer_loading;
        private System.Windows.Forms.Label lbl_continue;
    }
}

