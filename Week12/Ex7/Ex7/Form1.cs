using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
        }
        bool mouseClicked = false;
        Bitmap bitmap;
        Graphics g;
        Point prev, curr;
        Pen pen = new Pen(Color.Black, 3);
        int x, y;
      
       
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
            prev = e.Location;
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                curr = e.Location;
                
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
            g.DrawEllipse(pen, getRectangle(prev, curr));

            x = getRectangle(prev, curr).X;
            y = getRectangle(prev, curr).Y;
            timer1.Start();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(pen, getRectangle(prev,curr));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.DrawEllipse(pen, getRectangle(prev, curr));
            x +=20;
            y += 20;

            pictureBox1.Refresh();
        }

        private Rectangle getRectangle(Point prev, Point curr)
        {
            Rectangle rect;
            int minX = Math.Min(prev.X, curr.X);
            int maxX = Math.Max(prev.X, curr.X);
            int minY = Math.Min(prev.Y, curr.Y);
            int maxY = Math.Max(prev.Y, curr.Y);
            rect = new Rectangle(minX, minY, maxX - minX, maxY - minY);
            return rect;
        }
    }
}
