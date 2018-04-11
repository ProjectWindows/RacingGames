using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        object locker = new object();
        private void button1_Click(object sender, EventArgs e)
        {

            createThread(pictureBox1);
            MoveLeft((object)pictureBox2);
        }
        private void createThread3(PictureBox pcb)
        {
            Thread thread = new Thread(MoveLeft2);
            thread.IsBackground = true;
            thread.Start((object)pcb);

        }
        private void createThread2(PictureBox pcb)
        {
            Thread thread = new Thread(MoveLeft2);
            thread.IsBackground = true;
            thread.Start((object)pcb);

        }
        private void createThread(PictureBox pcb)
        {
            Thread thread = new Thread(MoveLeft);
            thread.IsBackground = true;
            thread.Start((object)pcb);

        }
        private void MoveLeft2(object Picture)
        {
            Monitor.Enter(locker);
            PictureBox pic = Picture as PictureBox;
            while (true)
            {
                pic.Left += 10;
                Application.DoEvents();
                if (pic.Right >= panel1.Width - 50)
                {
                    break;
                }
                System.Threading.Thread.Sleep(50);
            }
            Monitor.Exit(locker);

        }




        private void MoveLeft(object Picture)
        {

            PictureBox pic = Picture as PictureBox;
            while (true)
            {
                pic.Left += 10;
                Application.DoEvents();
                if (pic.Right >= panel1.Width - 50)
                {
                    break;
                }
                System.Threading.Thread.Sleep(50);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(0, pictureBox1.Location.Y);
            pictureBox2.Location = new Point(0, pictureBox2.Location.Y);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            createThread2(pictureBox1);
            MoveLeft2(pictureBox2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            createThread(pictureBox1);
            createThread(pictureBox2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            createThread2(pictureBox1);
            createThread2(pictureBox2);
        }
    }
}
