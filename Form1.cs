using System;
using System.Windows.Forms;

namespace CarSimulator
{
    public partial class Form1 : Form
    {
        int carSpeed = 5;
        bool goLeft, goRight, goUp, goDown;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Nothing here for now
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            if (goLeft && carBox.Left > 0) carBox.Left -= carSpeed;
            if (goRight && carBox.Right < this.ClientSize.Width) carBox.Left += carSpeed;
            if (goUp && carBox.Top > 0) carBox.Top -= carSpeed;
            if (goDown && carBox.Bottom < this.ClientSize.Height) carBox.Top += carSpeed;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = true;
            if (e.KeyCode == Keys.Right) goRight = true;
            if (e.KeyCode == Keys.Up) goUp = true;
            if (e.KeyCode == Keys.Down) goDown = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = false;
            if (e.KeyCode == Keys.Right) goRight = false;
            if (e.KeyCode == Keys.Up) goUp = false;
            if (e.KeyCode == Keys.Down) goDown = false;
        }
    }
}
