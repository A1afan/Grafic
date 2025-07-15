using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Grafic
{
    public partial class Form1 : Form
    {
         Grafic grafic;

        public Form1()
        {
            InitializeComponent();
            Grafic.bitmap = new System.Drawing.Bitmap(pictureBox1.Width, pictureBox1.Height);
            grafic = new Grafic(x=>Math.Cos(x));
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            grafic.Initialize(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
            grafic.DecardSystem();
            grafic.Draw();
            pictureBox1.Image = Grafic.bitmap;

        }
    }
}
