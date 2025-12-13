namespace ConsoleAppCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
            int option = int.Parse(Console.ReadLine());
        }

        static void ShowMenu()
        {
            Console.WriteLine(
                "Hello user, choose option:\n" +
                "1. Add two numbers\n" +
                "2. Subtract two numbers\n" +
                "3. Multiply two numbers\n" +
                "4. Divide two numbers\n" +
                "5. Check number for even\n" +
                "6. Calculate percentage from number\n" +
                "7. Get square root from number\n" +
                "8. Get power of number"
            );
        }

    }
}
