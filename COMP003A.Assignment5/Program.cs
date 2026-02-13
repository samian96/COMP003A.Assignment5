namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mainValue = 15;

            DisplayMenu();

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Please enter your age: ");
            string age = Console.ReadLine();

            if (int.TryParse(age, out int inputAge))
            {
                UserInput(name, inputAge);
            }
            else
            {
                Console.WriteLine("Invalid number input.");
            }

            Console.Write("Please enter a number: ");
            string num1= Console.ReadLine();

            int finalVal = DoubleCalculation(mainValue);

            Console.Write($"Original Value: {mainValue}.");

            Console.Write($"Original Value times 2: {finalVal}");

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
