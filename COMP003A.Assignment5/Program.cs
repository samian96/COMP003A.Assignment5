using System.Xml.Serialization;

namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            /*The main method controls most of the programming and grabs from the other methods to clean up the code as well as 
             *improving readability of the whole program. This makes it easier to read and adjust if done right.
             * This could be a lot cleaner I am just not fully sure what to do
             */
            DisplayMenu();

            while (running)
            {

                int mainValue = 15;

                Console.Write("Please enter your name: ");
                string name = Console.ReadLine();

                Console.Write("Please enter your age: ");
                string age = Console.ReadLine();


                Console.Write("Please enter a number: ");
                string num1 = Console.ReadLine();
                Console.WriteLine("\n");


                if (int.TryParse(age, out int inputAge))
                {
                    UserInput(name, inputAge);

                    int finalVal = DoubleCalculation(mainValue);

                    Console.WriteLine($"Original Value: {mainValue}.");


                    Console.WriteLine($"Original Value doubled: {finalVal}");
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("Invalid number input.");
                    Console.WriteLine("\n");
                }

                Console.Write("Would you like to run the program again? y/n: ");

                string answer = Console.ReadLine();

                if (answer != "yes" && answer != "y")
                {
                    running = false;
                }
                Console.WriteLine("");
            }

            Console.WriteLine("end of session");

        }
        // this method grabs the string to display everytime the program start, or is repeated if the program is looped.
        static void DisplayMenu()
        {
            Console.WriteLine("This is the introduction menu to this program.");
        }
        // this method takes the input of the name and age to display once the user enters information.
        static void UserInput(string inputName, int inputAge)
        {
            Console.WriteLine($"Name: {inputName}. Age: {inputAge}.");
        }
        // this input is different than void, as it uses the int to calculate and multiply the users input by 2, instead of being cluttered in the main.
        // important, when writing methods you must go in order of when it is called, or it could send error codes or fail. Order is important
        static int DoubleCalculation (int inputNum1)
        {
            int result = inputNum1 * 2;

            return result;
        }
    }
}
