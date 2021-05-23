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
    public partial class GameList : Form
    {
        public GameList()
        {
            InitializeComponent();
        }

        private void GameList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void p_SnakeGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }

        private void p_SnakeGame_MouseHover(object sender, EventArgs e)
        {
            //lbl_SnakeGame.BackColor = Color.FromArgb(117, 185, 0);
        }

        private void GameList_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SnakeGame snakeGame = new SnakeGame();
            snakeGame.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            JobCardGame jcg = new JobCardGame();
            jcg.Show();
            this.Hide();
        }
    }
}
