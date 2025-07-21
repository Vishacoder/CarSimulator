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

            // Set parent to enable transparency
            won1.Parent = roadTrack1;
            won1.Parent = roadTrack2;
            car1.Parent = roadTrack1;
            car1.Parent = roadTrack2;
            car2.Parent = roadTrack1;
            car2.Parent = roadTrack2;
            car3.Parent = roadTrack1;
            car3.Parent = roadTrack2;
            car4.Parent = roadTrack1;
            car4.Parent = roadTrack2;
            ai1.Parent = roadTrack1;
            ai1.Parent = roadTrack2;


        }


        private void keyisdown(object sender, KeyEventArgs e)
        {

        }

        private void keyisup(object sender, KeyEventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {

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

        }
        private void playSound()
        {

        }

    }
}
