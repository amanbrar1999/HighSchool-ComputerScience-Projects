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


namespace playing_with_vectors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap vectorBitmap = new Bitmap(400, 400);

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics vectorImage = Graphics.FromImage(vectorBitmap);
            Pen lines = new Pen(Color.Green);

            
           
        }
    }
}
