using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME
{
    public partial class Play : Form
    {
        public Play()
        {
            InitializeComponent();
        }

        
        private void Play_Load(object sender, EventArgs e)
        {
            lbCachChoi.Text = "Di chuyển xe của bạn ăn những\n" +
                "cục hình vuông thì sẽ ghi điểm\n" +
                "còn ăn những cục hình tròn sẽ bị \n" +
                "trừ điểm";
            timer1.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn thực sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if(d==DialogResult.Yes)
            {
                this.Close();
            }
            
        }

       

        private void Play_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 p = new Form1();
            p.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbCachChoi.Location = new Point(lbCachChoi.Location.X,lbCachChoi.Location.Y-1);
            if(lbCachChoi.Location.Y+lbCachChoi.Height<0)
            {
                lbCachChoi.Location = new Point(lbCachChoi.Location.X, plCC.Height);
            }
        }
    }
}
