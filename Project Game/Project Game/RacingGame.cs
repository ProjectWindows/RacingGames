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
    public partial class RacingGame : Form
    {
        public RacingGame()
        {
            InitializeComponent();
            
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

        
    }
}
