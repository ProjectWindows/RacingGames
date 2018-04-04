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
    public partial class pcbXe3 : Form
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
        int Impossible = 0;
        Random rd = new Random();


        public pcbXe3()
        {
            InitializeComponent();
            Reset();
            pgbTocDo.Maximum = 10;
            //LoadImageName();
        }

        void Reset()
        {

            p.PlayLooping();
            pcbPower.Visible = false; //ẩn hình power
            pcbEndGame.Visible = false; // ẩn bảng chiến thắng 
            btnStart.Enabled = false; // vô hiệu nút start khi xe chạy
            pcbNo.Visible = false; // ẩn Hình Nổ
            VanToc = 0;
            TocDoDC = 5; // lấy giá trị mặc định của TocDo=5.
            TDDuong = 5; // lấy giá trị mặc định của TDDuong=5.
            Diem = 0; // đặt Điểm lại 0
            //Impossible = 0;

            pcbPlayer.Left = 249; // đặt lại vị trí đầu
            pcbPlayer.Top = 494; // đặt lại vị trí đầu

            Trai = false; // đăt lại Trai là false
            Phai = false; // đặt lại Phai là false
            Len = false;
            Xuong = false;
            Tang = false;

            //đặt bot lại vị trí ban đầu
            pcbXe1.Left = 79;
            pcbXe1.Top = 33;
            pcbXeDien.Left = 271;
            pcbXeDien.Top = 3;
            pcbXe2.Left = 390;
            pcbXe2.Top = 60;

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
            VanToc += 1;
            if (VanToc >= 330)
            {
                VanToc = 329;
            }
            if (Tang)
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
            if (Len)
            {
                pcbPlayer.Top += TDXe;
            }
            if (Xuong)
            {
                pcbPlayer.Top -= TDXe;
            }
            if (Tang)
            {
                pcbPlayer.Top -= TangToc;
                pgbTocDo.Value -= 1;
            }

            // kết thúc di chuyển xe
            if (pcbPlayer.Top < 0)
            {
                Xuong = false;
                pcbPlayer.Top = 1;
            }
            else
            {
                if (pcbPlayer.Top + pcbPlayer.Height > plNen.Height)
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

            if (pgbTocDo.Value == 0)
            {
                Tang = false;
            }

            // kết thúc kiểm tra

            // di chuyển xe xuống
            pcbXe1.Top += TocDoDC;
            pcbXe2.Top += TocDoDC;
            pcbXeDien.Top += TocDoDC;


            // cho xe xuất hiện ngẫu nhiên
            if (pcbXe1.Top > plNen.Height)
            {
                ChangeXe1(); // chọn xe ngẫu nhiên làm vật cản
                pcbXe1.Left = rd.Next(3, 249); //random số bên trái
                pcbXe1.Top = rd.Next(100, 200) * -1; // radom số bên phải
            }
            if (pcbXe2.Top > plNen.Height)
            {
                ChangeXe2();
                pcbXe2.Left = rd.Next(265, 504);
                pcbXe2.Top = rd.Next(100, 200) * -1;
            }
            //xuat hien ngau nhien xe 3
            if (pcbXeDien.Top > plNen.Height)
            {
                //ChangeXeDien();
                pcbXeDien.Left = rd.Next(3, 504);
                pcbXeDien.Top = rd.Next(220, 240) * -1;
            }
            // kết thúc cho xe xuất hiện ngẫu nhiên
            // nếu palyer đụng xe 1 or xe 2
            if (pcbPlayer.Bounds.IntersectsWith(pcbXe1.Bounds) || pcbPlayer.Bounds.IntersectsWith(pcbXe2.Bounds) || pcbPlayer.Bounds.IntersectsWith(pcbXeDien.Bounds))
            {
                //GameOver(); // kết thúc game khi đụng phải xe 1 or xe 2

            }
            // tăng tốc dường băng
            //nếu điểm trên 100 và bé hơn 500
            if (Diem > 100 && Diem < 500)
            {
                TocDoDC = 9;
                TDDuong = 10;
            }
            // nếu điểm trên 500 và bé hơn 1000
            else
            {
                if (Diem > 500 && Diem < 1000)
                {
                    TocDoDC = 12;
                    TDDuong = 13;
                }
                // nếu điểm bé hơn 1200
                else
                {
                    if (Diem > 1200)
                    {
                        TocDoDC = 15;
                        TDDuong = 16;
                    }
                }
            }

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
            if (e.KeyCode == Keys.Down && pcbPlayer.Top + pcbPlayer.Height < plNen.Height)
            {
                Len = true;
                TocDo.Start();
            }
            if (e.KeyCode == Keys.Up && pcbPlayer.Top > 0)
            {
                Xuong = true;
                TocDo.Start();
            }
            if (e.KeyCode == Keys.S && pgbTocDo.Value == 10)
            {
                Tang = true;
                pcbPower.Visible = true;
                pcbPlayer.Controls.Add(pcbPower);
                pcbPower.Location = new Point(-8, 7);
                pcbPower.BackColor = Color.Transparent;
                pcbPower.BringToFront();
            }
            if (e.KeyCode == Keys.F1)
            {
                pcbPlayer.Image = Properties.Resources.carOrange;
            }
            if (e.KeyCode == Keys.F2)
            {
                pcbPlayer.Image = Properties.Resources.carGreen;
            }
            if (e.KeyCode == Keys.F3)
            {
                pcbPlayer.Image = Properties.Resources.carGrey;
            }
            if (e.KeyCode == Keys.F4)
            {
                pcbPlayer.Image = Properties.Resources.CarRed;
            }
            if (e.KeyCode == Keys.F5)
            {
                pcbPlayer.Image = Properties.Resources.carYellow;
            }
            if (e.KeyCode == Keys.F6)
            {
                pcbPlayer.Image = Properties.Resources.carPink;
            }
            if (e.KeyCode == Keys.F7)
            {
                pcbPlayer.Image = Properties.Resources.TruckBlue;
            }
            if (e.KeyCode == Keys.F8)
            {
                pcbPlayer.Image = Properties.Resources.TruckWhite;
            }
            if (e.KeyCode == Keys.F9)
            {
                pcbPlayer.Image = Properties.Resources.Police;
            }
            if (e.KeyCode == Keys.F10)
            {
                pcbPlayer.Image = Properties.Resources.CarBlue;
            }
            if (e.KeyCode == Keys.F11)
            {
                pcbPlayer.Image = Properties.Resources.CarWhite;
            }
            if (e.KeyCode == Keys.F12)
            {
                pcbPlayer.Image = Properties.Resources.CarBlack;
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
            if (e.KeyCode == Keys.Up)
            {
                Xuong = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                Len = false;
            }
        }

        private void TocDo_Tick(object sender, EventArgs e)
        {
            this.pgbTocDo.Increment(1);

        }

        private void pgbTocDo_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void ChangeXe2()
        {
            int num = rd.Next(1, 8); // thiết lập một biến vị trí có số được tạo ra từ 1 tới 8
            // switch sẽ kiểm tra số được tạo ra  và sẽ hiện thị hình theo yêu cầu
            switch (num)
            {
                //  nếu số tạo ra là 1 thì hiển thị GreenCar
                case 1:
                    pcbXe2.Image = Properties.Resources.carGreen; break;
                //   nếu số tạo ra là 2 thì hiển thị GreyCar
                case 2:
                    pcbXe2.Image = Properties.Resources.carGrey; break;
                // nếu số tạo ra là 3 thì hiển thị oragneCar
                case 3:
                    pcbXe2.Image = Properties.Resources.carOrange; break;
                // nếu số tao ra là 4 thì hiễn thị PinkCar
                case 4:
                    pcbXe2.Image = Properties.Resources.carPink; break;
                // nếu số tạo ra là 5 thì hiển thị Red Car
                case 5:
                    pcbXe2.Image = Properties.Resources.CarRed; break;
                // nếu số tạo ra là 6 thì hiển thị blue truck
                case 6:
                    pcbXe2.Image = Properties.Resources.TruckBlue; break;
                // nếu số tạo ra là 7 thì hiển thị white truck
                case 7:
                    pcbXe2.Image = Properties.Resources.TruckWhite; break;
                // nếu số tạo ra là 8 thì hiển thị Ambulance
                case 8:
                    pcbXe2.Image = Properties.Resources.ambulance; break;
                default: break;

            }
        }

        private void ChangeXe1()
        {
            int num = rd.Next(1, 8); // thiết lập một biến vị trí có số được tạo ra từ 1 tới 8
            // switch sẽ kiểm tra số được tạo ra  và sẽ hiện thị hình theo yêu cầu
            switch (num)
            {
                //  nếu số tạo ra là 1 thì hiển thị GreenCar
                case 1:
                    pcbXe1.Image = Properties.Resources.carGreen; break;
                //   nếu số tạo ra là 2 thì hiển thị GreyCar
                case 2:
                    pcbXe1.Image = Properties.Resources.carGrey; break;
                // nếu số tạo ra là 3 thì hiển thị oragneCar
                case 3:
                    pcbXe1.Image = Properties.Resources.carOrange; break;
                // nếu số tao ra là 4 thì hiễn thị PinkCar
                case 4:
                    pcbXe1.Image = Properties.Resources.carPink; break;
                // nếu số tạo ra là 5 thì hiển thị Red Car
                case 5:
                    pcbXe1.Image = Properties.Resources.CarRed; break;
                // nếu số tạo ra là 6 thì hiển thị blue truck
                case 6:
                    pcbXe1.Image = Properties.Resources.TruckBlue; break;
                // nếu số tạo ra là 7 thì hiển thị white truck
                case 7:
                    pcbXe1.Image = Properties.Resources.TruckWhite; break;
                // nếu số tạo ra là 8 thì hiển thị Ambulance
                case 8:
                    pcbXe1.Image = Properties.Resources.ambulance; break;
                default: break;
            }
        }
        private void ChangeXeDien()
        {
            int num = rd.Next(1, 8); // thiết lập một biến vị trí có số được tạo ra từ 1 tới 8
            // switch sẽ kiểm tra số được tạo ra  và sẽ hiện thị hình theo yêu cầu
            switch (num)
            {
                //  nếu số tạo ra là 1 thì hiển thị GreenCar
                case 1:
                    pcbXeDien.Image = Properties.Resources.carGreen; break;
                //   nếu số tạo ra là 2 thì hiển thị GreyCar
                case 2:
                    pcbXeDien.Image = Properties.Resources.carGrey; break;
                // nếu số tạo ra là 3 thì hiển thị oragneCar
                case 3:
                    pcbXeDien.Image = Properties.Resources.carOrange; break;
                // nếu số tao ra là 4 thì hiễn thị PinkCar
                case 4:
                    pcbXeDien.Image = Properties.Resources.carPink; break;
                // nếu số tạo ra là 5 thì hiển thị Red Car
                case 5:
                    pcbXeDien.Image = Properties.Resources.CarRed; break;
                // nếu số tạo ra là 6 thì hiển thị blue truck
                case 6:
                    pcbXeDien.Image = Properties.Resources.TruckBlue; break;
                // nếu số tạo ra là 7 thì hiển thị white truck
                case 7:
                    pcbXeDien.Image = Properties.Resources.TruckWhite; break;
                // nếu số tạo ra là 8 thì hiển thị Ambulance
                case 8:
                    pcbXeDien.Image = Properties.Resources.ambulance; break;
                default: break;
            }
        }
        public void GameOver()
        {
            pcbEndGame.Visible = true; // hiển thị  bảng chiến thắng
            timer1.Stop(); // dừng timer
            btnStart.Enabled = true; // bật button lúc sử dụng

            // hiển thị Nổ ở phía trên xe Player
            pcbNo.Visible = true; // hiển thị Hình Ảnh Nổ
            pcbPlayer.Controls.Add(pcbNo); // thêm HA Nổ trên xe player
            pcbNo.Location = new Point(-8, 5);
            pcbNo.BackColor = Color.Transparent; // đổi màu 
            pcbNo.BringToFront(); // đem ra trước xe player

            // nếu score < 1000 --> Young Driver
            if (Diem < 1000)
            {
                pcbEndGame.Image = Properties.Resources.YoungDriver;
            }
            // nếu score > 1000 --> Ghost Driver
            if (Diem > 1000)
            {
                pcbEndGame.Image = Properties.Resources.GhostDriver;
            }
            // nếu score > 2000 --> King Of Road
            if (Diem > 2000)
            {
                pcbEndGame.Image = Properties.Resources.KingOfRoad;
            }

            //PlaySound();
            PlaySound.Play();
        }

        private void chay_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
    }

