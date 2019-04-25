using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bitmap;
        Graphics gBitmap;
        Pen pen = new Pen(Color.Black, 3);
        Point initial, final;
        bool mouseClicked;
        bool isRectangle;
        Rectangle rectangle;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                label1.Text = "X = " + e.X + " Y = " + e.Y;
               
                
            }
            pictureBox1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gBitmap = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
            mouseClicked = false;
            isRectangle = false;
        }

        
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                final = e.Location;
                mouseClicked = false;
            }
            gBitmap.DrawRectangle(pen, getRectangle());
        }

        private Rectangle getRectangle()
        {
            rectangle = new Rectangle();
            rectangle.X = Math.Min(initial.X, final.X);
            rectangle.Y = Math.Min(initial.Y, final.Y);
            rectangle.Width = Math.Abs(initial.X - final.X);
            rectangle.Height = Math.Abs(initial.Y - final.Y);
            return rectangle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isRectangle = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
            initial = e.Location;
           
        }


    }
}
