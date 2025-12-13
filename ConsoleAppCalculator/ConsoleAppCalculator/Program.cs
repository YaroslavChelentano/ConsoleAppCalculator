namespace ConsoleAppCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    double[] numbersForAddition = EnterTwoNumbersFromConsole();
                    double sum = AddTwoNumbers(numbersForAddition[0], numbersForAddition[1]);
                    Console.WriteLine($"Result: {sum}");
                    break;
                case 2:
                    double[] numbersForSubract = EnterTwoNumbersFromConsole();
                    double sub = SubtractTwoNumbers(numbersForSubract[0], numbersForSubract[1]);
                    Console.WriteLine($"Result: {sub}");
                    break;
                case 3:
                    double[] numbersForMultiply = EnterTwoNumbersFromConsole();
                    double mul = MultiplyTwoNumbers(numbersForMultiply[0], numbersForMultiply[1]);
                    Console.WriteLine($"Result: {mul}");
                    break;
                case 4:
                    double[] numbersForDivision = EnterTwoNumbersFromConsole();
                    if (numbersForDivision[1] == 0)
                    {
                        Console.WriteLine("Second number can not be zero");
                    }
                    else
                    {
                        double div = DivideTwoNumbers(numbersForDivision[0], numbersForDivision[1]);
                        Console.WriteLine($"Result: {div}");
                    }
                    break;
                default:
                    Console.WriteLine("Wrong option. Choose again");
                    break;
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

            static double AddTwoNumbers(double firstNumber, double secondNumber)
            {
                return firstNumber + secondNumber;
            }

            static double SubtractTwoNumbers(double firstNumber, double secondNumber)
            {
                return firstNumber - secondNumber;
            }

            static double MultiplyTwoNumbers(double firstNumber, double secondNumber)
            {
                return firstNumber * secondNumber;
            }

            static double DivideTwoNumbers(double firstNumber, double secondNumber)
            {
                return firstNumber / secondNumber;
            }

            static double[] EnterTwoNumbersFromConsole()
            {
                Console.WriteLine("Enter first number:");
                double firstNumber = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                double secondNumber = double.Parse(Console.ReadLine());

                return new[] { firstNumber, secondNumber };
            }
        }
    }
}
