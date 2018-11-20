using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Julia_Set
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap JuliaSetBitmap = new Bitmap(800,600);

        private void button1_Click(object sender, EventArgs e)
        {
            Complex z = new Complex(0, 0);
            Complex c = new Complex(-1.037,0.17);

            for(int x=0;x<JuliaSetBitmap.Width;x++)
            {
                for(int y=0;y<JuliaSetBitmap.Height;y++)
                {
                    z = Complex.Add(4.0d / JuliaSetBitmap.Width * x - 2.0d, -3.0d / JuliaSetBitmap.Height * y + 1.5d);
                    int iterations = 0;

                    do
                    {
                        z = Complex.Add(Complex.Pow(z, 2), c);
                        iterations++;
                    } while (Complex.Abs(z) < 2 && iterations <= 100);

                    JuliaSetBitmap.SetPixel(x, y, colouringScheme(iterations));
                }
            }

            pictureBox1.Refresh();

        }

        private Color colouringScheme(int repetitions)
        {
            if(repetitions<100 )
            {
                return Color.White;
            }
            else
            {
                return Color.Black;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(JuliaSetBitmap,0,0);
        }
    }
}
