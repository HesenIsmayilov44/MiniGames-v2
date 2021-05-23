using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace MiniGames
{
    public partial class SnakeGame : Form
    {
        public SnakeGame()
        {
            InitializeComponent();
        }

        int snakeX = 60, snakeY = 60;
        int xSpeed = 0;
        int ySpeed = 0;
        int foodX = 150;
        int foodY = 210;
        int highScore = 0;
        int screenX = 900;
        int screenY = 570;
        int fps = 10;
        bool game = false;
        bool pressKey = true;
        Label snakeHead = new Label();
        

        SoundPlayer eat = new SoundPlayer(@"sounds\crunch.wav");
        SoundPlayer dead = new SoundPlayer(@"sounds\fail.wav");
        SoundPlayer start = new SoundPlayer(@"sounds\start.wav");


        List<Label> labels = new List<Label>();
        Label food = new Label();

        private void SnakeGame_Load(object sender, EventArgs e)
        {
            initGame();   
        }
        int turn = 0;
        private void timer_GameLoop_Tick(object sender, EventArgs e)
        {
            if(tsx != 0 || tsy != 0)
            {
                turn += 1;
            }
            if(turn == 2)
            {
                xSpeed = tsx;
                ySpeed = tsy;
                turn = 0;
                tsx = 0;
                tsy = 0;
            }
            moveSnake();
            pressKey = true;
            
            for(int i=1; i<labels.Count; i++)
            {
                labels[i].Image = snakeTail.Image;
            }
            controlCrash();
            controlEat();
        }
        private void moveSnake()
        {
            snakeX += xSpeed;
            snakeY += ySpeed;
            if(snakeX == screenX)
            {
                snakeX = 0;
            }
            else if(snakeX == -15)
            {
                snakeX = screenX - 15;
            }
            if(snakeY == 45)
            {
                snakeY = screenY - 15;
            }else if(snakeY == screenY)
            {
                snakeY = 60;
            }
            Label head = new Label();
            head.Location = new Point(snakeX, snakeY);
            head.Size = new Size(15, 15);
            //head.BackColor = Color.Red;
            head.Image = snakeHead.Image;
            labels.Insert(0, head);
            this.Controls.Add(head);

            this.Controls.Remove(labels[labels.Count - 1]);
            labels.RemoveAt(labels.Count - 1);
        }

        private void controlEat()
        {
            if (labels[0].Location == new Point(foodX, foodY))
            {
               
                eat.Play();
                randomFoodPoint();
                createNewFood();
                addTail();
                int score = labels.Count - 3;
                if (score % 5 == 0)
                {
                    fps += 5;
                    lbl_speed.Text = $"Speed: {fps}";
                    timer_GameLoop.Interval = 1000 / fps;
                }
                lbl_score.Text = $"Score: {score}";
            }
        }
        private void addTail()
        {
            Label head = new Label();
            head.Location = new Point(snakeX, snakeY);
            head.Size = new Size(15, 15);
            //head.BackColor = Color.Red;
            head.Image = snakeHead.Image;
            labels.Insert(0, head);
            this.Controls.Add(head);
        }
        private void randomFoodPoint()
        {

            Random rnd = new Random();
            int positionX;
            int positionY;
            while (true)
            {
                bool isCollision = false;
                positionX = rnd.Next(0, 900);
                positionY = rnd.Next(60, 560);
                foreach(var tail in labels)
                {
                    if(tail.Location == new Point(positionX, positionY))
                    {
                        isCollision = true;
                        break;
                    }
                    
                }
                if (!isCollision) break;
            }

            foodX = positionX - (positionX % 15);
            foodY = positionY - (positionY % 15);

        }
        private void controlCrash()
        {
            for(int i = 1; i< labels.Count; i++)
            {
                if(labels[0].Location == labels[i].Location && labels.Count >3)
                {
                    labels[0].BringToFront();
                    timer_GameLoop.Enabled = false;
                    if(labels.Count-3 > highScore)
                    {
                        lbl_brokenHighScore.Visible = true;
                        StreamWriter sw = new StreamWriter("highScore.txt");
                        sw.Write($"{labels.Count - 3}");
                        sw.Close();
                    }
                    dead.Play();
                    p_gameOver.Visible = true;
                    p_gameOver.BringToFront();

                }
            }
        }
        private void initGame()
        {
            StreamReader sr = new StreamReader("highScore.txt");
            highScore =  Int32.Parse(sr.ReadLine());
            sr.Close();
            lbl_highScore.Text = $"Best {highScore}";

            snakeHead.Image = snakeHeadRight.Image;
            createSnake();
            createNewFood();
            timer_GameLoop.Interval = 1000 / fps;
            timer_GameLoop.Enabled = true;
        }
        private void createNewFood()
        {
            food.BackColor = Color.Red;
            food.Image = apple.Image;
            food.Location = new Point(foodX, foodY);
            food.Size = new Size(15, 15);
            this.Controls.Add(food);
        }
        private void resetGame()
        {
            /*
             snakeX = 60;
            snakeY = 60;
            xSpeed = 0;
            ySpeed = 0;
            foodX = 150;
            foodY = 210;
            fps = 10;
            labels = new List<Label>();
            p_gameOver.Visible = false;
            pb_info.Visible = true;
            bool game = false;
             */
            SnakeGame snakeGame = new SnakeGame();
            snakeGame.Show();
            this.Hide();
            //initGame();
        }
        private void createSnake()
        {
            for(int i=0; i < 3; i++)
            {
                Label label = new Label();
                label.Text = " ";
                //label.BackColor = Color.Red;
                label.Image = snakeHead.Image;
                label.Location = new Point(snakeX, snakeY);
                label.Size = new Size(15, 15);
                labels.Add(label);
                this.Controls.Add(label);
            }
            labels[0].BringToFront();


        }

        int tsx = 0;
        int tsy = 0;
        private void SnakeGame_KeyDown(object sender, KeyEventArgs e)
        {
            lbl_lastKey.Visible = false;
            lbl_lastKey.Text = e.KeyCode.ToString();
            if (e.KeyCode == Keys.Escape && !p_gameOver.Visible)
            {
                timer_GameLoop.Enabled = !timer_GameLoop.Enabled;
            }

            if (e.KeyCode == Keys.Down && ySpeed != -15)
            {
                if (!game)
                {
                    gameStarted();
                }
                if (!pressKey)
                {
                    tsx = 0;
                    tsy = 15;
                    return;
                }
                xSpeed = 0;
                ySpeed = 15;
                snakeHead.Image = snakeHeadDown.Image;
                pressKey = false;
            }
            if (e.KeyCode == Keys.Right && xSpeed != -15)
            {
                if (!game)
                {
                    gameStarted();
                }
                if (!pressKey)
                {
                    tsx = 15;
                    tsy = 0;
                    return;
                }
                ySpeed = 0;
                xSpeed = 15;
                snakeHead.Image = snakeHeadRight.Image;
                pressKey = false;
            }
            if (e.KeyCode == Keys.Up && ySpeed != 15)
            {
                if (!game)
                {
                    gameStarted();
                }
                if (!pressKey)
                {
                    tsx = 0;
                    tsy = -15;
                    return;
                }
                ySpeed = -15;
                xSpeed = 0;
                snakeHead.Image = snakeHeadUp.Image;
                pressKey = false;
            }
            if (e.KeyCode == Keys.Left && xSpeed != 15)
            {
                if (!game)
                {
                    gameStarted();
                }
                if (!pressKey)
                {
                    tsx = -15;
                    tsy = 0;
                    return;
                }
                ySpeed = 0;
                xSpeed = -15;
                snakeHead.Image = snakeHeadLeft.Image;
                pressKey = false;
            }
        }
        private void gameStarted()
        {
            start.Play();
            game = true;
            pb_info.Visible = false;
            lbl_speed.Text = $"Speed: {fps}";
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void btn_gameList_Click(object sender, EventArgs e)
        {
            GameList gameList = new GameList();
            gameList.Show();
            this.Hide();
        }

        private void SnakeGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
