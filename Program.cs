// Henrique Correa 
//ISM4300.901S20

using System;

namespace Class_Project_3_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for user input.
            Console.Write("Please, enter your name: ");

            // To manage input errors. 
            try
            {
                // Read user's input
                string name = Console.ReadLine();

                // Calling the method.
                What_is_your_name(name);
            }
            catch
            {
                // Display error if invadlid input.
                Console.WriteLine("You have entered an invalid input!");
            }
        }

        // Customer method called User_Name
        private static string What_is_your_name(string my_name)
        {
            // Add space
            Console.WriteLine("");
            // Display Hello and user's name in a message.
            Console.Write("Hello " + my_name + "!" + "\n");
            Console.WriteLine("Please, press any key to exit the console.");
            Console.ReadKey(true);

            // Return the value.
            return my_name;
        }
    }
}
