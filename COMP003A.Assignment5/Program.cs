namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Please enter your age: ");
            string age = Console.ReadLine();

        }
        static void DisplayMenu()
        {
            Console.WriteLine("This is the introduction menu to this program.");
        }
        static void UserInput(string name, int age)
        {
            
        }
    }
}
