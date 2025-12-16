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
                    case 5:
                        double numberToCheck = EnterSingleNumberFromConsole();
                        bool isEven = CheckForEven(numberToCheck);
                        Console.WriteLine(isEven ? "The number is even." : "The number is odd.");
                    break;
                    case 6:
                        double numberForPercentage = EnterSingleNumberFromConsole();
                        Console.WriteLine("Enter percentage to calculate:");
                        double percent = double.Parse(Console.ReadLine());
                        double percentageResult = CalculatePercentage(numberForPercentage, percent);
                        Console.WriteLine($"Result: {percentageResult}");
                    break;
                    case 7:
                        double numberForSqrt = EnterSingleNumberFromConsole();
                    if (numberForSqrt < 0)
                    {
                        Console.WriteLine("Cannot calculate square root of a negative number.");
                    }
                    else
                    {
                        double sqrtResult = GetSquareRoot(numberForSqrt);
                        Console.WriteLine($"Result: {sqrtResult}");
                    }
                    break;
                    case 8:
                        double baseNumber = EnterSingleNumberFromConsole();
                        Console.WriteLine("Enter power to raise the number to:");
                        double power = double.Parse(Console.ReadLine());
                        double powerResult = GetPower(baseNumber, power);
                        Console.WriteLine($"Result: {powerResult}");
                    break;
                    case 9:
                        double[] creditTotalAndMonths = EnterTwoNumbersFromConsole();
                        double averageCount = CalculateCreditAverage(creditTotalAndMonths[0], creditTotalAndMonths[1]);
                        Console.WriteLine($"Average credit transaction per month: {averageCount:F2}");
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
                    "8. Get power of number\n" +
                    "9. Get credit average amount for month (first enter credit total) (second enter months)"
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

                return [firstNumber, secondNumber];
            }
            static bool CheckForEven(double number)
            {
                if (number % 1 != 0)
                    return false;

                long integerNumber = (long)number;

                if (integerNumber % 2 == 0)
                    return true; 
                else
                    return false; 
                
            }

            static double CalculatePercentage(double number, double percent)
            {
                return (number * percent) / 100.0;
            }

            static double GetSquareRoot(double number)
            {

                return Math.Sqrt(number);
            }

            static double GetPower(double number, double power)
            {
                return Math.Pow(number, power);
            }

            static double EnterSingleNumberFromConsole()
            {
                Console.WriteLine("Enter number:");
                double number = double.Parse(Console.ReadLine());
                return number;
            }


            static double CalculateCreditAverage(double creditTotal, double months)
            {
                return creditTotal / months;
            }
        }
    }
}
