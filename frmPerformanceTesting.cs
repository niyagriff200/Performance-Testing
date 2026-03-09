using System.Diagnostics;

namespace Performance_Testing
{
    public partial class frmPerformanceTesting : Form
    {

        private int arraySize; //arraySize - will take the value from the numUpDown
        private int[] arrayTest; // arrayTest - will be used to store the array for the user

        public frmPerformanceTesting()
        {
            InitializeComponent();
        }



        private void btnGenerate_Click(object sender, EventArgs e)
        {
            arraySize = (int)numArrayNumber.Value; //place the numUpDown value in the arraySize
            arrayTest = new int[arraySize]; //make a new array and make it the arraySize

            Random rng = new Random(); //to get a random number 
            Stopwatch timer = new Stopwatch(); //to time how long it takes

            timer.Start(); //start the timer

            for (int i = 0; i < arrayTest.Length; i++)
            {
                arrayTest[i] = rng.Next(1, 101); //pick a random number between 1 and 100 and place in the arrayTest
            }

            timer.Stop(); //stop the timer
            lblGenerateTime.Text = timer.Elapsed.TotalMilliseconds + "ms"; //place the time elapsed in Milliseconds in the GenerateTime label

            btnSort.Enabled = true; //enable the Sort button
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (arrayTest == null)
            {
                return; //(extra check) it will crash if the user tries to sort an array that doesn't exist yet
            }
            
            Stopwatch timer = new Stopwatch(); //to time how long it takes

            timer.Start();
            
            Array.Sort(arrayTest); //sort the array in order from smallest number to largest

            timer.Stop();

            lblSortTime.Text = timer.Elapsed.TotalMilliseconds + "ms"; //place the time elapsed in milliseconds in the GenerateTime label
        }
    }
}
