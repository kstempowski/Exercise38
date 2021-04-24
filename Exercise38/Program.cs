using System;

namespace Exercise37
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                //Create an array of doubles that holds 5 values.
                double[] myArray = new double[5];

                //a loop. If int i is zero, and i is less than 5 increase i by 1
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Please enter number.");
                    //Convert the input values to doubles
                    myArray[i] = Convert.ToDouble(Console.ReadLine());

                }
                double average = (myArray[0] +
                                  myArray[1] +
                                  myArray[2] +
                                  myArray[3] +
                                  myArray[4])/5;

                //Output the average of the array as a double.
                Console.WriteLine($"The average of the entered numbers is {average}");

                //Loop back if the user selects y, all other selections will terminate the program.
                Console.WriteLine("Would you like to input another set of numbers? y/n");

                string answer = Console.ReadLine().ToLower();

                if(answer == "y")
                {
                    repeat = true;
                }
                else
                {
                    Console.WriteLine("Goodbye.");
                    repeat = false;
                }
            }
        }
    }
}
