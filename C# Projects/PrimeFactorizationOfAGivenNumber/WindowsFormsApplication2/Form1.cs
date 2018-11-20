using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            private bool isPrime(int n)
            {

            for (int x = 2; x <= (int)Math.Sqrt(n); x++)
                {
                if (n % x == 0) 
                    return false; 
                }

                 return true; 
            }

        private bool isNotPrime(int n)
        {

            for (int x = 2; x <= (int)Math.Sqrt(n); x++)
            {
                if (n % x == 0)
                    return true;
            }

            return false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(textBox1.Text);
            List<int> listOfPrimeFactors = new List<int>();

            if (isPrime(input))
            {
                MessageBox.Show("Enter a non-prime number");
            }
            else
            {
                int biggerMultiple = input;

                while (isNotPrime(biggerMultiple))
                {
                   

                    for (int divisor=2; divisor <= biggerMultiple/2; divisor++)
                    {
                        if (biggerMultiple%divisor == 0 && isPrime(divisor))
                        {
                            listOfPrimeFactors.Add(divisor);
                            biggerMultiple = biggerMultiple / divisor;
                            divisor = 1;
                        }
                       
                    }

                    
                }
                listOfPrimeFactors.Add(biggerMultiple);
            }

            label1.Text = "";

           for (int i=0; i<listOfPrimeFactors.Count;i++)
            {
                if (i== listOfPrimeFactors.Count -1)
                {
                   label1.Text = label1.Text + listOfPrimeFactors[i]; 
                }
                else
                {
                    label1.Text = label1.Text + listOfPrimeFactors[i] + "*";
                }
            }

           
        }
    }
}
