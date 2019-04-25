using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toBin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(textBox1.Text);
            textBox1.Text = toBinary(temp).ToString();
            textBox1.Refresh();
        }
        private static string toBinary(int a)
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
    }
}
