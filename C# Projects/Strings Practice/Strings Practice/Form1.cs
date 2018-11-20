using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = "";
            int lengthCount = inputTextBox.Text.Length;
            

            for (int i = 0; i <= lengthCount - 1; i++)
            {
                if (inputTextBox.Text.Substring(i, 1) != " ")
                {
                    
                    input += inputTextBox.Text.Substring(i, 1);
                }
                
            }

            input = input.ToLower();
           

            string reverse = "";

            if (input.Length > 1)
            {

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reverse += input.Substring(i, 1);
                }

                if (reverse == input)
                {
                    palindromeOutputLabel.Text = "It is a palindrome";
                }
                else
                {
                    palindromeOutputLabel.Text = "It is not a palindrome";
                }

            }

            string consonants = "bcdfghjklmnpqrstvwxzBCDFGHJKLMNPQRSTVWXZ";

            int numberOfConsonants = 0;

            for (int i = 0; i <= consonants.Length - 1; i++)
            {
                for (int x = 0; x <= input.Length - 1; x++)
                {
                    if (input.Substring(x, 1) == consonants.Substring(i, 1))
                    {
                        numberOfConsonants += 1;
                    }
                }
            }

            consonantsOutputLabel.Text = Convert.ToString(numberOfConsonants);

            int numberOfDoubleLetters = 0;

            for (int i = 0; i <= input.Length - 2; i++)
            {
                if (input.Substring(i, 1) == input.Substring(i + 1, 1))
                {
                    numberOfDoubleLetters += 1;
                    i++;
                }
            }

            doubleLetterOutputLabel.Text = Convert.ToString(numberOfDoubleLetters);
        }
    }
}
