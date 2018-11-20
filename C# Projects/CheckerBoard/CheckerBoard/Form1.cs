using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckerBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap checkerBoardBitmap = new Bitmap(400, 400); // Bitmap size set to 400 pixels x 400 pixels.

        private void checkerBoardPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(checkerBoardBitmap, 0, 0);
        } //End of method

        


        private void sizeTrackBar_Scroll(object sender, EventArgs e)
        {
            // A 'Graphics' object represents a GDI+ drawing surface.
            Graphics checkerBoard = Graphics.FromImage(checkerBoardBitmap);
            // A 'SolidBrush' object represents a brush of a single colour.
            // Brushes are used to fill graphics shapes.
            SolidBrush fillColourBrush = new SolidBrush(Color.Black);




            checkerBoard.Clear(checkerBoardPictureBox.BackColor);

            float lengthAndWidth = sizeTrackBar.Value;
            float increment = lengthAndWidth / 8;

            bool red = true;
            for (float x = 0; x < lengthAndWidth; x += increment)
            {
                for (float y = 0; y < lengthAndWidth; y += increment)
                {
                    if (y == 0)
                    {
                        checkerBoard.FillRectangle(fillColourBrush, x, y, increment, increment);
                    }
                    else
                    {
                        if (red == true)
                        {
                            fillColourBrush.Color = Color.Red;
                            red = false;
                        }
                        else
                        {
                            fillColourBrush.Color = Color.Black;
                            red = true;
                        }

                        checkerBoard.FillRectangle(fillColourBrush, x, y, increment, increment);
                    }

                }
            }



            checkerBoardPictureBox.Refresh(); // Fire the 'Paint' event on the picture box.
                                              // Release resources used by the brush and graphics objects.
            checkerBoard.Dispose();
            fillColourBrush.Dispose();
        }
    }
}
