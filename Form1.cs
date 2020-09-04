using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SNG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Write to file
        protected void checkBox1_CheckChanged(object sender, EventArgs e)
        {
            WriteToFileBox.Enabled = checkBox1.Checked;
        }
        private void GenerateSerialButton_Click(object sender, EventArgs e)
        {
             // Number of digits required from dec to int for logic
             int numOfChars = Convert.ToInt32(numOfDigitsUpDown.Value);

             // Number of Chunks required from dec to int for logic 
             int numOfChunks = Convert.ToInt32(numOfChunksUpDown.Value);

             //Number of lines required from dec to int for logic.
             int numOfLines = Convert.ToInt32(numofLinesUpDown.Value);

            // Instant Error Catching
            if (numOfDigitsUpDown.Value == 0)
            {
                MessageBox.Show("Please enter # of digits per chunk.");
                return;
            }
            else if (numOfChunksUpDown.Value == 0)
            {
                MessageBox.Show("Please enter the number of chunks/groups you want.");
                return;
            }

            if (checkBox1.Checked = true && numOfLines != 0)
            {
                writeToFile(numOfChars, numOfChunks, numOfLines);
            }

            // Generate Serials into a list as big as the amount of chunks
            List<string> genSerial = new List<string>();
             int i = 0;
             while (i < numOfChunks)
             {
                 genSerial.Add(RandomString(numOfChars));
                 i++;
             }

             // Transform the list into an array
             string[] badSerialArr = genSerial.ToArray();

             // Transform array into string while joining with "-"
             string badSerialS = String.Join("-", badSerialArr);

             // Print the finished string into Generated text box.
             genSerialsBox.Text = badSerialS;
         
        }
        private static readonly Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        // Write random serial numbers to a file called "serials.txt"
        public static void writeToFile(int numOfChars, int numOfChunks, int numOfLines)
        {
            int n = 0;
            while (n < numOfLines)
                do
                {
                    // Generate Serials into a list as big as the amount of chunks
                    List<string> genSerial = new List<string>();
                    int i = 0;
                    while (i < numOfChunks)
                    {
                        genSerial.Add(RandomString(numOfChars));
                        i++;
                    }

                    // Transform the list into an array
                    string[] badSerialArr = genSerial.ToArray();

                    // Transform array into string while joining with "-"
                    string badSerialS = String.Join("-", badSerialArr);

                    using (StreamWriter w = File.AppendText("serials.txt"))
                    {
                        w.WriteLine(badSerialS);
                    }
                    n++;
                } while (n < numOfLines);
        }
    }
}
