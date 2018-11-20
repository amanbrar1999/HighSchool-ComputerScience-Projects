using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenging_Problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int findingIntUsingBruteForce(int input)
        {

            return 7;
        }

        private string findingIntUsingCleverAlgorithm(string input)
        {
            if(Convert.ToString(Convert.ToInt32(input)).Length > 1)
            {
                int index = input.Length - 1;
                while (index>0 && Convert.ToInt32(input.Substring(index, 1)) <= Convert.ToInt32(input.Substring(index - 1, 1)))
                {
                    
                    index -= 1;
                }

                string longestDecreasingSuffix = input.Substring(index);

                if(longestDecreasingSuffix == input)
                {
                    return "No Such Number Exists";
                }

                string pivot = input.Substring(index - 1, 1);
                string prefix = input.Substring(0, index - 1);
                string rightMostSuccessor = "";

                for (int i = longestDecreasingSuffix.Length - 1; i >= 0; i--)
                {
                    if (Convert.ToInt32(longestDecreasingSuffix.Substring(i, 1)) > Convert.ToInt32(pivot))
                    {
                        rightMostSuccessor = longestDecreasingSuffix.Substring(i, 1);
                        index = i;
                        break;
                    }
                }

                StringBuilder suffix = new StringBuilder(longestDecreasingSuffix);
                suffix[index] = Convert.ToChar(pivot);
                pivot = longestDecreasingSuffix.Substring(index, 1);
                longestDecreasingSuffix = suffix.ToString();

                string reverseSuffix = "";

                for (int i = longestDecreasingSuffix.Length - 1; i >= 0; i = i - 1)
                {
                    reverseSuffix += longestDecreasingSuffix.Substring(i, 1);
                }

                return prefix + pivot + reverseSuffix;
            }
            else
            {
                return "No Such Number Exists";
            }
           


        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = findingIntUsingCleverAlgorithm(inputTextBox.Text);
        }
    }
}
