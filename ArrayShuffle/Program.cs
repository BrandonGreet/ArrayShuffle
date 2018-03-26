/* This program creates an array of 10,000 randomly assigned integers then
 * saves to a txt file.
 */
using System;
using System.IO;

namespace ArrayShuffle
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Initializing
            int[] bigArray = new int[10000];
            Random rng = new Random();
            StreamWriter writer = new StreamWriter("/Users/BrandonGreet/Desktop/bigArray.txt");

            //Creates a sorted list
            for (int i = 0; i < bigArray.Length; i++)
            {
                bigArray[i] = i + 1;
            }

            //Shuffles
            int tempIndex1;
            int tempIndex2;
            int tempValue;
            for (int i = 0; i < 10000; i++)
            {
                tempIndex1 = rng.Next(0, bigArray.Length);
                tempIndex2 = rng.Next(0, bigArray.Length);
                tempValue = bigArray[tempIndex1];

                bigArray[tempIndex1] = bigArray[tempIndex2];
                bigArray[tempIndex2] = tempValue;
            }

            //Writes to save file
            for (int i = 0; i < 10000; i++)
            {
                writer.WriteLine(bigArray[i]);
                Console.WriteLine(bigArray[i]);
            }
            writer.Close();
        }
    }
}
