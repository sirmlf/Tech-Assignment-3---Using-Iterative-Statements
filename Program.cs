using System;

namespace Tech_Assignment_3___Using_Iterative_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Double usd, val;
            val = .792367;
            //Ask user to input first value
            Console.Write("Please enter a value between 5 and 25: ");
            /* Using a try catch to validate the input of 5 to 25.  If the value is not within 5 to 25, an error message will display
            */
            try
            {
                //Gather the input from the user
                string input = Console.ReadLine();
                //Used to perform iterative statements and parsed as an integer
                int value_of_input = int.Parse(input);
                /*
                    If/Else statement to test the user input and determine what will execute based on the value input
                */
                //If value is between 5 and 25, execute for loop
                if ((value_of_input > 4) && (value_of_input <= 25))
                {
                    Console.WriteLine("Executing");
                    //For Loop
                    for (int i = 0; i < 201; i++)
                    {
                        Console.WriteLine("Conversion Report: ");
                        while (i < 201)
                        {

                            usd = i * val;
                            Console.WriteLine("{0} CAD = {1} USD",
                            i, usd);
                            i += value_of_input;

                        }

                    }
                    Console.WriteLine("Press any key to exit the program: ");
                    //Pause program and have  user press key to close program
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Please enter a value between 5 and 25 and try again ...");
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }

            } //End of try statement
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            } //End of catch
        } //End of main
    }
} //end of class

