using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MiniGames
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CreateLoadingBar(200, 15);
            Thread.Sleep(1000);
            timer_loading.Enabled = true;
        }

        private void timer_loading_Tick(object sender, EventArgs e)
        {
            if(pBar.Width < pBg.Width)
            {
                pBar.Width += 1;
                pInf = pBar.Width/2;
                pInfo.Text = $"{pInf}%";
            }
            else
            {
                timer_loading.Enabled = false;
                lbl_continue.Visible = true;
                isFinished = true;
            }
        }
        bool isFinished = false;
        Label pBg = new Label();
        Label pBar = new Label();
        Label pInfo = new Label();
        int pInf = 0;
        private void CreateLoadingBar(int width, int height)
        {

            pBg.BackColor = Color.Gray;
            pBg.Width = width;
            pBg.Height = height;
            pBg.Location = new Point(this.Width / 2 - pBg.Width / 2, this.Height / 6 * 5 - pBg.Height / 2);
            this.Controls.Add(pBg);
            pBg.BringToFront();
            
            pBar.Width = 0;
            pBar.Height = height;
            pBar.Location = new Point(this.Width / 2 - pBg.Width / 2, this.Height / 6 * 5 - pBg.Height / 2);
            this.Controls.Add(pBar);
            pBar.BackColor = Color.White;
            pBar.BringToFront();

            pInfo.Text = "0%";
            pInfo.Width = 80;
            //pInfo.Height = 0;
            pInfo.BackColor = Color.Black;
            pInfo.ForeColor = Color.White;
            pInfo.Font = new Font("Arial", 16, FontStyle.Bold);
            pInfo.Location = new Point(this.Width / 2 - pInfo.Width / 2 + 12, this.Height / 6 * 5 + pInfo.Height );
            this.Controls.Add(pInfo);
            pInfo.BringToFront();


        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (isFinished)
            {
                GameList gl = new GameList();
                gl.Show();
                this.Hide();
            }
        }


        private void Main_Click(object sender, EventArgs e)
        {
            if (isFinished)
            {
                GameList gl = new GameList();
                gl.Show();
                this.Hide();
            }
        }

        private void pb_bg_Click(object sender, EventArgs e)
        {
            if (isFinished)
            {
                GameList gl = new GameList();
                gl.Show();
                this.Hide();
            }
        }
    }
}
