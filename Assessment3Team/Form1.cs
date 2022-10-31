using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Team Name: Big Chungus Da Third
// Team Members: Lewis, Jarryd, Derrick
// Date: 20/10/2022 
// Version: 1.3.1
// Name of Program: Astronomical Processing
// Function: Record the interaction of neutrino hourly
// Inputs/Processes/Output

namespace Assessment3Team
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Store astronomical data
        static int arraySize = 24;
        int[] myArray = new int[arraySize];

        /// <summary>
        /// Fills the array with random data.
        /// Random data is chosen within the range 10-99 inclusive
        /// </summary>
        private void randomDataButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            // Define min and max random value to choose
            int maxRandom = 99;
            int minRandom = 10;

            // Fill the array with random values
            for (int i = 0; i < arraySize; i++)
            {
                myArray[i] = random.Next(minRandom, maxRandom);
            }

            // Display the array to the listbox
            displayArray();
        }

        /// <summary>
        /// Forces an update of the dataListBox data source.
        /// </summary>
        private void displayArray()
        {
            dataListBox.DataSource = null;
            dataListBox.DataSource = myArray;
        }

        /// <summary>
        /// Searches for a given target value within the array.
        /// Selects he appropriate item in the dataListBox if
        /// the target is found.
        /// </summary>
        private void binarySearchDataButton_Click(object sender, EventArgs e)
        {
            // Check if a target is given
            if (!(string.IsNullOrEmpty(dataTextBox.Text)))
            {
                // The target to search for
                int target;

                // Convert the given input to an integer value
                if (Int32.TryParse(dataTextBox.Text, out target))
                {

                    // Upper and lower bound for binary search
                    int low = 0;
                    int high = arraySize - 1;
                    int mid;

                    // Perform binary search
                    while (low <= high)
                    {
                        // Calculate mid point
                        mid = (low + high) / 2;

                        // Target found
                        if (myArray[mid] == target)
                        {
                            MessageBox.Show("Found " + dataTextBox.Text + " !");
                            dataListBox.SelectedIndex = mid;
                            return;
                        }
                        else if (target > myArray[mid])
                        {
                            low = mid + 1;
                        }
                        else if (target < myArray[mid])
                        {
                            high = mid - 1;
                        }
                    }
                    MessageBox.Show("Not Found!");
                }
                else
                {
                    // Failed to convert input
                    MessageBox.Show("Error! That is not a valid input.");
                }
            }

        }

        /// <summary>
        /// Modifies a selected value from dataListBox with a
        /// given user input value
        /// </sumamry>
        private void editDataButton_Click(object sender, EventArgs e)
        {
            // If an item is selected
            if (dataListBox.SelectedIndex >= 0)
            {
                // If an input is given
                if (!(string.IsNullOrEmpty(dataTextBox.Text)))
                {
                    int target;

                    // Convert the input to an integer value
                    if (Int32.TryParse(dataTextBox.Text, out target))
                    {
                        // Overwrite the given value with the new input value
                        myArray[dataListBox.SelectedIndex] = target;
                        dataTextBox.Focus();
                        displayArray();
                    }
                    else
                    {
                        // Failed to convert input
                        MessageBox.Show("Error! That is not a valid input.");
                    }
                }
            }
        }

        private void sortDataButton_Click(object sender, EventArgs e)
        {
            // Track if a sort was performed
            bool didSort;
            int temp;

            // Perform bubble sort
            for (int i = 0; i < arraySize - 1; i++)
            {
                // No sort has been performed yet
                didSort = false;
                var limit = arraySize - i - 1;

                // Sort inner range
                for (int j = 0; j < limit; j++)
                {
                    // If neighbouring values are unsorted, sort
                    if (myArray[j] > myArray[j + 1])
                    {
                        temp = myArray[j];
                        myArray[j] = myArray[j + 1];
                        myArray[j + 1] = temp;
                        didSort = true;
                    }
                }

                // If no sort performed, finished
                if (didSort == false)
                {
                    break;
                }
            }

            displayArray();

        }

        /// <summary>
        /// Cancel invalid input char events
        /// </summary>
        private void dataTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            // If character is not digit or a control character, ignore it
            if (!char.IsDigit(ch) && !char.IsControl(ch))
            {
                e.Handled = true;
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void midExtremeButton_Click(object sender, EventArgs e)
        {
            int min = Min(myArray);
            int max = Max(myArray);
            double sum = (double)(max + min) / 2;
            textBox1.Text = sum.ToString("0.00");
        }

        /// <summary>
        ///  Sequential seach or linear search.
        /// </summary>
        private void sequentialSearchDataButton_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(dataTextBox.Text))
            {
                int target;

                // Convert input into a integer
                if (Int32.TryParse(dataTextBox.Text, out target))
                {
                    int N = myArray.Length;
                    // iterates through the array.
                    for (int i = 0; i < N; i++)
                    {
                        // compares input with each iteration.
                        if (myArray[i] == target)
                        {
                            // prints if found 
                            MessageBox.Show("Found");
                            return;
                        }

                    }
                    // prints if not found
                    MessageBox.Show("Not Found");
                    return;


                }


            }
            else
            {
                MessageBox.Show("You have not enter anyting to search for.");
            }

        }



        /// <summary>
        /// Minimum of the array.
        /// </summary>
        public int Min(int[] myArray)
        {

            int min = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < min)
                {
                    min = myArray[i];
                }
            }
            return min;
        }

        /// <summary>
        /// Maximum of the array. 
        /// </summary>
        public int Max(int[] myArray)
        {
            int max = myArray[0];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > max)
                {
                    max = myArray[i];
                }
            }
            return max;
        }

        /// <summary>
        /// The average of every number in the array
        /// </summary>
        private void averageButton_Click(object sender, EventArgs e)
        {
            double sum = 0;

            if (myArray.Length == 0)
            {
                textBox1.Text = "0";
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];
            }

            double mathSum = sum / myArray.Length;
            textBox1.Text = mathSum.ToString("0.00");
        }

        /// <summary>
        /// The number between the min number and max number.
        /// </summary>
        private void rangeButton_Click(object sender, EventArgs e)
        {
            int min = Min(myArray);
            int max = Max(myArray);
            int sum = max - min;
            textBox1.Text = sum.ToString();
        }

        private void modeButton_Click(object sender, EventArgs e)
        {
            int max = 0;
            int[] count = new int[100];

            foreach (int i in myArray)
            {
                count[i]++;
                if (count[i] > count[max])
                {
                    max = i;
                }
            }
            if (count[max] == 1)
            {
                textBox1.Text = String.Join(",", myArray);
            }
            else
            {
                string result = "";
                for (int i = 0; i < count.Length; i++)
                {
                    if (count[i] == count[max])
                    {
                        result += i.ToString() + ", ";
                    }
                }
                textBox1.Text = result.Substring(0, result.Length - 2);
            }
        }
    }
}
