using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoronicaChangeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string algorithm (int[] divisorList, string[] symbols, int input)
        {
            int dividend = input;
            string finalAnswer = "";
            int quotient = 0;
            int remainder = 0;

            for(int i=0;i<divisorList.Length;i++)
            {
                
                int divisor = divisorList[i];

                quotient = dividend / divisor;
                remainder = dividend % divisor;

                dividend = remainder;

                finalAnswer += Convert.ToString(quotient) + " " + symbols[i] + ",";
              
            }

            finalAnswer = finalAnswer.Remove(finalAnswer.Length - 1, 1);

            return finalAnswer;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(inputTextBox.Text);
            int[] divisorList = new int[6] { 100,47, 22, 11, 3, 1 };
            string[] moronicaSymbols = new string[6] { "Lurchs","Blurps", "Chunks", "Globs", "Splats", "Blots" };

           outputLabel.Text = algorithm(divisorList, moronicaSymbols, Convert.ToInt32(inputTextBox.Text));

            
        }
    }
}
