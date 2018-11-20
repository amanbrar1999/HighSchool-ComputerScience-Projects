using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanNumeralConvertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Button Event Hander

        private void convertButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            string[] numeralList = new string[13] { "I", "IV", "V","IX","X","XL","L","XC","C","CD","D","CM","M" };
            int[] numberList = new int[13] { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
            
            int ifInt;
            if (int.TryParse(inputTextBox.Text, out ifInt) && ifInt>=0 && ifInt<=3999)
            {
                if(ifInt >= 0 && ifInt <= 3999)
                {
                    // it's a valid integer 
                    int inputNumber = Convert.ToInt32(inputTextBox.Text);
                    outputLabel.Text = numberToRomanNumeral(numeralList,numberList,inputNumber);
                }
                else
                {
                    MessageBox.Show("Please Enter a Number Between 0 and 3999");
                }
                    
            }
            else
            {
                // it is a roman numeral
                string input = inputTextBox.Text.ToUpper();

                if(isValidNumeral(input,numeralList,numberList))
                {
                    if (numberToRomanNumeral(numeralList,numberList, romanNumeralToNumber(numeralList, numberList, input)) == input) // this verifies if it is a valid numeral
                    {
                        outputLabel.Text = Convert.ToString(romanNumeralToNumber(numeralList, numberList, input));
                    }
                    
                    else
                    {
                        inputTextBox.Text = "";
                        MessageBox.Show("Invalid Input");
                    }
                       

                }
                else
                {
                    MessageBox.Show("Invalid Input");
                }
                
            }
        }
        #endregion

        #region Conversion Methods
        // checks if the characters entered are found within the array of numerals
        private bool isValidNumeral(string input, string[] numeralList, int[] numberList)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (Array.IndexOf(numeralList, input.Substring(i, 1)) == -1)
                {
                    return false;
                }
            }
            return true;
        }


        private int romanNumeralToNumber(string[] list,int[] numList, string input)
        {
           
                int finalAnswer = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    string character = input.Substring(i, 1);
                    int value = numList[Array.IndexOf(list, character)];
                    int newVal = 0;
                    string nextChar = "";

                    if (i < input.Length - 1) 
                    {
                        nextChar = input.Substring(i + 1, 1); // we must also look at the next character to determine whether we add or subtract
                        newVal = numList[Array.IndexOf(list, nextChar)]; // find the corresponding character of the same index
                    }

                    if (value >= newVal)
                    {
                        finalAnswer += value;
                    }
                    else
                    {
                        finalAnswer -= value;
                    }
                }

                return finalAnswer;
            
        }
        
        private string numberToRomanNumeral(string[] list,int[] numList, int input)
        {
            int quotient = 0;
            int remainder = 0;
            int dividend = input;
            string romanNumeral = "";

            for (int i = list.Length - 1; i >= 0; i--)
            {
                
                quotient = dividend / Convert.ToInt32(numList[i]);
                remainder = dividend % Convert.ToInt32(numList[i]);

                if (quotient >= 1)
                {
                    for (int number = 1; number <= quotient; number++)
                    {
                        romanNumeral += list[i];
                    }
                }
                dividend = remainder;
            }

            return romanNumeral;
        }
        #endregion

        #region Default Properties

        private void Form1_Load(object sender, EventArgs e)
        {
            outputLabel.AutoSize = false;
            outputLabel.TextAlign = ContentAlignment.MiddleCenter;
            outputLabel.Dock = DockStyle.Bottom;

            inputTextBox.Dock = DockStyle.Top;

            
            convertButton.Dock = DockStyle.Fill;
        }

        #endregion
    }
}
