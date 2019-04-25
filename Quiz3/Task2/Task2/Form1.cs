using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bitmap;
        Graphics gBitmap;
        bool mouseClicked = false;
        Pen pen = new Pen(Color.Red, 3);
        int x, y,r=0;
        Rectangle rectangle;
        

       
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
           
            if (!mouseClicked)
            {
                x = e.Location.X;
                y = e.Location.Y;
                
                timer1.Start();
                mouseClicked = true;
            }
            else
            {
                mouseClicked = false;
                timer1.Stop();
            }
           

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gBitmap = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            r+=10;
            gBitmap.FillEllipse(pen.Brush, x,y+r,20,20);
            pictureBox1.Refresh();
        }
    }
}
