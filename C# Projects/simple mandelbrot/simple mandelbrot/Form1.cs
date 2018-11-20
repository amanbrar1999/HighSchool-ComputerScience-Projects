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


namespace simple_mandelbrot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap mandelbrotPictureBitmap = new Bitmap(800,600);

        double maxModulus = 2.0d;
        private void drawButton_Click(object sender, EventArgs e)
        {
            Graphics mandelbrotSetImage = Graphics.FromImage(mandelbrotPictureBitmap);

            //Instantiations of the 'Complex' class. Create two complex objects, 'c' and 'z.'
            //For both 'Complex' objects, the real and imaginary parts are initially set to 0.
            Complex z = new Complex(0, 0);
            Complex c = new Complex(0, 0);

            //For efficiency reasons, copy the 'Width' and 'Height' properties to variables.
            //This is called "caching" the values of properties.
            int width = mandelbrotPictureBitmap.Width;
            int height = mandelbrotPictureBitmap.Height;

            mandelbrotSetImage.Clear(mandelbrotPictureBox.BackColor);
            mandelbrotPictureBox.Refresh();

            //Traverse the bitmap one pixel at a time, column by column. Screen co-ordinates are (x,y).
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    //The real and imaginary parts of the 'c' are determined by the linear transformations that map
                    //the region of the Cartesian plane in which 0<=x<800, 0<=y<600 to the region of the Complex plane
                    //in which -2.5<=Re(z)<1.5 and -1.5<=Im(z)<1.5
                    c = new Complex(4.0d / width * x - 2.5d, -3.0d / height * y + 1.5d);
                    z = 0;
                    int iterations = 0;

                    //For the value of c corresponding to screen co-ordinates (x,y), generate terms of the Mandelbrot sequence. 
                    //The loop terminates as soon as |z| exceeds 'maxModulus' or at the 100th term.
                    do
                    {
                        z = Complex.Add(Complex.Pow(z, 2), c);//z=z^2+c
                        iterations++;
                    } while (Complex.Abs(z) < maxModulus && iterations <= 100);

                    mandelbrotPictureBitmap.SetPixel(x, y,colouring(z));

                }//end inner for
                mandelbrotPictureBox.Refresh();
            }//end outer for


        }

        private void mandelbrotPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(mandelbrotPictureBitmap,0,0);
        }

        private Color colouring(Complex z)
        {
            if(Complex.Abs(z) >2)
            {
                return Color.White;
            }
            else
            {
                return Color.Black;
            }
        }
    }
}
