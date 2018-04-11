using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace DemoDaluong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // Display();
           // Display2();
        }
        object locker = new object();
        public void Display()
        {
            new Thread(() =>
            {
                while (true)
                {
                    label6.Visible = true;
                    label6.ForeColor = Color.Blue;

                    Thread.Sleep(300);
                    label6.Visible = true;
                    label6.ForeColor = Color.Black;
                    Thread.Sleep(500);

                    
                }
            }).Start();
            new Thread(() =>
            {
                while (true)
                {
                    label1.Visible = true;
                    label1.ForeColor = Color.Green;

                    Thread.Sleep(300);
                    label1.Visible = true;
                    label1.ForeColor = Color.Black;
                    Thread.Sleep(500);
                }
            }).Start();
        }
       public void Display2()
        {
            Monitor.Enter(locker);
            new Thread(() =>
            {
                while (true)
                {
                    label6.Visible = true;
                    label6.ForeColor = Color.Yellow;
                    Thread.Sleep(300);
                    label6.Visible = true;
                    label6.ForeColor = Color.Black;
                    Thread.Sleep(500);
                }
                
            }).Start();
            new Thread(() =>
            {
                while (true)
                {
                    label1.Visible = true;
                    label1.ForeColor = Color.Red;

                    Thread.Sleep(300);
                    label1.Visible = true;
                    label1.ForeColor = Color.Black;
                    Thread.Sleep(500);
                }
            }).Start();
            Monitor.Exit(locker);
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
