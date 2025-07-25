using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarSimulator
{
    public partial class Form1 : Form
    {
        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 15;
        int Score;
        int carImage;

        Random rand = new Random();
        Random carPosition = new Random();

        bool goleft, goright;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            ResetGame();

            // Set parent to enable transparency
            won1.Parent = roadTrack1;
            won1.Parent = roadTrack2;
            car1.Parent = roadTrack1;
            car1.Parent = roadTrack2;
            car2.Parent = roadTrack1;
            car2.Parent = roadTrack2;
            car3.Parent = roadTrack1;
            car3.Parent = roadTrack2;
           
            ai1.Parent = roadTrack1;
            ai1.Parent = roadTrack2;


        }


        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            if (goleft == true && car1.Left > 70)
            {
                car1.Left -= playerSpeed;
            }
            if (goright == true && car1.Left < 415)
            { car1.Left += playerSpeed; }
        }

     
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             
        }

        private void  changeAicars(PictureBox tempCar)
        {

        }
        private void gameOver()
        {

        }
        private void ResetGame()
        {
            btnStart.Enabled = false;
            ai1.Visible = false;
            won1.Visible = false;
            goleft = false;
            goright = false;
            Score = 0;
            won1.Image = Properties.Resources.internImg;

            roadSpeed = 15;
            trafficSpeed = 15;

            car2.Top = carPosition.Next(200, 500) * -1;
            car2.Left = carPosition.Next(80, 220);

            car3.Top = carPosition.Next(200, 500) * -1;
            car3.Left = carPosition.Next(350, 425);

            gameTimer.Start();

        }

        private void won1_Click(object sender, EventArgs e)
        {

        }

        private void playSound()
        {

        }

    }
}
