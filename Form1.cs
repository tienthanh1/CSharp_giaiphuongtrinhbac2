using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_giaiphuongtrinhbac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txta.Text = trackBar1.Value.ToString();
        }

        private void txtb_Scroll(object sender, EventArgs e)
        {
            txtb.Text = trackBar2.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            txtc.Text = trackBar3.Value.ToString();
        }

        private void btngiaiphuongtrinh_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txta.Text);
            b = Convert.ToInt32(txtb.Text);
            c = Convert.ToInt32(txtc.Text);
            double delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("phương trình có 2 nghiệm phân biệt:");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 =" + x2);
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("phương trình có nghiệm kép:");
                Console.WriteLine("x = " + x);
            }
            else
            {
                Console.WriteLine("phương trình vô nghiệm");
            }
        }
    }
}
