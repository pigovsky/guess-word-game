using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;

namespace Julia_jump_ball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
         
            InitializeComponent();
         
        }

        // drawing param.
        private const int BallWidth = 50;
        private const int BallHeight = 50;
        private int BallX, BallY;   // position.
        private int BallVx, BallVy; // speed.

        // random value
        public void Form1_Load(object sender, EventArgs e)
        {
            // Pick a random start position and velocity.
            
            Random rnd = new Random();
            BallVx = rnd.Next(1, 8);
            BallVy = rnd.Next(1, 8);
            BallX = rnd.Next(0, ClientSize.Width - BallWidth);
            BallY = rnd.Next(0, ClientSize.Height - BallHeight);

            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);
            this.UpdateStyles();
        }

        // Update the ball position
        private void tmrMoveBall_Tick(object sender, EventArgs e)
        {
            BallX += BallVx;
            if (BallX < 0)
            {
                BallVx = -BallVx;
               
            } else if (BallX + BallWidth > ClientSize.Width)
            {
                BallVx = -BallVx;
                
            }

            BallY += BallVy;
            if (BallY < 0)
            {
                BallVy = -BallVy;
                
            } else if (BallY + BallHeight > ClientSize.Height)
            {
                BallVy = -BallVy;
              
            }

            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
           //e.Graphics.Clear(BackColor);
            e.Graphics.FillEllipse(Brushes.HotPink, BallX, BallY, BallWidth, BallHeight);
            e.Graphics.DrawEllipse(Pens.White, BallX, BallY, BallWidth, BallHeight);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Audio Files (.wav)|*.wav";


            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                playSound(path);
                button1.Enabled = false;
            }
        
        }

            private void playSound(string path)
{
    System.Media.SoundPlayer player = 
        new System.Media.SoundPlayer();
    player.SoundLocation = path;
    player.Load();
    player.Play();
    

        }
    }
}
