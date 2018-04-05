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
using System.Threading;


namespace Project_Game
{
    public partial class RacingGame : Form
    {
        SoundPlayer play = new SoundPlayer(@"gioithieu.wav");

        public RacingGame()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            DisPlay();
         //   play.PlayLooping();
        }

        public void DisPlay()
        {
            new Thread(() =>
            {
                int i = 0;
                while (i >= 0)
                {
                    Thread.Sleep(300);
                    label1.Visible = false;
                    Thread.Sleep(300);
                    label1.Visible = true;
                    if (i % 2 == 0)
                        label1.ForeColor = Color.Orange;
                    else
                        label1.ForeColor = Color.Tomato;
                    i++;
                }
            })
            { IsBackground = true }.Start();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Play p = new Play();
            p.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn thực sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void RacingGame_Load(object sender, EventArgs e)
        {
            play.Play();
        }

        private void bt2cars_Click(object sender, EventArgs e)
        {
            this.Hide();
            _2Cars mode2 = new _2Cars();
            mode2.ShowDialog();
        }
    }
}
