using System;

namespace ArrayParsing.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a delimited string of numbers:");
            string input = Console.ReadLine();

            Console.WriteLine("Enter the delimiter character:");
            char delimiter = Console.ReadKey().KeyChar;
            Console.WriteLine();

            string[] numbers = input.Split(delimiter);
            string result = ValidateNumbers(numbers);

            Console.WriteLine("Validated numbers:");
            Console.WriteLine(result);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static string ValidateNumbers(string[] numbers)
        {
            string validatedNumbers = string.Empty;

            foreach (string number in numbers)
            {
                if (double.TryParse(number, out double parsedNumber))
                {
                    validatedNumbers += parsedNumber + ",";
                }
            }

            if (!string.IsNullOrEmpty(validatedNumbers))
            {
                // Remove the trailing comma
                validatedNumbers = validatedNumbers.TrimEnd(',');
            }

            return validatedNumbers;
        }
    }
}
