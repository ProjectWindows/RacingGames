using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGame
{
    public partial class TwoCar : Form
    {
        int TDXe = 5;
        int TDDuong = 5;
        bool Trai;
        bool Phai;
        int TocDoDC = 5;
        int Diem = 0;

        Random rd = new Random();
        public TwoCar()
        {
            InitializeComponent();
            Reset();
        }

        private void TwoCar_Load(object sender, EventArgs e)
        {
            
        }
        void Reset()
        {

            
            //pcbEndGame.Visible = false; // ẩn bảng chiến thắng 
            btnStart.Enabled = false; // vô hiệu nút start khi xe chạy
            //pcbNo.Visible = false; // ẩn Hình Nổ
            TocDoDC = 5; // lấy giá trị mặc định của TocDo=5.
            TDDuong = 5; // lấy giá trị mặc định của TDDuong=5.
            Diem = 0; // đặt Điểm lại 0


            ptbPlayer1.Left = 102; // đặt lại vị trí đầu
            ptbPlayer1.Top = 300; // đặt lại vị trí đầu

            Trai = false; // đăt lại Trai là false
            Phai = false; // đặt lại Phai là false

            //đặt vật phẩm lại vị trí ban đầu
            Food1.Left = 24;
            Food1.Top = 53;
            Food2.Left = 192;
            Food2.Top = 53;
            No1.Left = 172;
            No1.Top = 53;
            No2.Left = 276;
            No2.Top = 53;

            //đặt lại đường về vị trí đẩu
            road1.Left = -2;
            road1.Top = -142;
            road2.Left = -2;
            road2.Top = -550;

            // start timer1
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Diem++; // tăng điểm khi di chuyển
            lbDiem.Text = "" + Diem; // hiển thị điểm

            //Di chuyển đường
            road1.Top += TDDuong;
            road2.Top += TDDuong;

            // khi đường đi qua -630 thì thiết lập lại giá trị măc định 
            // ==> ảnh động liên tục
            if (road1.Top > 640)
            {
                road1.Top = -640;
            }
            if (road2.Top > 640)
            {
                road2.Top = -640;
            }
            // kết thúc chuyển động

            if (Trai)
            {
                ptbPlayer1.Left = 24; // di chuyển qua trái nếu Trai là true
                Trai = false;
            }
            if (Phai)
            {
                ptbPlayer1.Left = 102; //di chuyển phải nếu Phai là true
                Phai = false;
            }
            // kết thúc di chuyển xe


            //if (ptbPlayer.Left < 1)
            //{
            //    Trai = false; // dửng xe đang chạy 
            //}
            //else
            //{
            //    if (pcbPlayer.Left + pcbPlayer.Width > 380)
            //    {
            //        Phai = false;
            //    }
            //}
            // kết thúc kiểm tra

            // di chuyển xe xuống
            Food1.Top += TocDoDC;
            Food2.Top += TocDoDC;
            No1.Top += TocDoDC;
            No2.Top += TocDoDC;

            // cho xe xuất hiện ngẫu nhiên
            if (Food1.Top > plGame.Height)
            {

                int num = rd.Next(1, 2); //random food1
                if (num == 1)
                {
                    Food1.Left = 24;
                }
                else
                {
                    Food1.Left = 102;
                }
                //
        //        pcbxe1.Top = rd.Next(100, 200) * -1; // radom số bên phải
        //    }
        //    if (pcbxe2.Top > plNen.Height)
        //    {
        //        ChangeXe2();
        //        pcbxe2.Left = rd.Next(185, 327);
        //        pcbxe2.Top = rd.Next(100, 200) * -1;
        //    }

        //    // kết thúc cho xe xuất hiện ngẫu nhiên
        //    // nếu palyer đụng xe 1 or xe 2
        //    if (pcbPlayer.Bounds.IntersectsWith(pcbxe1.Bounds) || pcbPlayer.Bounds.IntersectsWith(pcbxe2.Bounds))
        //    {
        //        GameOver(); // kết thúc game khi đụng phải xe 1 or xe 2

        //    }
        //    // tăng tốc dường băng
        //    //nếu điểm trên 100 và bé hơn 500
        //    if (Diem > 100 && Diem < 500)
        //    {
        //        TocDoDC = 6;
        //        TDDuong = 7;
        //    }
        //    // nếu điểm trên 500 và bé hơn 1000
        //    else
        //    {
        //        if (Diem > 500 && Diem < 1000)
        //        {
        //            TocDoDC = 7;
        //            TDDuong = 8;
        //        }
        //        // nếu điểm bé hơn 1200
        //        else
        //        {
        //            if (Diem > 1200)
        //            {
        //                TocDoDC = 9;
        //                TDDuong = 10;
        //            }
        //        }
        //    }
        }
    }
    }
}
