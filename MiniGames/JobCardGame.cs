using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGames
{
    public partial class JobCardGame : Form
    {
        public JobCardGame()
        {
            InitializeComponent();
        }
        List<int> randomList = new List<int>();
        List<int> randomList2 = new List<int>();
        int _click;
        int pbX = 118;
        int pbY = 100;
        int j;
        int firstclick;
        int secondclick;
        int win;
        PictureBox pbfirstclick;
        PictureBox pbsecondclick;
        private void JobCardGame_Load(object sender, EventArgs e)
        {
            CreateLoadingBar(250, 30);
            panel_info.Visible = false;
            while (j < 6)
            {
                Random rnd = new Random();
                int _rnd1 = rnd.Next() % 6;
                int _rnd2 = rnd.Next() % 6;
                if (!randomList.Contains(_rnd1) && !randomList2.Contains(_rnd2))
                {
                    randomList.Add(_rnd1);
                    randomList2.Add(_rnd2);
                    j++;
                }
            }
            randomList.AddRange(randomList2);
            for (int i = 0; i < 12; i++)
            {
                string pbname = String.Format("pb{0}", i);
                PictureBox pb = new PictureBox();
                pb.Name = pbname;
                pb.Location = new Point(pbX, pbY);
                pb.Size = new Size(120, 120);
                pb.Image = Image.FromFile("images/bg.png");
                pbX += 150;
                pb.Cursor = Cursors.Hand;
                pb.BackColor = Color.Transparent;
                pb.Tag = randomList[i];
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                if (pbX > 600)
                {
                    pbY += 150;
                    pbX = 118;

                }
                this.Controls.Add(pb);

                pb.Click += new EventHandler((object sender1, EventArgs a) =>
                {
                    timer_lose.Enabled = true;
                    string imagename = String.Format("images/{0}.png", pb.Tag);
                    pb.Image = Image.FromFile(imagename);
                    _click++;
                    if (_click == 1)

                    {
                        pbfirstclick = pb;
                        firstclick = (int)pb.Tag;

                    }
                    if (_click == 2)
                    {
                        pbsecondclick = pb;
                        secondclick = (int)pb.Tag;
                    }

                    if (_click == 2 && secondclick == firstclick)
                    {
                        pbsecondclick.Enabled = false;
                        pbfirstclick.Enabled = false;
                        win++;
                        _click = 0;
                    }

                    if (_click == 3 && secondclick != firstclick)
                    {

                        pbfirstclick.Image = Image.FromFile("images/bg.png");
                        pb.Image = Image.FromFile("images/bg.png");
                        pbsecondclick.Image = Image.FromFile("images/bg.png");
                        _click = 0;

                    }
                    if (win == 6)
                    {
                        timer_lose.Stop();
                        panel_info.Visible = true;
                        tb_info.Text = "You Won"; 
                    }

                });

            }


        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
   
        }

        private void pb_retry_Click(object sender, EventArgs e)
        {
            JobCardGame jcb = new JobCardGame();
            jcb.Show();
            this.Hide();
        }

        private void pb_quit_Click(object sender, EventArgs e)
        {
            GameList gl = new GameList();
            this.Hide();
            gl.Show();
        }

        private void timer_lose_Tick(object sender, EventArgs e)
        {
            if (pBar.Width > 0)
            {
                pBar.Width -= 1;
            }
            else
            {
                timer_lose.Enabled = false;
                tb_info.Text = "Time is up";
                panel_info.Visible = true;

            }
        }
        Label pBg = new Label();
        Label pBar = new Label();

        private void CreateLoadingBar(int width, int height)
        {

            pBg.BackColor = Color.Gray;
            pBg.Width = width;
            pBg.Height = height;
            pBg.Location = new Point(this.Width / 2 - pBg.Width / 2, this.Height / 9 * 1  - pBg.Height / 2);
            this.Controls.Add(pBg);
            pBg.BringToFront();

            pBar.Width = 250;
            pBar.Height = height;
            pBar.Location = new Point(this.Width / 2 - pBg.Width / 2, this.Height / 9 * 1 - pBg.Height / 2);
            this.Controls.Add(pBar);
            pBar.BackColor = Color.FromArgb(67, 47, 191);
            pBar.BringToFront();
        }
    }
}
