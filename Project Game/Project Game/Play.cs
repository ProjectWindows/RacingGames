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
    public partial class Play : Form
    {
        SoundPlayer p = new SoundPlayer(@"playgame.wav");
        SoundPlayer PlaySound = new SoundPlayer(@"hit.wav");
        RacingGame r = new RacingGame();
     //   Play l = new Play();

        // biến toàn cục
        int TDXe = 6;
        int TDDuong = 5;
        bool Trai;
        bool Phai;
        int TocDoDC = 5;
        int Diem = 0;
        Random rd = new Random();

       /* // Chọn xe để chơi
        Bitmap im1 = Properties.Resources.ambulance;
        Bitmap im2 = Properties.Resources.carGreen;
        Bitmap im3 = Properties.Resources.carGrey;
        Bitmap im4 = Properties.Resources.carOrange;
        Bitmap im5 = Properties.Resources.carPink;
        Bitmap im6 = Properties.Resources.CarRed;
        Bitmap im7 = Properties.Resources.carYellow;*/

        public Play()
        {
            InitializeComponent();
            Reset();
           
        }
        private void Reset()
        {
            p.PlayLooping();
            pcbChienThang.Visible = false; // ẩn bảng chiến thắng
            btnStart.Enabled = false; // vô hiệu nút start khi xe chạy
            pcbNo.Visible = false; // ẩn Hình Nổ
            TocDoDC = 5; // lấy giá trị mặc định của TocDo=5.
            TDDuong = 5; // lấy giá trị mặc định của TDDuong=5.
            Diem = 0; // đặt Điểm lại 0

            pcbPlayer.Left = 161; // đặt lại vị trí đầu
            pcbPlayer.Top = 286; // đặt lại vị trí đầu

            Trai = false; // đăt lại Trai là false
            Phai = false; // đặt lại Phai là false

            // di chuyển xe về lại vị trí cũ 
            pcbxe1.Left = 66;
            pcbxe1.Top = -120;

            pcbxe2.Left = 294;
            pcbxe2.Top = -185;

            //đặt lại đường về vị trí đẩu
            pcbDuong2.Left = -3;
            pcbDuong2.Top = -222;
            pcbDuong1.Left = -2;
            pcbDuong1.Top = -638;

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
            if (pcbDuong1.Top > 630)
            {
                pcbDuong1.Top = -630;
            }
            if (pcbDuong2.Top > 630)
            {
                pcbDuong2.Top = -630;
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
                if (pcbPlayer.Left + pcbPlayer.Width > 380)
                {
                    Phai = false;
                }
            }
            // kết thúc kiểm tra

            // di chuyển xe xuống
            pcbxe1.Top += TocDoDC;
            pcbxe2.Top += TocDoDC;

            // cho xe xuất hiện ngẫu nhiên
            if (pcbxe1.Top > plNen.Height)
            {
                ChangeXe1(); // chọn xe ngẫu nhiên làm vật cản
                pcbxe1.Left = rd.Next(2, 160); //random số bên trái
                pcbxe1.Top = rd.Next(100, 200) * -1; // radom số bên phải
            }
            if (pcbxe2.Top > plNen.Height)
            {
                ChangeXe2();
                pcbxe2.Left = rd.Next(185, 327);
                pcbxe2.Top = rd.Next(100, 200) * -1;
            }

            // kết thúc cho xe xuất hiện ngẫu nhiên
            // nếu palyer đụng xe 1 or xe 2
            if (pcbPlayer.Bounds.IntersectsWith(pcbxe1.Bounds) || pcbPlayer.Bounds.IntersectsWith(pcbxe2.Bounds))
            {
                GameOver(); // kết thúc game khi đụng phải xe 1 or xe 2

            }
            // tăng tốc dường băng
            //nếu điểm trên 100 và bé hơn 500
            if (Diem > 100 && Diem < 500)
            {
                TocDoDC = 6;
                TDDuong = 7;
            }
            // nếu điểm trên 500 và bé hơn 1000
            else
            {
                if (Diem > 500 && Diem < 1000)
                {
                    TocDoDC = 7;
                    TDDuong = 8;
                }
                // nếu điểm bé hơn 1200
                else
                {
                    if (Diem > 1200)
                    {
                        TocDoDC = 9;
                        TDDuong = 10;
                    }
                }
            }
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

        private void ChangeXe2()
        {
            int num = rd.Next(1, 8); // thiết lập một biến vị trí có số được tạo ra từ 1 tới 8
            // switch sẽ kiểm tra số được tạo ra  và sẽ hiện thị hình theo yêu cầu
            switch (num)
            {
                //  nếu số tạo ra là 1 thì hiển thị GreenCar
                case 1:
                    pcbxe2.Image = Properties.Resources.carGreen; break;
                //   nếu số tạo ra là 2 thì hiển thị GreyCar
                case 2:
                    pcbxe2.Image = Properties.Resources.carGrey; break;
                // nếu số tạo ra là 3 thì hiển thị oragneCar
                case 3:
                    pcbxe2.Image = Properties.Resources.carOrange; break;
                // nếu số tao ra là 4 thì hiễn thị PinkCar
                case 4:
                    pcbxe2.Image = Properties.Resources.carPink; break;
                // nếu số tạo ra là 5 thì hiển thị Red Car
                case 5:
                    pcbxe2.Image = Properties.Resources.CarRed; break;
                // nếu số tạo ra là 6 thì hiển thị blue truck
                case 6:
                    pcbxe2.Image = Properties.Resources.TruckBlue; break;
                // nếu số tạo ra là 7 thì hiển thị white truck
                case 7:
                    pcbxe2.Image = Properties.Resources.TruckWhite; break;
                // nếu số tạo ra là 8 thì hiển thị Ambulance
                case 8:
                    pcbxe2.Image = Properties.Resources.ambulance; break;
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
                    pcbxe1.Image = Properties.Resources.carGreen; break;
                //   nếu số tạo ra là 2 thì hiển thị GreyCar
                case 2:
                    pcbxe1.Image = Properties.Resources.carGrey; break;
                // nếu số tạo ra là 3 thì hiển thị oragneCar
                case 3:
                    pcbxe1.Image = Properties.Resources.carOrange; break;
                // nếu số tao ra là 4 thì hiễn thị PinkCar
                case 4:
                    pcbxe1.Image = Properties.Resources.carPink; break;
                // nếu số tạo ra là 5 thì hiển thị Red Car
                case 5:
                    pcbxe1.Image = Properties.Resources.CarRed; break;
                // nếu số tạo ra là 6 thì hiển thị blue truck
                case 6:
                    pcbxe1.Image = Properties.Resources.TruckBlue; break;
                // nếu số tạo ra là 7 thì hiển thị white truck
                case 7:
                    pcbxe1.Image = Properties.Resources.TruckWhite; break;
                // nếu số tạo ra là 8 thì hiển thị Ambulance
                case 8:
                    pcbxe1.Image = Properties.Resources.ambulance; break;
                default: break;
            }
        }

        private void GameOver()
        {
            pcbChienThang.Visible = true; // hiển thị  bảng chiến thắng
            timer1.Stop(); // dừng timer
            btnStart.Enabled = true; // bật button lúc sử dụng

            // hiển thị Nổ ở phía trên xe Player
            pcbNo.Visible = true; // hiển thị Hình Ảnh Nổ
            pcbPlayer.Controls.Add(pcbNo); // thêm HA Nổ trên xe player
            pcbNo.Location = new Point(-8, 5); 
            pcbNo.BackColor = Color.Transparent; // đổi màu 
            pcbNo.BringToFront(); // đem ra trước xe player

            // nếu score bé hơn 1000 thì --> A bronze

            if (Diem < 1000)
            {
                pcbChienThang.Image = Properties.Resources.bronze;
            }
            // nếu score > 2000 --> A silver
            if (Diem > 1000)
            {
                pcbChienThang.Image = Properties.Resources.silver;
            }
            // nếu score > 3500 --> A golden
            if (Diem > 2000)
            {
                pcbChienThang.Image = Properties.Resources.gold;
            }

            //PlaySound();
            PlaySound.Play();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Reset(); // reset lại tất cả khi nhấn nút start
        }

       

        

        private void Play_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                int num = rd.Next(1, 8);
                switch (num)
                {
                    //  nếu số tạo ra là 1 thì hiển thị GreenCar
                    case 1:
                        pcbPlayer.Image = Properties.Resources.carGreen; break;
                    //   nếu số tạo ra là 2 thì hiển thị GreyCar
                    case 2:
                        pcbPlayer.Image = Properties.Resources.carGrey; break;
                    // nếu số tạo ra là 3 thì hiển thị oragneCar
                    case 3:
                        pcbPlayer.Image = Properties.Resources.carOrange; break;
                    // nếu số tao ra là 4 thì hiễn thị PinkCar
                    case 4:
                        pcbPlayer.Image = Properties.Resources.carPink; break;
                    // nếu số tạo ra là 5 thì hiển thị Red Car
                    case 5:
                        pcbPlayer.Image = Properties.Resources.CarRed; break;
                    // nếu số tạo ra là 6 thì hiển thị blue truck
                    case 6:
                        pcbPlayer.Image = Properties.Resources.TruckBlue; break;
                    // nếu số tạo ra là 7 thì hiển thị white truck
                    case 7:
                        pcbPlayer.Image = Properties.Resources.TruckWhite; break;
                    // nếu số tạo ra là 8 thì hiển thị Ambulance
                    case 8:
                        pcbPlayer.Image = Properties.Resources.ambulance; break;
                    default: break;
                }
            }
            }

        private void lbExit_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn thực sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                this.Close();               
                PlaySound.Stop();
                timer1.Stop();
                timer2.Stop();
                r.Show();
            }
        }

        private void Play_Load(object sender, EventArgs e)
        {
           
            lbHuongDan.Text = "Di chuyển xe của bạn tránh \n" +
                "những chiếc khác,xe chạy càng lâu điểm\n" +
                "càng tăng cao tốc độ cũng tăng dần\n" +
                "(nhấn phím space để thay đổi xe \n" +
                "đang chạy)";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbHuongDan.Location = new Point(lbHuongDan.Location.X, lbHuongDan.Location.Y - 1);
            if(lbHuongDan.Location.Y+lbHuongDan.Height<0)
            {
                lbHuongDan.Location = new Point(lbHuongDan.Location.X, lbHuongDan.Height);
            }
        }


       /* private void PlaySound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"hit.wav");
            player.Play();
        }*/

        
    }
}
