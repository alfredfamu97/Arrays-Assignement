/*
 Author: Alfred Williams
 Date: 2/5/20
 Comments: This C# Console application code demonstrates the use of
           Arrays after getting input from users. */

using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Handle errors
            try
            {
                // Display informative message to the user.
                Console.WriteLine("Populate an array with integers");
                Console.WriteLine();
                Console.WriteLine("Iterate through the elements in the array");
                Console.WriteLine("_________________________________________");

                // To declare and initialize the array 
                int[] numbers = new int[25];
                int i, j;

                //Initialize elements an array

                for (i = 0; i < 25; i++)
                {
                    numbers[i] = i + 1;

                }

                // Display message with array value
                for (j = 0; j < 25; j++)
                {
                    Console.WriteLine("Element[{0}] = {1}", j, numbers[j]);
                
                    
                }
                Console.WriteLine("_________________________________________");
                // Display message after element values have been displayed 

                Console.WriteLine();
                Console.WriteLine("The values should be displayed! ");

                // Display message to inform user of exit.

                Console.WriteLine();
                Console.WriteLine("Press any key to exit the program...");

                // Pause the program and wait for the user to press a key to terminate.
                Console.ReadKey(true);
            }
            catch
            {
                // Pause the program and wait for the user to press a key to terminate.
                Console.ReadKey(true);
            }
        }
    }
}



