using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Round_Robin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[,] roundRobin = new int[5, 2] { { 1, 10 }, { 2, 9 }, { 3, 8 }, { 4, 7 }, { 5, 6 } };


        private void button1_Click(object sender, EventArgs e)
        {
            int[,] newList = new int[5, 2];
            newList[0, 0] = 1;

            for (int x = 0; x <= 3; x++)
            {
                newList[x + 1, 1] = roundRobin[x, 1];
            }

            for (int x = 4; x >= 2; x--)
            {
                newList[x - 1, 0] = roundRobin[x, 0];
            }

            newList[0, 1] = roundRobin[1, 0];
            newList[4, 0] = roundRobin[4, 1];

            roundRobin = newList;

            label1.Text = Convert.ToString(roundRobin);

        }
    }
}
