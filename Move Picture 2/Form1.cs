using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Move_Picture_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
           
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 5);
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 5);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Location.X >0)
            pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y);


        }
    }
}
