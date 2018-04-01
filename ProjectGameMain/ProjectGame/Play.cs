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
        int TDXe = 5;
        int TDDuong = 5;
        bool Trai;
        bool Phai;
        bool Len;
        bool Xuong;
        int TocDoDC = 5;
        int Diem = 0;
        bool Tang;
        int TangToc = 20;
        int VanToc = 0;
        
        Random rd = new Random();
        public Play()
        {
            InitializeComponent();
            Reset();
            pgbTocDo.Maximum = 10;
        }

        void Reset()
        {
          
            p.PlayLooping();
             
            btnStart.Enabled = false; // vô hiệu nút start khi xe chạy
            VanToc = 0;
            TocDoDC = 5; // lấy giá trị mặc định của TocDo=5.
            TDDuong = 5; // lấy giá trị mặc định của TDDuong=5.
            Diem = 0; // đặt Điểm lại 0

            pcbPlayer.Left = 249; // đặt lại vị trí đầu
            pcbPlayer.Top = 494; // đặt lại vị trí đầu

            Trai = false; // đăt lại Trai là false
            Phai = false; // đặt lại Phai là false
            Len = false;
            Xuong = false;
            Tang = false;

            //đặt lại đường về vị trí đẩu
            pcbDuong2.Left = -3;
            pcbDuong2.Top = -142;
            pcbDuong1.Left = -3;
            pcbDuong1.Top = -808;

            // start timer1
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Diem++; // tăng điểm khi di chuyển
            VanToc+=1;
            if (VanToc >= 330)
            {
                VanToc = 329;
            }
            if(Tang)
            {
                VanToc = 720;
            }
            lbDiem.Text = "" + Diem; // hiển thị điểm
            lbTocDo.Text = "" + VanToc;

            //Di chuyển đường
            pcbDuong1.Top += TDDuong;
            pcbDuong2.Top += TDDuong;

            // khi đường đi qua -640 thì thiết lập lại giá trị măc định 
            // ==> ảnh động liên tục
            if (pcbDuong1.Top > 640)
            {
                pcbDuong1.Top = -640;
            }
            if (pcbDuong2.Top > 640)
            {
                pcbDuong2.Top = -640;
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
            if(Len)
            {
                pcbPlayer.Top += TDXe;
            }
            if(Xuong)
            {
                pcbPlayer.Top -= TDXe;
            }
            if(Tang)
            {
                pcbPlayer.Top -= TangToc;
                pgbTocDo.Value -= 1;
            }
            
            // kết thúc di chuyển xe
            if(pcbPlayer.Top<0)
            {
                Xuong = false;
                pcbPlayer.Top = 1;
            }
            else
            {
                if(pcbPlayer.Top +pcbPlayer.Height>plNen.Height)
                {
                    Len = false;
                }
            }
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
            
            if(pgbTocDo.Value==0)
            {
                Tang = false;
            }
           
            // kết thúc kiểm tra



        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Reset();
        }

       
       

        private void Play_Load(object sender, EventArgs e)
        {
           
        }

        private void Play_KeyDown(object sender, KeyEventArgs e)
        {
            // xe qua trái thì Trai là true
            if (e.KeyCode == Keys.Left && pcbPlayer.Left > 0)
            {
                Trai = true;
               TocDo.Start();
            }
            // xe qua phải thì Phai là true
            if (e.KeyCode == Keys.Right && pcbPlayer.Left + pcbPlayer.Width < plNen.Width)
            {
                Phai = true;
                TocDo.Start();
            }
            if(e.KeyCode==Keys.Down && pcbPlayer.Top+pcbPlayer.Height<plNen.Height)
            {
                Len = true;
                TocDo.Start();
            }
            if(e.KeyCode==Keys.Up && pcbPlayer.Top>0)
            {
                Xuong = true;
                TocDo.Start();
            }
           if(e.KeyCode==Keys.S && pgbTocDo.Value==10)
            {
                Tang = true;
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
            if(e.KeyCode==Keys.Up)
            {
                Xuong = false;
            }
            if(e.KeyCode==Keys.Down)
            {
                Len = false;
            }
        }

        private void TocDo_Tick(object sender, EventArgs e)
        {
            this.pgbTocDo.Increment(1);
            
        }

       
    }
    }

