using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCardValidation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        // procedure of luhn algorithm
        private bool LuhnAlgorithmValidation(string number)
        {
                string reverse = "";
                // reverse the string
                for (int i = number.Length - 1; i >= 0; i = i - 1)
                {
                    reverse += number.Substring(i, 1);
                } // end of loop


                int checkSum = 0;

            // check the digit at each individual index in the string
                for (int i = 1; i <= reverse.Length; i++)// i will represent the position in the string, and i-1 will be the index
                {
                    int digit = Convert.ToInt32(reverse.Substring(i - 1, 1));

                    if (i % 2 == 0) // if position is even
                    {
                    int doubleDigit = digit * 2;

                        if (doubleDigit >= 10)
                        {
                            
                            checkSum += (doubleDigit / 10) + (doubleDigit % 10) ; // adds the 2 digits together ( eg: for 12, performs operation 1+2)

                        }
                        else
                        {
                            checkSum += doubleDigit;
                        }

                    }
                    else // if position is odd
                    {
                        checkSum += digit;
                    }

                }  // end of loop 


                if (checkSum % 10 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                } // end of "if" statement
           
        } // end of Luhn Algorithm Procedure

        

        private void ValidateButton_Click(object sender, EventArgs e)
        {
            string cardNum = CardNumberTextBox.Text;

            float ifInt; // float was used because the numbers are too big to store under integer datatype
            //check if the string contains letters, if it does then display messagebox,
           
            if (float.TryParse(CardNumberTextBox.Text, out ifInt) == false)
            {
                MessageBox.Show("Please Enter Numbers Only");
            }
            else  //if it does not (meaning it therefore contains numbers) continue with the code
            {

                if (cardNum.Length >= 14 && cardNum.Length <= 16)
                {
                    //some strings have manditory prefixes with a different number of integers (eg. Visa only has 1 integer which is 4, whereas
                    // discover has 4 integers which are "6011") we must take substrings for the different number of characters in the prefix to check
                    int oneCharacterCheck = Convert.ToInt32(cardNum.Substring(0, 1));
                    int twoCharacterCheck = Convert.ToInt32(cardNum.Substring(0, 2));
                    int fourCharacterCheck = Convert.ToInt32(cardNum.Substring(0, 4));

                    string cardType = "";


                    // check the card type
                    if (oneCharacterCheck == 4 && cardNum.Length == 16)
                    {
                        cardType = "Visa";
                    }
                    else if ((twoCharacterCheck >= 51 && twoCharacterCheck <= 55) && cardNum.Length == 16)
                    {
                        cardType = "Master Card";
                    }
                    else if ((twoCharacterCheck == 34 && cardNum.Length == 15) || (twoCharacterCheck == 37 && cardNum.Length == 15))
                    {
                        cardType = "American Express";
                    }
                    else if (fourCharacterCheck == 6011 && cardNum.Length == 16)
                    {
                        cardType = "Discover";
                    }
                    else if (twoCharacterCheck == 36 && cardNum.Length == 14)
                    {
                        cardType = "Diners Club";
                    } // end of if statement

                   
                    if (LuhnAlgorithmValidation(cardNum) && cardType != "")
                    {
                        ValidateLabel.Text = "This " + cardType + " Credit Card Number is Valid";
                    }
                    else
                    {
                        ValidateLabel.Text = "This is not a valid credit card number";
                    }

                }
                else
                {
                    MessageBox.Show("Please Enter a Reasonable Number");
                } // end of "if" statement
            }

        } // end of Validate button click event


        private void generateButton_Click(object sender, EventArgs e)
        {
            int startingNumber = 0;
            int length = 0;
            Random randomPrefix = new Random();

            if (VisaRadioButton.Checked)
            {
                startingNumber = 4;
                length = 16;
            }
            else if (MasterCardRadioButton.Checked)
            {
                startingNumber = randomPrefix.Next(51,56);
                length = 16;
            }
            else if (AMEXradioButton.Checked)
            {
                int rnd = randomPrefix.Next(1,3);
                if (rnd == 1)
                {
                    startingNumber = 34;
                }
                else
                {
                    startingNumber = 37;
                }
                length = 15;
            }
            else if (DiscoverRadioButton.Checked)
            {
                startingNumber = 6011;
                length = 16;
            }
            else if (DinersClubRadioButton.Checked)
            {
                startingNumber = 36;
                length = 14;
            }
            else
            {
                MessageBox.Show("Please Choose a Card Type");
            }

           
            string generatedNumber = "1"; // null string satisfies luhn algorithm, so arbitrarily choose 1

            while(LuhnAlgorithmValidation(generatedNumber) == false )
            {
                generatedNumber = Convert.ToString(startingNumber);
                for (int i = 0; i<length-startingNumber.ToString().Length;i++)
                 {
                generatedNumber += Convert.ToString(randomPrefix.Next(0, 10));
                 }
            }
            
            generatedNumberLabel.Text = generatedNumber;
        }
    }
}
