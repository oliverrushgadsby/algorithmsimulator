using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmSimulator
{
    public partial class Form1 : Form
    {
        public int[] unsortedArray;
        public int[] sortedArray;

        
        public Form1()
        {
            InitializeComponent();
        }
        #region Bubble Sort
        // THE FOLLOWING IS FOR THE BUBBLE SORT ALGORITHM
        //  <BUBBLE SORT>


        // Bubble sort code to sort the random array
        private void BubbleSort(int[] x)
        {
            bool exchanges;

            do
            {
                exchanges = false;
                for (int i = 0; i < x.Length - 1; i++)
                {
                    if (x[i] > x[i + 1])
                    {
                        // Exchange elements
                        int temp = x[i];
                        x[i] = x[i + 1];
                        x[i + 1] = temp;
                        exchanges = true;
                    }
                }
            } while (exchanges);

        }

        // when pressed, a random array is created
        private void buttonGenerateArrayBubble_Click(object sender, EventArgs e)
        {
            unsortedArray = GetRandomIntArray();
            textBoxUnsortedArray.Text = "";
            textBoxSortedArray.Text = "";

            // When button is pressed, displays the values of the random/unsorted array
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                textBoxUnsortedArray.Text += unsortedArray[i].ToString() + ", ";
            }
        }

        // when pressed, a nearly sorted array is created
        private void buttonNearlySortedBubble_Click(object sender, EventArgs e)
        {
            unsortedArray = GetNearlySortedIntArray();
            textBoxUnsortedArray.Text = "";
            textBoxSortedArray.Text = "";

            // When button is pressed, displays the values of the nearly sorted array
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                textBoxUnsortedArray.Text += unsortedArray[i].ToString() + ", ";
            }
        }

        // When Pressed, reverse sorted array is created
        private void buttonReverseSortedBubble_Click(object sender, EventArgs e)
        {
            unsortedArray = GetReversedSortedIntArray();
            textBoxUnsortedArray.Text = "";
            textBoxSortedArray.Text = "";

            // When button is pressed, displays the values of the reverse sorted array
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                textBoxUnsortedArray.Text += unsortedArray[i].ToString() + ", ";
            }
        }

        //Displays unsorted array, then the array when sorted with time taken for bubble sort
        private void buttonFreeRunBubble_Click(object sender, EventArgs e)
        {

            CHPerfTimer timer = new CHPerfTimer();
            textBoxSortedArray.Text = "";

            // Times how long the Bubble sort takes 
            timer.Start();
            labelTimerResult.Text = "Time Taken to sort the array is: ";
            BubbleSort(unsortedArray);
            timer.Stop();


            // Displays how long the bubble sort took
            labelTimerResult.Text = "Time Taken to sort the array is: " + timer.Duration.ToString() + " seconds";
            // Displays the array after it has been sorted
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                textBoxSortedArray.Text += unsortedArray[i].ToString() + ", ";
            }
        }

        
        #endregion 
        private void Form1_Load(object sender, EventArgs e)
        {
            //  NA  //
        }

        // THE FOLLOWING IS FOR THE LINEAR SEARCH ALGORITHM
        //  <LINEAR SEARCH>
        private int LinearSearch(int[] x)
        {
            unsortedArray = GetNearlySortedIntArray();

            int selectedItem = int.Parse(comboBoxArrayList.SelectedItem.ToString());
            for (int i = 0; i < unsortedArray.Length; i++)

                if (unsortedArray[i] == selectedItem)

                    return i;
            return -1;

        }

        // When button is pressed,
        // a nearly sorted array is added to the combo box
        private void buttonSearchForLinear_Click(object sender, EventArgs e)
        {

            labelTimeTakenLinear.Text = "The Time taken to search is: ";
            labelNumberLocation.Text = "The selected number is in index ";

            //Inserts the unsorted array into the combo box to select
            comboBoxArrayList.DataSource = GetNearlySortedIntArray();

        }


        // When pressed, a completely random
        // array is made and put into the combo box
        private void buttonRandomArrayLinear_Click(object sender, EventArgs e)
        {
            labelTimeTakenLinear.Text = "The Time taken to search is: ";
            labelNumberLocation.Text = "The selected number is in index ";

            //Inserts the unsorted array into the combo box to select
            comboBoxArrayList.DataSource = GetRandomIntArray();
        }

        private void buttonReverseSortedLinear_Click(object sender, EventArgs e)
        {
            labelTimeTakenLinear.Text = "The Time taken to search is: ";
            labelNumberLocation.Text = "The selected number is in index ";

            //Inserts the unsorted array into the combo box to select
            comboBoxArrayList.DataSource = GetReversedSortedIntArray();
        }

        // When free run button is pressed,
        // the linear search algorithm is started and timed
        // then the duration of the search is displayed
        private void buttonFreeRunLinear_Click(object sender, EventArgs e)
        {
            CHPerfTimer timer = new CHPerfTimer();


            // Times how long the linear search takes
            timer.Start();
            labelTimeTakenLinear.Text = "The Time taken to search is: ";
            LinearSearch(unsortedArray);
            timer.Stop();

            labelTimeTakenLinear.Text = "The Time taken to search is: " + timer.Duration.ToString() + " seconds";
            labelNumberLocation.Text = "The selected number is in index " + comboBoxArrayList.SelectedIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }



        //  </LINEAR SEARCH>
        

        // THE FOLLOWING IS FOR THE SELECTION SORT ALGORITHM


        // Selection Sort Algorithm
        private void linearSearch(int[] x)
        {
            int[] array = unsortedArray;
            int count = 20;

            int temp, smallest;

            for (int i = 0; i < count; i++)
            {
                smallest = i;
                for (int j = i + 1; j < count; j++)
                {
                    if (array[j] < array[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = array[smallest];
                array[smallest] = array[i];
                array[i] = temp;
            }

        }

        // When pressed, begins the array, times how long it takes,
        // and displays the time it took aswell as displays the sorted array
        private void buttonFreeLinear_Click(object sender, EventArgs e)
        {
            CHPerfTimer timer = new CHPerfTimer();
            textBoxSortedArray.Text = "";

            textBoxUnsortedArray.Text = "";
            textBoxSortedArray.Text = "";

            // Times how long the Bubble sort takes to sort the selected unsorted array
            timer.Start();
            labelTimeLinear.Text = "Time Taken to sort the array is: ";
            linearSearch(unsortedArray);
            timer.Stop();


            // Displays how long the bubble sort took
            labelTimeLinear.Text = "Time Taken to sort the array is: " + timer.Duration.ToString() + " seconds";
            // Displays the array after it has been sorted
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                textBoxSortedLinear.Text += unsortedArray[i].ToString() + ", ";
            }


        }

        // When pressed, displays a random, unsorted array to be sorted
        private void buttonRandomArraySelection_Click(object sender, EventArgs e)
        {
            unsortedArray = GetRandomIntArray();
            textBoxUnsortedLinear.Text = "";
            textBoxSortedLinear.Text = "";

            // When button is pressed, displays the values of the random/unsorted array
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                textBoxUnsortedLinear.Text += unsortedArray[i].ToString() + ", ";
            }
        }

        // When pressed, displays a nearly sorted array to be sorted
        private void buttonNearlySortedSelection_Click(object sender, EventArgs e)
        {

            unsortedArray = GetNearlySortedIntArray();
            textBoxUnsortedLinear.Text = "";
            textBoxSortedLinear.Text = "";

            // When button is pressed, displays the values of the random/unsorted array
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                textBoxUnsortedLinear.Text += unsortedArray[i].ToString() + ", ";
            }
        }

        private void buttonReverseSortedSelection_Click(object sender, EventArgs e)
        {
            unsortedArray = GetReversedSortedIntArray();
            textBoxUnsortedLinear.Text = "";
            textBoxSortedLinear.Text = "";

            // When button is pressed, displays the values of the random/unsorted array
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                textBoxUnsortedLinear.Text += unsortedArray[i].ToString() + ", ";
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // NA // 
        }

        // THE FOLLOWING IS FOR THE BINARY SEARCH TAB

        private int binarySearch(int[] x)
        {
            x = unsortedArray;
            int minNum = 0;
            int maxNum = x.Length -1;
            int key = 0;

            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;

                if (key == x[mid])
                {
                    return ++mid;
                }
                else if (key < x[mid])
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
                
            }
            return 0;

           
        }


        // when pressed, the algorithm searches for the specified number
        private void buttonSearchForBinary_Click(object sender, EventArgs e)
        {
            CHPerfTimer timer = new CHPerfTimer();

            unsortedArray = GetSortedIntArray();

            // times how long the binary search takes
            timer.Start();
            labelTimeTakenBinary.Text = "The Time taken to search is: ";
            binarySearch(unsortedArray);
            timer.Stop();
            // displays the time the binary search took, along with the index position the selected number is in
            labelTimeTakenBinary.Text = "The Time taken to search is: " + timer.Duration.ToString() + " seconds";
            labelLocationBinary.Text = "The selected number is in index " + comboBoxBinaryList.SelectedIndex;
        }

        private void buttonGenerateArrayBinary_Click(object sender, EventArgs e)
        {

            labelTimeTakenBinary.Text = "The Time taken to search is: ";
            labelLocationBinary.Text = "The selected number is in index ";

            //Inserts the sorted array into the combo box to select
            comboBoxBinaryList.DataSource = GetSortedIntArray();
        }
    }
 }

    


        
    

