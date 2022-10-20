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
// Version: 1.1 
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



        private void sortDataButton_Click(object sender, EventArgs e)
        {

        }

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
    }
}
