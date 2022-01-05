using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        delegate void hesablama(double p1);

        void islem(double x)
        {
            listBox1.Items.Add((4 * x)*(4 * x) + 5 * x + 10);
        }
        void kare(double y)
        {
            listBox1.Items.Add(y*y);

        }
        void kup(double z)
        {
            listBox1.Items.Add(z * z * z);

        }
        void daire(double s)
        {
            listBox1.Items.Add(Math.Sqrt(s));

        }
        private void button1_Click(object sender, EventArgs e)
        {
            double say = Convert.ToDouble(textBox1.Text);
            hesablama hesablama1 = new hesablama(islem);
            hesablama1 += kare;
            hesablama1 += kup;
            hesablama1 += daire;

            hesablama1(say);




        }


    }
}
