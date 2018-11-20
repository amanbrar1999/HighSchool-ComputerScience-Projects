using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Form1 : Form
    {
        Bitmap lineData = new Bitmap(400, 400);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics lines = Graphics.FromImage(lineData);
            Pen pen = new Pen(Color.Black);

            placementSpiral(lines, pen, pictureBox1);

            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(lineData,0,0);
        }

        private void placementSpiral(Graphics lineDrawer,Pen pen,PictureBox canvas)
        {
            const double D = 100;
            double angle = Math.Atan(D/(canvas.Width - D));
            double verticalDistance = 0;
            double secondVD = 0;
            double secondHD = canvas.Width;
            double horizontalDistance = 0;
            for(int factor=0;factor< 180/angle ;factor+=1)
            {
                horizontalDistance += D * Math.Cos(angle * factor);
                verticalDistance += D*Math.Sin(angle+factor);
                secondVD += D * Math.Cos(angle * factor);
                secondHD -= D * Math.Sin(angle * factor);

                lineDrawer.DrawLine(pen, (float)horizontalDistance, (float)verticalDistance, (float)secondHD, (float)secondVD);
            }
            
        }
    }
}
