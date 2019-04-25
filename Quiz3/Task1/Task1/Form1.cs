using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b;
        List<int> factors_a = new List<int>();
        List<int> factors_b = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            label1.Text = (check(dividers(a, factors_a), dividers(b, factors_b))).ToString();

        }
        private List<int> dividers(int x, List<int> y)
        {
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    y.Add(i);
                }
            }
            return y;
        }
        private int check(List<int> a, List<int> b)
        {
            foreach(int s in a)
            {
                foreach(int l in b)
                {
                    if (s == l)
                        return s;
                }
            }
            return 1;
        }
    }
}
