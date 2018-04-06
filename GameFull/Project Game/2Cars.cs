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

namespace Project_Game
{
    public partial class _2Cars : Form
    {
        SoundPlayer Shut = new SoundPlayer(@"ShutDown.wav");
        SoundPlayer playgame = new SoundPlayer(@"playgame.wav");
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
            Reset();
            playgame.PlayLooping();
        }
        private void Reset()
        {
            label4.Enabled = false;
            btnStart.Enabled = false;
            playgame.PlayLooping();
            this.pcbChienThang.Visible = false;
            TocDoDC = 5; // lấy giá trị mặc định của TocDo=5.
            TDDuong = 5; // lấy giá trị mặc định của TDDuong=5.
            Diem = 0; // đặt Điểm lại 0
            
            pcbPlayer1.Left = 130; // đặt lại vị trí đầu
            pcbPlayer1.Top = 308; // đặt lại vị trí đầu

            pcbPlayer2.Left = 224; // đặt lại vị trí đầu
            pcbPlayer2.Top = 308;

            Trai1 = false; 
            Phai1 = false; 
            Trai2 = false; 
            Phai2 = false;

            // di chuyển vật phẩm về lại vị trí cũ 
            Food1.Left = 130;
            Food1.Top = 136;
            Food2.Left = 224;
            Food2.Top = 3;
            No1.Left = 62;
            No1.Top = 3;
            No2.Left = 300;
            No2.Top = 136;


            //đặt lại đường về vị trí đẩu
            pcbDuong2.Left = -3;
            pcbDuong2.Top = -222;
            pcbDuong1.Left = -2;
            pcbDuong1.Top = -638;

            // start timer1
            score.Start();
        }
        private void score_Tick_1(object sender, EventArgs e)
        {
            if (pcbPlayer1.Bounds.IntersectsWith(Food1.Bounds) || pcbPlayer2.Bounds.IntersectsWith(Food2.Bounds))
            {
                Diem++; // tăng điểm khi di chuyển
                lbDiem.Text = "" + Diem; // hiển thị điểm
            }

            //Di chuyển đường
            pcbDuong1.Top += TDDuong;
            pcbDuong2.Top += TDDuong;

            // khi đường đi qua -630 thì thiết lập lại giá trị măc định 
            // ==> ảnh động liên tục
            if (pcbDuong1.Top > 630)
            {
                pcbDuong1.Top = -630;
            }
            if (pcbDuong2.Top > 630)
            {
                pcbDuong2.Top = -630;
            }
            // kết thúc chuyển động

            if (Trai1)
            {
                pcbPlayer1.Left =55; 
                
            }
            if (Phai1)
            {
                pcbPlayer1.Left = 130; 
               
            }
            if(Trai2)
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

            if (pcbPlayer1.Bounds.IntersectsWith(No1.Bounds) || pcbPlayer2.Bounds.IntersectsWith(No2.Bounds) || Food1.Bottom > plNen.Height || Food2.Bottom > plNen.Height)
            {
                Shut.Play();
                GameOver();
                
            }
            if(pcbPlayer1.Bounds.IntersectsWith(Food1.Bounds) )
            {
                XuatHien1();
            }
            if ( No1.Top > plNen.Height)
            {
                XuatHien3();

            }
            if (pcbPlayer2.Bounds.IntersectsWith(Food2.Bounds))
            {
                XuatHien2();

            }
            if ( No2.Top > plNen.Height)
            {
                XuatHien4();
            }


            if (Diem>10)
            {
                TDDuong = 8;
            }
            else
            {
                if (Diem > 20)
                {
                    TDDuong = 10;
                }
                else
                {
                    if(Diem>30)
                    {
                        TDDuong = 15;
                    }
                }
            }
            lbDiem.Text = "" + Diem;
        }
        private void XuatHien4()
        {
            int num = rd.Next(1, 4);
            switch (num)
            {
                case 1:
                    No2.Image = Properties.Resources.rocket;
                    No2.Left = 224;
                    No2.Top = (rd.Next(200,230) * -1);
                    break;

                case 2:
                    No2.Image = Properties.Resources.rocket;
                    No2.Left = 300;
                    No2.Top = (rd.Next(200,230) * -1);
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
                    No1.Top = (rd.Next(400,420) * -1);
                   
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
                    Food2.Top = (rd.Next(400, 420) *-1);
                    break;
                default:
                    break;
            }
            if (Food2.Bounds.IntersectsWith(No2.Bounds))
            {
                Food2.Top -= 60 ;
            }

        }
        private void  XuatHien1()
        {
            int num = rd.Next(1, 4);
            switch (num)
            {
                case 1:
                    Food1.Image = Properties.Resources.smiling;
                    Food1.Left = 55;
                    Food1.Top =( rd.Next(200,230) * -1);
                    break;

                case 2:
                    Food1.Image = Properties.Resources.smiling;
                    Food1.Left = 130;
                    Food1.Top = (rd.Next(200,230) * -1);
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
            // xe qua trái thì Trai là true
            if (e.KeyCode == Keys.A && pcbPlayer1.Left == 130)
            {
                Trai1 = true;
            }
            // xe qua phải thì Phai là true
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
            if(e.KeyCode == Keys.Left)
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
            label4.Enabled = true;

            pcbChienThang.Visible = true;
            if (Diem >=10)
            {
                pcbChienThang.Image = Properties.Resources.YoungDriver;
            }
            if (Diem  >= 20)
            {
                pcbChienThang.Image = Properties.Resources.GhostDriver;
            }
            if (Diem >=30)
            {
                pcbChienThang.Image = Properties.Resources.KingOfRoad;
            }
           
        }

        

        private void _2Cars_Load(object sender, EventArgs e)
        {

        }

        

        private void lbExit_Click_1(object sender, EventArgs e)
        {
            RacingGame r = new RacingGame();
            DialogResult d = MessageBox.Show("Bạn thực sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                this.Close();
                score.Stop();
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
            hd2.Show();
        }
    }
}
