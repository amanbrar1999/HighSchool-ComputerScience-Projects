using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace findingDayOfTheYear
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        // calculating anchor day
        private int calculateAnchorDay(int year)
        {
            // 0,5,3,2 are all specific for different centuries

            int firstTwoDigitsOfYear = year / 100;

            int anchorDay = 0;

            if ((firstTwoDigitsOfYear - 18) % 4 == 0) // if this condition is true, then firstTwoDigitsOfYEar = 18 + 4x 
            {                                           //{x belongs to the set of integers}, so it follows same anchor day as 18
                anchorDay = 5;                          
            }
            else if ((firstTwoDigitsOfYear - 19) % 4 == 0) // similar logic, but for 19
            {
                anchorDay = 3;
            }
            else if ((firstTwoDigitsOfYear - 20) % 4 == 0) // similar logic, but for 20
            {
                anchorDay = 2;
            }
            else if ((firstTwoDigitsOfYear - 21) % 4 == 0) // similar logic, but for 21
            {
                anchorDay = 0;
            } // end of if statement

            return anchorDay;

        }// end of procedure

        //calculate the doomsday
        private int calculateDoomsday(string year)
        {
            int lastTwoDigitsOfYear = Convert.ToInt32(year) % 100; // taking remainder of the year divided by 100 gives us the last 2 digits we need
            int doomsday = 0;

            doomsday = (lastTwoDigitsOfYear / 12) + (lastTwoDigitsOfYear % 12) + ((lastTwoDigitsOfYear % 12) / 4) + calculateAnchorDay(Convert.ToInt32(year)) ;
            // this is the doomsday algorithm                                                                       must call upon anchor day procedure in this
           
            
            while (doomsday > 6) // keep subtracting 7 from 'doomsday' until you get a number between 0 and 6
            {
                doomsday -= 7;
            } // end of loop
    
            return doomsday;

        } // end of procedure


        // check if year is leap year
        // if it is leap year, return true, if not then return false
        private bool isLeapYear(int year)
        {
            if (year%4==0)
            {
                if (year%100==0 && year%400 != 0)
                {
                    return false;
                }
                else
                { return true; }
            }
            else
            { return false; }
        }

        // there is a special day of each month which has the same day of week as the special day of other months
        // for example, april 4th is ALWAYS the same day of the week as may 9th
        private int findingReferenceDay(int year,ComboBox comboBoxMonth)
        {
            
            int referenceDay = 0; // special days for each month which have the same day of the week every year
            

            
            // check which month is selected, depending on which month is selected give a specific value to 'referenceDay'
            if (comboBoxMonth.SelectedIndex == 0 )
            {
                    if (isLeapYear(year))
                    {
                        referenceDay = 4;
                    }
                    else
                    {
                        referenceDay = 3;
                    }
            }
            else if (comboBoxMonth.SelectedIndex == 1 && isLeapYear(year) )
            {
                referenceDay = 29;
            }
            else if (comboBoxMonth.SelectedIndex == 1 && isLeapYear(year)==false)
            {
                referenceDay = 28;
            }
            else if (comboBoxMonth.SelectedIndex == 2 )
            {
                referenceDay = 0;
            }
            else if (comboBoxMonth.SelectedIndex == 3 )
            {
                referenceDay = 4;   
            }
            else if (comboBoxMonth.SelectedIndex == 4 )
            {
                referenceDay = 9;
            }
            else if (comboBoxMonth.SelectedIndex == 5)
            {
                referenceDay = 6;
            }
            else if (comboBoxMonth.SelectedIndex == 6 )
            {
                referenceDay = 11;
            }
            else if (comboBoxMonth.SelectedIndex == 7 )
            {
                referenceDay = 8;
            }
            else if (comboBoxMonth.SelectedIndex == 8 )
            {
                referenceDay = 5;
            }
            else if (comboBoxMonth.SelectedIndex == 9 )
            {
                referenceDay = 10;
            }
            else if (comboBoxMonth.SelectedIndex == 10 )
            {
                referenceDay = 7;
            }
            else if (comboBoxMonth.SelectedIndex == 11 )
            {
                referenceDay = 12;
            } // end of if statement

            return referenceDay;
            
            
            
        } // end of procedure

        // knowing the day of the week of the special day in each month, we can exploit that to find the day of the week of the given date
        // by subtracting from special day until we reach the given day
        private string dayOfWeek(int referenceDay, int day, int year)
        {
            int indexOfDay = 0;
            // array stores the days of the week, under the proper index
            string[] dayOfTheWeek = new string[7] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            // using the referenceDay, count either forwards or backwards to get to the day that was entered
            if (day > referenceDay)
            {
                while (referenceDay < day)
                {
                    referenceDay += 7;
                }
                referenceDay -= 7; // subtract 7 because loop executes 1 extra time

                // at this point, reference day still has the same day of the week from the doomsdayAlgorithm, and now it is in
                // the same week as the given date, so this simple calculation can help us find the index of the given date
                indexOfDay = calculateDoomsday(Convert.ToString(year)) + (day - referenceDay);

                // the above calculation can potentially give values which are negative, however they have a corresponding value 
                // within the range of 0-6, so we adjust them to get this value
                if (indexOfDay < 0)
                { indexOfDay += 7; }
                else if (indexOfDay > 6)
                { indexOfDay -= 7; }

                return dayOfTheWeek[indexOfDay]; // return the value in the array which has the index we determined through calculations
            }
            else // the above code only works of the given day is greater then the special day, in the case that this is not true
                 //     we simply need to change up the code a little bit
            {
                while (referenceDay > day)
                {
                    referenceDay -= 7;
                }
                referenceDay += 7; // subtract 7 because loop executes 1 extra time
                indexOfDay = calculateDoomsday(Convert.ToString(year)) + (day - referenceDay);

                if (indexOfDay < 0)     
                { indexOfDay += 7; }
                else if (indexOfDay > 6)
                { indexOfDay -= 7; }

                return dayOfTheWeek[indexOfDay];
            }// end of if statement
        }

        private void changeDays(int year, ComboBox comboBoxDays, ComboBox comboBoxMonth)
        {
            int previousDay = comboBoxDays.SelectedIndex; // save the current date, so that it can be set back to this later

            comboBoxDays.Items.Clear();

                if (comboBoxMonth.SelectedIndex == 0 || // january
                    comboBoxMonth.SelectedIndex == 2 || // march
                    comboBoxMonth.SelectedIndex == 4 || // may
                    comboBoxMonth.SelectedIndex == 6 || // july
                    comboBoxMonth.SelectedIndex == 7 || // august
                    comboBoxMonth.SelectedIndex == 9 || // october
                    comboBoxMonth.SelectedIndex == 11) // december
                {
                    for (int x = 1; x <= 31; x++)
                    comboBoxDays.Items.Add(x);
                }
                else if (comboBoxMonth.SelectedIndex == 3 || // april
                    comboBoxMonth.SelectedIndex == 5 || // june
                    comboBoxMonth.SelectedIndex == 8 || // september
                    comboBoxMonth.SelectedIndex == 10) // november
                {
                    for (int x = 1; x <= 30; x++)
                    comboBoxDays.Items.Add(x);
                }
                else if (comboBoxMonth.SelectedIndex == 1) //february
                {

                    if (isLeapYear(year))
                    {
                        for (int x = 1; x <= 29; x++)
                        comboBoxDays.Items.Add(x);
                    }
                    else
                    {
                        for (int x = 1; x <= 28; x++)
                        comboBoxDays.Items.Add(x);
                    }
                }
            
            if (comboBoxDays.Items.Count >= previousDay + 1)
            {
                comboBoxDays.SelectedIndex = previousDay;
            }
            else
            {
                comboBoxDays.SelectedIndex = comboBoxDays.Items.Count - 1;
            }
            
        } // end of procedure


        private void Form1_Load(object sender, EventArgs e)
        {

            dayComboBox.DropDownStyle = ComboBoxStyle.DropDownList; // make it so people cannot type into the comboboxes
            monthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            currentDateLabel.Text = Convert.ToString(DateTime.Now); //display current date on the 'currentDateLabel'
            currentDateChangerTimer.Enabled = true; // enable the timer which updates the date and time every second
            yearNumericUpDown.Maximum = 1000000;  // set the limits for the numeric updown
            yearNumericUpDown.Minimum = 0;

            // display current date in the comboboxes and numeric updowns
            yearNumericUpDown.Value = DateTime.Now.Year; 
            monthComboBox.SelectedIndex = DateTime.Now.Month - 1;
            dayComboBox.SelectedIndex = DateTime.Now.Day - 1;


            outputLabel.Text = "Today is " + dayOfWeek(findingReferenceDay((int)yearNumericUpDown.Value, monthComboBox), Convert.ToInt32(dayComboBox.Text), (int)yearNumericUpDown.Value);

        } // end of event handler

        private void dayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           

                outputLabel.Text = "The Day of The Week is " + dayOfWeek(findingReferenceDay((int)yearNumericUpDown.Value,monthComboBox),Convert.ToInt32(dayComboBox.Text),(int)yearNumericUpDown.Value) ;

            
        } // end of event handler

        // update the current sate and time every second
       private void currentDateChangerTimer_Tick(object sender, EventArgs e)
        {
            currentDateLabel.Text = Convert.ToString(DateTime.Now); // every second, check the new date and time so that the label can be updated
        } // end of event handler

 
        private void yearNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            
            changeDays((int)yearNumericUpDown.Value, dayComboBox, monthComboBox);

            outputLabel.Text = "The Day of The Week is " + dayOfWeek(findingReferenceDay((int)yearNumericUpDown.Value, monthComboBox), Convert.ToInt32(dayComboBox.Text), (int)yearNumericUpDown.Value);
            
        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            changeDays((int)yearNumericUpDown.Value, dayComboBox, monthComboBox);
            
        }

        private void yearNumericUpDown_ValueChanged_1(object sender, EventArgs e)
        {
            
            changeDays((int)yearNumericUpDown.Value, dayComboBox, monthComboBox);

            if (monthComboBox.Text != "" && dayComboBox.Text != "")
            {
                outputLabel.Text = "The Day of The Week is " + dayOfWeek(findingReferenceDay((int)yearNumericUpDown.Value, monthComboBox), Convert.ToInt32(dayComboBox.Text), (int)yearNumericUpDown.Value);
            }
               
            
        }
    }
}
