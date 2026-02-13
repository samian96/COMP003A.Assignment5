using System.Xml.Serialization;

namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            do
            {

                int mainValue = 15;

                DisplayMenu();

                Console.Write("Please enter your name: ");
                string name = Console.ReadLine();
                Console.WriteLine("\n");

                Console.Write("Please enter your age: ");
                string age = Console.ReadLine();
                Console.WriteLine("\n");

                Console.Write("Please enter a number: ");
                string num1 = Console.ReadLine();
                Console.WriteLine("\n");


                if (int.TryParse(age, out int inputAge))
                {
                    UserInput(name, inputAge);

                    int finalVal = DoubleCalculation(mainValue);

                    Console.WriteLine($"Original Value: {mainValue}.");
                    Console.WriteLine("\n");

                    Console.WriteLine($"Original Value doubled: {finalVal}");
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("Invalid number input.");
                    Console.WriteLine("\n");
                }

            } while (running == true);

            Console.WriteLine("Program ended");

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
