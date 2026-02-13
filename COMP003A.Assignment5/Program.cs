using System.Xml.Serialization;

namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

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

                Console.Write("Would you like to run the program again? y/n");

                string answer = Console.ReadLine();

                if (answer != "yes" && answer != "y")
                {
                    running = false;
                }
                Console.WriteLine("");
            }

            Console.WriteLine("end of session");

        }
        static void DisplayMenu()
        {
            Console.WriteLine("This is the introduction menu to this program.");
        }
        static void UserInput(string inputName, int inputAge)
        {
            Console.WriteLine($"Name: {inputName}. Age: {inputAge}.");
        }
        static int DoubleCalculation (int inputNum1)
        {
            int result = inputNum1 * 2;

            return result;
        }
    }
}
