using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
  

        public Form1()
        {
            InitializeComponent();

        }

        string year;
        int firstDigits;
        int lastDigits;
        int wholeyear;
        int anchorDayIndex;
        int SumOfCalculatedValues;
        int doomsday;
        int memorableDay;
        int inputDay;
        int differenceInDays;
        int actualDay;

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.Azure;
            year = yearTextBox.Text;
            firstDigits = Convert.ToInt32(year) / 100;
            lastDigits = Convert.ToInt32(year) % 100;
            inputDay = Convert.ToInt32(dayTextBox.Text);
            wholeyear = Convert.ToInt32(yearTextBox.Text);

            if (firstDigits % 4 == 0)
            {
                anchorDayIndex = 2;
            }
            else if (firstDigits % 4 == 1)
            {
                anchorDayIndex = 0;
            }
            else if (firstDigits % 4 == 2)
            {
                anchorDayIndex = 5;
            }
            else anchorDayIndex = 3;

            SumOfCalculatedValues = lastDigits / 12 + lastDigits % 12 + anchorDayIndex + ((lastDigits % 12) / 4);
            doomsday = SumOfCalculatedValues % 7;

            // now find closest memorable day by using the same inputted month as the memorable date.

            if (monthTextBox.Text == "Janurary")
            {
                if (lastDigits % 4 == 0)
                {
                    if (wholeyear % 100 == 0 && wholeyear % 400 != 0)
                        memorableDay = 3;
                    else memorableDay = 4;

                }
                else memorableDay = 3;
            }
            else if (monthTextBox.Text == "February")
            {
                if (lastDigits % 4 == 0)

                {
                    if (wholeyear % 100 == 0 && wholeyear % 400 != 0)
                        memorableDay = 28;
                    else memorableDay = 29;
                }
                else memorableDay = 28;
            }
            else if (monthTextBox.Text == "March")
            {
                memorableDay = 0;
            }
            else if (monthTextBox.Text == "April")
            {
                memorableDay = 4;
            }
            else if (monthTextBox.Text == "May")
            {
                memorableDay = 9;
            }
            else if (monthTextBox.Text == "June")
            {
                memorableDay = 6;
            }
            else if (monthTextBox.Text == "July")
            {
                memorableDay = 11;
            }
            else if (monthTextBox.Text == "August")
            {
                memorableDay = 8;
            }
            else if (monthTextBox.Text == "September")
            {
                memorableDay = 11;
            }
            else if (monthTextBox.Text == "October")
            {
                memorableDay = 10;
            }
            else if (monthTextBox.Text == "November")
            {
                memorableDay = 9;
            }
            else if (monthTextBox.Text == "December")
            {
                memorableDay = 12;
            }
            // Now we can find how far from the actual day the memorable day is
            // and then find (as an integer value) what day of the week the actual day is.

            if (inputDay < memorableDay)
            {
                differenceInDays = (memorableDay - inputDay) % 7;
                actualDay = doomsday - differenceInDays;

            }
            else if (inputDay > memorableDay)
            {
                differenceInDays = (inputDay - memorableDay) % 7;
                actualDay = doomsday + differenceInDays;
            }
            else actualDay = doomsday;

            // Now, with the integer version of the day of the week, the integer can be
            // translated into the day of the week as a word.

            if (actualDay == -7 || actualDay == 0 || actualDay == 7)

            {
                outputLabel.Text = "Sunday";
            }
            else if (actualDay == -6 || actualDay == 1 || actualDay == 8)
            {
                outputLabel.Text = "Monday";
            }
            else if (actualDay == -5 || actualDay == 2 || actualDay == 9)
            {
                outputLabel.Text = "Tuesday";
            }
            else if (actualDay == -4 || actualDay == 3 || actualDay == 10)
            {
                outputLabel.Text = "Wednesday";
            }
            else if (actualDay == -3 || actualDay == 4 || actualDay == 11)
            {
                outputLabel.Text = "Thursday";
            }
            else if (actualDay == -2 || actualDay == 5 || actualDay == 12)
            {
                outputLabel.Text = "Friday";
            }
            else if (actualDay == -1 || actualDay == 6 || actualDay == 13)
            {
                outputLabel.Text = "Saturday";

            }
        }
    }
}
