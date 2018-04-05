using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Game
{
    public partial class _2Cars : Form
    {
        int TDXe = 6;
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
        }
        private void Reset()
        {
   
            TocDoDC = 5; // lấy giá trị mặc định của TocDo=5.
            TDDuong = 5; // lấy giá trị mặc định của TDDuong=5.
            Diem = 0; // đặt Điểm lại 0
            
            pcbPlayer1.Left = 130; // đặt lại vị trí đầu
            pcbPlayer1.Top = 311; // đặt lại vị trí đầu

            pcbPlayer2.Left = 295; // đặt lại vị trí đầu
            pcbPlayer2.Top = 311;

            Trai1 = false; 
            Phai1 = false; 
            Trai2 = false; 
            Phai2 = false;

            // di chuyển vật phẩm về lại vị trí cũ 
            Food1.Left = 130;
            Food1.Top = 98;
            Food2.Left = 224;
            Food2.Top = 62;
            No1.Left = 55;
            No1.Top = 62;
            No2.Left = 300;
            No2.Top = 101;


            //đặt lại đường về vị trí đẩu
            pcbDuong2.Left = -3;
            pcbDuong2.Top = -222;
            pcbDuong1.Left = -2;
            pcbDuong1.Top = -638;

            // start timer1
            score.Start();
        }
        private void score_Tick(object sender, EventArgs e)
        {
           
        }

        private void score_Tick_1(object sender, EventArgs e)
        {
            
            Diem++; // tăng điểm khi di chuyển
            lbDiem.Text = "" + Diem; // hiển thị điểm

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
                pcbPlayer1.Left =55; // di chuyển qua trái nếu Trai là true
                //Trai1 = false;
            }
            if (Phai1)
            {
                pcbPlayer1.Left = 130; //di chuyển phải nếu Phai là true
                //Phai1 = false;
            }
            if(Trai2)
            {
                pcbPlayer2.Left = 227; // di chuyển qua trái nếu Trai là true
                //Trai2 = false;
            }
            if (Phai2)
            {
                pcbPlayer2.Left = 295; //di chuyển phải nếu Phai là true
                //Phai2 = false;
            }

            //di chuyển vật phẩm xuống
            Food1.Top += TocDoDC;
            Food2.Top += TocDoDC;
            No2.Top += TocDoDC;
            No1.Top += TocDoDC;

            // cho vật phẩm xuất hiện ngẫu nhiên
            if (Food1.Top > plNen.Height)
            {
                XuatHien1();
            }
            if (Food2.Top > plNen.Height)
            {
                XuatHien2();
            }
            if (pcbPlayer1.Bounds.IntersectsWith(No1.Bounds) || pcbPlayer2.Bounds.IntersectsWith(No2.Bounds) || Food1.Bottom > plNen.Height || Food2.Bottom > plNen.Height)
            {
                GameOver(); // kết thúc game khi đụng phải xe 1 or xe 2

            }
            if(pcbPlayer1.Bounds.IntersectsWith(Food1.Bounds))
            {
                XuatHien1();
            }
             if(pcbPlayer2.Bounds.IntersectsWith(Food2.Bounds))
            {
                XuatHien2();
            }
        }
        private void XuatHien2()
        {
            int num = rd.Next(1, 4);
            switch (num)
            {
                case 1:
                    Food2.Image = Properties.Resources.trontim;
                    Food2.Left = 224;
                    Food2.Top = rd.Next(150, 200) * -1;
                    break;

                case 2:
                    Food2.Image = Properties.Resources.trontim;
                    Food2.Left = 300;
                    Food2.Top = rd.Next(150, 200) * -1;
                    break;
                default:
                    break;
            }
        }
        private void  XuatHien1()
        {
            int num = rd.Next(1, 4);
            switch (num)
            {
                case 1:
                    Food1.Image = Properties.Resources.trontim;
                    Food1.Left = 55;
                    Food1.Top = rd.Next(150, 200) * -1;
                    break;

                case 2:
                    Food1.Image = Properties.Resources.trontim;
                    Food1.Left = 130;
                    Food1.Top = rd.Next(150, 200) * -1;
                    break;
                default:
                    break;
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
          
            if (e.KeyCode == Keys.Right && pcbPlayer2.Left == 227)
            {
                Phai2 = true;
            }
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
