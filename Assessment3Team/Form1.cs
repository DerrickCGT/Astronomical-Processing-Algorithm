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
// Version: 1.3 
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

        static int arraySize = 24;
        int[] myArray = new int[arraySize];


        private void randomDataButton_Click(object sender, EventArgs e)
        {
            int maxRandom = 99;
            int minRandom = 10;

            Random random = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                myArray[i] = random.Next(minRandom, maxRandom);
            }
            displayArray();
        }

        private void displayArray()
        {
            dataListBox.Items.Clear();
            for (int i = 0; i < arraySize; i++)
            {
                dataListBox.Items.Add((i + 1) + ". " + myArray[i]);
            }
        }

        private void searchDataButton_Click(object sender, EventArgs e)
        {
           
            if (!(string.IsNullOrEmpty(dataTextBox.Text)))
            {
                int target;
                var low = 0;
                var high = arraySize - 1;

                // Tryparse
                if (Int32.TryParse(dataTextBox.Text, out target))
                {

                    while (low <= high)
                    {
                        var mid = (low + high) / 2;
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
                    MessageBox.Show("Error! That is not a valid input.");
                }
            }

        }

        private void editDataButton_Click(object sender, EventArgs e)
        {
            int target;
            
            if (dataListBox.SelectedIndex >= 0)
            {

                if (!(string.IsNullOrEmpty(dataTextBox.Text)))
                {
                    if (Int32.TryParse(dataTextBox.Text, out target))
                    {

                        if (!myArray.Contains(target))
                        {
                            myArray[dataListBox.SelectedIndex] = int.Parse(dataTextBox.Text);
                            dataTextBox.Focus();
                            displayArray();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error! That is not a valid input.");
                    }
                }
            }
        }

        private void sortDataButton_Click(object sender, EventArgs e)
        {
            
            bool didSort;

            for (int i = 0; i < arraySize - 1; i++)
            {
                didSort = false;
                var limit = arraySize - i - 1;
                for (int j = 0; j < limit; j++)
                {
                    if (myArray[j] > myArray[j + 1])
                    {
                        var temp = myArray[j];
                        myArray[j] = myArray[j + 1];
                        myArray[j + 1] = temp;
                        didSort = true;
                    }
                }
                if (didSort == false)
                {
                    break;
                }
            }
            displayArray();
            
        }

        private void dataTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && !char.IsControl(ch))
            {
                e.Handled = true;
            }
        }
    }
}
