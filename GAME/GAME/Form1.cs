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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Play p = new Play();
            p.ShowDialog();
            //this.Close();
           // Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       
    }
}
