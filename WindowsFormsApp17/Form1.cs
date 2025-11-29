using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Management.Instrumentation;


namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            
            InitializeComponent();
            
            this.Opacity = 0.98;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2CircleProgressBar1.Value < 100)
            {
                guna2CircleProgressBar1.Value += 1;
            }
            else
            {
                Form3 Form3 = new Form3();
                Form3.Show();
                this.Hide();
                timer1.Stop();
            }
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
                guna2Transition1.HideSync(guna2Panel1);
                guna2Panel4.BringToFront();
                timer1.Start();
        }

        private void dots2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
