using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       
        
        public Form1()
        {
            InitializeComponent();
        }
        double newN;
        double initialNum, result;
        string operation;

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void buttonClick (object sender, EventArgs e)
        {
            Button button = sender as Button;
            textBox1.Text += button.Text;
            
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            initialNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operation = "/";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            newN = Convert.ToDouble(textBox1.Text);
            if (operation == "/")
                textBox1.Text = (divide(initialNum, newN)).ToString();
            if (operation == "sin")
                textBox1.Text = (sin(initialNum)).ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        public static double sum(double a, double b)
        {
            return a + b;
        }
        public static double multiply(double a, double b)
        {
            return a * b;
        }
        public static double divide(double a, double b)
        {
            return a / b;
        }
        public static double sin(double a)
        {
            return Math.Sin(a * Math.PI / 180);
        }
        public static string toBinary(double a)
        {
            int val;
            string b = "";
            while (a >= 1)
            {
                val = Convert.ToInt32(a) / 2;
                b += (Convert.ToInt32(a) % 2).ToString();
                a = val;

            }
            string binValue = "";
            for (int i = b.Length - 1; i >= 0; i--)
            {
                binValue += b[i];
            }
            return binValue;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            initialNum = 0;
            newN = 0;
            result = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            initialNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = (sin(initialNum)).ToString();
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            initialNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text=toBinary(initialNum);
           

        }

        public static double sub(double a, double b)
        {
            return a - b;
        }
    }
}
