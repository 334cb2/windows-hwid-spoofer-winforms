using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.Opacity = 0.96;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
            {
                label8.ForeColor = Color.White;
            }
            else
            {
                label8.ForeColor = Color.FromArgb(126, 123, 131);
            }
        }


        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch2.Checked)
            {
                label9.ForeColor = Color.White;
            }
            else
            {
                label9.ForeColor = Color.FromArgb(126, 123, 131);
            }
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ToggleSwitch3_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch3.Checked)
            {
                label10.ForeColor = Color.White;
            }
            else
            {
                label10.ForeColor = Color.FromArgb(126, 123, 131);
            }
        }

        private void guna2ToggleSwitch4_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch4.Checked)
            {
                label11.ForeColor = Color.White;
            }
            else
            {
                label11.ForeColor = Color.FromArgb(126, 123, 131);
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            label13.ForeColor = Color.FromArgb(63, 59, 79);
            label14.ForeColor = Color.White;

            guna2Transition1.HideSync(guna2Panel1);
           guna2Transition1.ShowSync(guna2Panel7);
            guna2Panel7.BringToFront();
            
        }

        private void label13_Click(object sender, EventArgs e)
        {
            label13.ForeColor = Color.White;
            label14.ForeColor = Color.FromArgb(63, 59, 79);
            guna2Transition1.HideSync(guna2Panel7);
            guna2Transition1.ShowSync(guna2Panel1);
            
            
        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {
            
        }


        private void timer2_Tick_1(object sender, EventArgs e)
        {
            guna2Transition2.ShowSync(guna2Panel1);
            timer2.Stop();
        }

        private void StartColorTransition(Color startColor, Color endColor)
        {
            
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void dots3_Click(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void guna2Panel5_Paint(object sender, EventArgs e)
        {

        }
    }
}
