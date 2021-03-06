﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Project_Game
{
    public partial class _2Cars : Form
    {
        // địa chỉ nhạc
        SoundPlayer Shut = new SoundPlayer(@"ShutDown.wav");
        SoundPlayer playgame = new SoundPlayer(@"nhac2cars.wav");

        // biến toàn cục
        int TDDuong = 5;
        bool Trai1;
        bool Phai1;
        bool Trai2;
        bool Phai2;
        int TocDoDC = 5;
        int Diem = 0;
        Random rd = new Random();
        public _2Cars()
        {
            InitializeComponent();
            playgame.Play();
        }
        private void Reset()
        {
            lbIntro.Enabled = false;
            btnStart.Enabled = false;
            playgame.PlayLooping();
            this.pcbChienThang.Visible = false;

            TocDoDC = 5; 
            TDDuong = 5; 
            Diem = 0; 

            pcbPlayer1.Left = 130; 
            pcbPlayer1.Top = 308; 

            pcbPlayer2.Left = 224; 
            pcbPlayer2.Top = 308;

            Trai1 = false;
            Phai1 = false;
            Trai2 = false;
            Phai2 = false;

            Food1.Left = 130;
            Food1.Top = 136;
            Food2.Left = 224;
            Food2.Top = 3;
            No1.Left = 62;
            No1.Top = 3;
            No2.Left = 300;
            No2.Top = 136;


            pcbDuong2.Left = -3;
            pcbDuong2.Top = -222;
            pcbDuong1.Left = -2;
            pcbDuong1.Top = -638;

            score.Start();
        }
        private void score_Tick_1(object sender, EventArgs e)
        {
        
            pcbDuong1.Top += TDDuong;
            pcbDuong2.Top += TDDuong;

            if (pcbDuong1.Top > 630)
            {
                pcbDuong1.Top = -630;
            }
            if (pcbDuong2.Top > 630)
            {
                pcbDuong2.Top = -630;
            }

            if (Trai1)
            {
                pcbPlayer1.Left = 55;

            }
            if (Phai1)
            {
                pcbPlayer1.Left = 130;

            }
            if (Trai2)
            {
                pcbPlayer2.Left = 224;

            }
            if (Phai2)
            {
                pcbPlayer2.Left = 295;

            }

            Food1.Top += TocDoDC;
            Food2.Top += TocDoDC;
            No2.Top += TocDoDC;
            No1.Top += TocDoDC;

            // va chạm
            if (pcbPlayer1.Bounds.IntersectsWith(No1.Bounds) || pcbPlayer2.Bounds.IntersectsWith(No2.Bounds) || Food1.Bottom > plNen.Height || Food2.Bottom > plNen.Height)
            {
                Shut.Play();
                GameOver();

            }
            if (pcbPlayer1.Bounds.IntersectsWith(Food1.Bounds))
            {
                XuatHien1();
                Diem++;
                this.lbDiem.Text = Diem.ToString();
            }
            if (No1.Top > plNen.Height)
            {
                XuatHien3();
            }
            if (pcbPlayer2.Bounds.IntersectsWith(Food2.Bounds))
            {
                XuatHien2();
                Diem++;
                this.lbDiem.Text = Diem.ToString();
            }
          
            if (No2.Top > plNen.Height)
            {
                XuatHien4();
            }


            if (Diem > 20 && Diem <=50)
            {
                TDDuong = 6;
                TocDoDC = 6;
            }
            else
            {
               if (Diem > 50)
               {
                    TDDuong = 8;
                    TocDoDC = 7;
               }
                
            }
        }
        private void XuatHien4()
        {
            int num = rd.Next(1, 4);
            switch (num)
            {
                case 1:
                    No2.Image = Properties.Resources.rocket;
                    No2.Left = 224;
                    No2.Top = (rd.Next(200, 230) * -1);
                    break;

                case 2:
                    No2.Image = Properties.Resources.rocket;
                    No2.Left = 300;
                    No2.Top = (rd.Next(200, 230) * -1);
                    break;
                default:
                    break;
            }
            if (No2.Bounds.IntersectsWith(Food2.Bounds))
            {
                No2.Top -= 60;
            }
        }
        private void XuatHien3()
        {
            int num = rd.Next(1, 4);
            switch (num)
            {
                case 1:
                    No1.Image = Properties.Resources.rocket;
                    No1.Left = 55;
                    No1.Top = (rd.Next(400, 420) * -1);

                    break;

                case 2:
                    No1.Image = Properties.Resources.rocket;
                    No1.Left = 130;
                    No1.Top = (rd.Next(400, 420) * -1);
                    break;
                default:
                    break;
            }
            if (No1.Bounds.IntersectsWith(Food1.Bounds))
            {
                No1.Top -= 60;
            }

        }
        private void XuatHien2()
        {
            int num = rd.Next(1, 4);
            switch (num)
            {
                case 1:
                    Food2.Image = Properties.Resources.smiling;
                    Food2.Left = 224;
                    Food2.Top = (rd.Next(400, 420) * -1);
                    break;

                case 2:
                    Food2.Image = Properties.Resources.smiling;
                    Food2.Left = 300;
                    Food2.Top = (rd.Next(400, 420) * -1);
                    break;
                default:
                    break;
            }
            if (Food2.Bounds.IntersectsWith(No2.Bounds))
            {
                Food2.Top -= 60;
            }

        }
        private void XuatHien1()
        {
            int num = rd.Next(1, 4);
            switch (num)
            {
                case 1:
                    Food1.Image = Properties.Resources.smiling;
                    Food1.Left = 55;
                    Food1.Top = (rd.Next(200, 230) * -1);
                    break;

                case 2:
                    Food1.Image = Properties.Resources.smiling;
                    Food1.Left = 130;
                    Food1.Top = (rd.Next(200, 230) * -1);
                    break;
                default:
                    break;

            }
            if (Food1.Bounds.IntersectsWith(No1.Bounds))
            {
                Food1.Top -= 60;
            }

        }
        private void _2Cars_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.A && pcbPlayer1.Left == 130)
            {
                Trai1 = true;
            }
     
            if (e.KeyCode == Keys.D && pcbPlayer1.Left == 55)
            {
                Phai1 = true;
            }
            if (e.KeyCode == Keys.Left && pcbPlayer2.Left == 295)
            {
                Trai2 = true;
            }

            if (e.KeyCode == Keys.Right && pcbPlayer2.Left == 224)
            {
                Phai2 = true;
            }
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            RacingGame r = new RacingGame();
            DialogResult d = MessageBox.Show("Bạn thực sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                this.Close();
                playgame.Stop();
                score.Stop();
                r.Show();
            }
        }

        private void _2Cars_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                Trai1 = false;
            }
            if (e.KeyCode == Keys.D)
            {
                Phai1 = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                Trai2 = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                Phai2 = false;
            }
        }

        private void GameOver()
        {
            score.Stop();
            btnStart.Enabled = true;
            lbIntro.Enabled = true;

            pcbChienThang.Visible = true;
            if (Diem >= 10)
            {
                pcbChienThang.Image = Properties.Resources.YoungDriver;
            }
            if (Diem >= 20)
            {
                pcbChienThang.Image = Properties.Resources.GhostDriver;
            }
            if (Diem >= 30)
            {
                pcbChienThang.Image = Properties.Resources.KingOfRoad;
            }

        }

        private void lbExit_Click_1(object sender, EventArgs e)
        {
            RacingGame r = new RacingGame();
            DialogResult d = MessageBox.Show("Bạn thực sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                this.Close();
                score.Stop();
                playgame.Stop();
                r.Show();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Huongdan2 hd2 = new Huongdan2();
            hd2.ShowDialog();
        }
    }
}
