using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmicablePairsFrom1_1000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> listOfPairs = new List<int>();

            

            for (int x = 1; x <= 10000; x++)
            {

                for (int y = 2; y <= 10000; y++)
                {
                    int sumOfXDivisors = 1, sumOfYDivisors = 1;

                    for (int z = 2; z <= (x / 2); z++)
                    {
                        if (x % z == 0)
                        {
                            sumOfXDivisors += z;
                        }
                    }



                    for (int z = 2; z <= (y / 2); z++)
                    {
                        if (y % z == 0)
                        {
                            sumOfYDivisors += z;
                        }
                    }


                    if (sumOfYDivisors == x && sumOfXDivisors == y && x != y)
                    {
                        listOfPairs.Add(x);
                        listOfPairs.Add(y);
                    }

                } 
            }

            label1.Text = "";

            for (int i = 1; i< listOfPairs.Count; i++)
            {
                if (listOfPairs[0] == listOfPairs[i] || listOfPairs[1] == listOfPairs[i] )
                { listOfPairs.RemoveAt(i); }
            }

            for (int i = 0; i < listOfPairs.Count; i++)
            {
                label1.Text = label1.Text + listOfPairs[i] + " ";
            }
        }
    }
}
