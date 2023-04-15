using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter the base number: ");
            int baseNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the power: ");
            int power = int.Parse(Console.ReadLine());

            int result = (int)Math.Pow(baseNumber, power);
            int sumOfDigits = GetSumOfDigits(result);

            Console.WriteLine("The result of " + baseNumber + " raised to the power of " + power + " is: " + result);
            Console.WriteLine("The sum of the digits of the result is: " + sumOfDigits);
        }
        catch
        {
            Console.WriteLine("Error: Wrong number input");
        }
    }

    static int GetSumOfDigits(int number)
    {
        int sum = 0;

        while (number != 0)
        {
            int digit = number % 10;
            sum += digit;
            number /= 10;
        }

        return sum;
    }
}