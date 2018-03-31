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

namespace ProjectGame
{
    public partial class Play : Form
    {
        SoundPlayer p = new SoundPlayer(@"playgame.wav");
        SoundPlayer PlaySound = new SoundPlayer(@"hit.wav");

        // biến toàn cục
        int TDXe = 9;
        int TDDuong = 5;
        bool Trai;
        bool Phai;
        int TocDoDC = 5;
        int Diem = 0;
        Random rd = new Random();
        public Play()
        {
            InitializeComponent();
            Reset();
           
        }

        void Reset()
        {
            p.PlayLooping();
         
            btnStart.Enabled = false; // vô hiệu nút start khi xe chạy
          
            TocDoDC = 5; // lấy giá trị mặc định của TocDo=5.
            TDDuong = 5; // lấy giá trị mặc định của TDDuong=5.
            Diem = 0; // đặt Điểm lại 0

            pcbPlayer.Left = 249; // đặt lại vị trí đầu
            pcbPlayer.Top = 494; // đặt lại vị trí đầu

            Trai = false; // đăt lại Trai là false
            Phai = false; // đặt lại Phai là false


            //đặt lại đường về vị trí đẩu
            pcbDuong2.Left = -3;
            pcbDuong2.Top = -142;
            pcbDuong1.Left = -3;
            pcbDuong1.Top = -754;

            // start timer1
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Diem++; // tăng điểm khi di chuyển
            lbDiem.Text = "" + Diem; // hiển thị điểm

            //Di chuyển đường
            pcbDuong1.Top += TDDuong;
            pcbDuong2.Top += TDDuong;

            // khi đường đi qua -630 thì thiết lập lại giá trị măc định 
            // ==> ảnh động liên tục
            if (pcbDuong1.Top > 635)
            {
                pcbDuong1.Top = -635;
            }
            if (pcbDuong2.Top > 635)
            {
                pcbDuong2.Top = -635;
            }
            // kết thúc chuyển động

            if (Trai)
            {
                pcbPlayer.Left -= TDXe; // di chuyển qua trái nếu Trai là true
            }
            if (Phai)
            {
                pcbPlayer.Left += TDXe; //di chuyển phải nếu Phai là true
            }
            // kết thúc di chuyển xe

            if (pcbPlayer.Left < 1)
            {
                Trai = false; // dửng xe đang chạy 
            }
            else
            {
                if (pcbPlayer.Left + pcbPlayer.Width > 560)
                {
                    Phai = false;
                }
            }
            // kết thúc kiểm tra

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Play_KeyDown(object sender, KeyEventArgs e)
        {
            // xe qua trái thì Trai là true
            if (e.KeyCode == Keys.Left && pcbPlayer.Left > 0)
            {
                Trai = true;
            }
            // xe qua phải thì Phai là true
            if (e.KeyCode == Keys.Right && pcbPlayer.Left + pcbPlayer.Width < plNen.Width)
            {
                Phai = true;
            }
        }

        private void Play_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Trai = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                Phai = false;
            }
        }
    }
}
