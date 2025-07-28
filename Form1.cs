﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarSimulator
{
    public partial class Form1 : Form
    {
        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 10;
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
        
            car1.BackColor = Color.Transparent;
          


           
         


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

            txtScore.Text = "Score: " + Score;
            Score++;

            if (goleft == true && car1.Left > 70)
            {
                car1.Left -= playerSpeed;
            }
            if (goright == true && car1.Left < 415)
            { car1.Left += playerSpeed; }

            roadTrack1.Top += roadSpeed;
            roadTrack2.Top += roadSpeed;

            if (roadTrack2.Top > 582)
            {
                roadTrack2.Top = -582;
            }
            if (roadTrack1.Top > 582)
            {
                roadTrack1.Top = -582;
            }

            car2.Top += trafficSpeed;
            car3.Top += trafficSpeed;

            if (car2.Top > 582)
            {
                changeAicars(car2);
            }
            if(car3.Top > 582)
            {
                changeAicars(car3);
            }
            if (car1.Bounds.IntersectsWith(car2.Bounds) || car1.Bounds.IntersectsWith(car3.Bounds))
            {
                gameOver();
            }
            if(Score > 40 && Score < 500 )
            {
               won1.Image = Properties.Resources.intern;
            }

            if (Score > 500 && Score < 2000 )
            {
                won1.Image= Properties.Resources.junior;
                roadSpeed = 15;
                trafficSpeed = 13;
            }
            if(Score >2000 )
            {
                won1.Image = Properties.Resources.senior;
                roadSpeed = 20;
                trafficSpeed = 18;
            }

        }
           

     
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             
        }

        private void  changeAicars(PictureBox tempCar)
        {
            carImage = rand.Next(1, 9);

            switch(carImage)
            {
                case 1:
                    tempCar.Image = Properties.Resources.Lambo; 
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.Bike2;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.Truck1;

                    break;
                case 4:
                    tempCar.Image = Properties.Resources.Autobus;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.silverCar;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.Jepp1;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.Bike1; 
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.Suv;
                    break;
                case 9:
                    tempCar.Image = Properties.Resources.v8;
                    break;
            }

            tempCar.Top = carPosition.Next(100, 400) * -1;

            if((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(80, 220);
            }
            if((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(350, 425);
            }
        }
        private void gameOver()
        {
            gameTimer.Stop();
            ai1.Visible = true;
            car1.Controls.Add(ai1);
            ai1.Location = new Point(-8, 5);
            ai1.BackColor = Color.Transparent;

            won1.Visible = true;
            won1.BringToFront();

            btnStart.Enabled = true;

        }
        private void ResetGame()
        {
            btnStart.Enabled = false;
            ai1.Visible = false;
            won1.Visible = false;
            goleft = false;
            goright = false;
            Score = 0;
            won1.Image = Properties.Resources.senior;

            roadSpeed = 10;
            trafficSpeed = 08;

            car2.Top = carPosition.Next(200, 500) * -1;
            car2.Left = carPosition.Next(80, 220);

            car3.Top = carPosition.Next(200, 500) * -1;
            car3.Left = carPosition.Next(350, 425);

            gameTimer.Start();

        }

        private void won1_Click(object sender, EventArgs e)
        {

        }

        private void roadTrack2_Click(object sender, EventArgs e)
        {

        }

        private void playSound()
        {

        }

    }
}
