using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        int carspeed = 5;
        int roadspeed = 5;
        bool carleft;
        bool carright;
        int traffficspeed = 5;
        int score = 0;
        Random rd = new Random();
        public Form1()
        {
            InitializeComponent();
            Reset();
        }

        private void Reset()
        {
            trophy.Visible = false;
            btStart.Enabled = false;
            explosion.Visible = false;
            traffficspeed = 5;
            roadspeed = 5;
            score = 0;
            player.Left = 161;
            player.Top = 286;
            carleft = false;
            carright = false;

            Al1.Left = 66;
            Al1.Top = -120;

            Al2.Left = 294;
            Al2.Top = -185;

            roadTrack2.Left = -3;
            roadTrack2.Top = -222;
            roadTrack1.Left = -2;
            roadTrack1.Top = -638;

            timer1.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //tinh diem
            score++;
            distance.Text = "" + score;
            roadTrack1.Top += roadspeed;
            roadTrack2.Top += roadspeed;

            if(roadTrack1.Top > 630)
            {
                roadTrack1.Top = -630;

            }
            if (roadTrack2.Top > 630)
            {
                roadTrack2.Top = -630;

            }
            if(carleft)
            {
                player.Left -= carspeed;
            }
            if (carright)
            {
                player.Left += carspeed;
            }
            if(player.Left <1)
            {
                carleft = false;
            }
            else if (player.Left + player.Width >380)
            {
                carright = false;
            }

            Al1.Top += traffficspeed;
            Al2.Top += traffficspeed;
            //xuat hien Al
            if (Al1.Top > panel1.Height)
            {
                changeAl1();
                Al1.Left = rd.Next(2, 160);
                Al1.Top = rd.Next(100, 200) * -1;
            }
            if (Al2.Top > panel1.Height)
            {
                changeAl2();
                Al2.Left = rd.Next(185,327);
                Al2.Top = rd.Next(100, 200) * -1;
            }
            //xu thua
            if(player.Bounds.IntersectsWith(Al1.Bounds) || player.Bounds.IntersectsWith(Al2.Bounds))
            {
                gameover();
            }
            //tang toc diem cao
            if(score >100 && score <500)
            {
                traffficspeed = 6;
                roadspeed = 7;
            }
            else if (score >= 500 && score < 1000)
            {
                traffficspeed = 10;
                roadspeed = 11;
            }
            else if (score >= 1000 )
            {
                traffficspeed = 12;
                roadspeed = 13;
            }
        }

        private void movecar(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left && player.Left >0)
            {
                carleft = true;
            }
            if (e.KeyCode == Keys.Right && player.Left + player.Width < panel1.Width)
            {
                carright = true;
            }
        }

        private void stopcar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left )
            {
                carleft = false;
            }
            if (e.KeyCode == Keys.Right )
            {
                carright = false;
            }
        }

        private void changeAl1()
        {
            int num = rd.Next(1, 8);
            switch (num)
            {
                case 1:
                    Al1.Image = Properties.Resources.carGreen;
                    break;
                case 2:
                    Al1.Image = Properties.Resources.carGrey;
                    break;
                case 3:
                    Al1.Image = Properties.Resources.carOrange;
                    break;
                case 4:
                    Al1.Image = Properties.Resources.carPink;
                    break;
                case 5:
                    Al1.Image = Properties.Resources.CarRed;
                    break;
                case 6:
                    Al1.Image = Properties.Resources.TruckBlue;
                    break;
                case 7:
                    Al1.Image = Properties.Resources.TruckWhite;
                    break;
                case 8:
                    Al1.Image = Properties.Resources.ambulance;
                    break;
                default: break;
            }
        }
        private void changeAl2()
        {
            int num = rd.Next(1, 8);
            switch (num)
            {
                case 1:
                    Al2.Image = Properties.Resources.carGreen;
                    break;
                case 2:
                    Al2.Image = Properties.Resources.carGrey;
                    break;
                case 3:
                    Al2.Image = Properties.Resources.carOrange;
                    break;
                case 4:
                    Al2.Image = Properties.Resources.carPink;
                    break;
                case 5:
                    Al2.Image = Properties.Resources.CarRed;
                    break;
                case 6:
                    Al2.Image = Properties.Resources.TruckBlue;
                    break;
                case 7:
                    Al2.Image = Properties.Resources.TruckWhite;
                    break;
                case 8:
                    Al2.Image = Properties.Resources.ambulance;
                    break;
                default: break;
            }
        }

        private void gameover()
        {
            trophy.Visible = true;
            timer1.Stop();
            btStart.Enabled = true;
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-8, 5);
            explosion.BackColor = Color.Transparent;
            explosion.BringToFront();

            if(score >1000)
            {
                trophy.Image = Properties.Resources.bronze;
            }
            if (score >1500)
            {
                trophy.Image = Properties.Resources.silver;
            }
            if (score > 2000)
            {
                trophy.Image = Properties.Resources.gold;
            }

            playSound();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void playSound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"hit.wav");
            player.Play();
        }
    }
}
