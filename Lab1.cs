using System;
using System.Linq;
class Program
{
    public static void LargestReturn(){
         Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

    int largest = Math.Max(num1, Math.Max(num2, num3));

    Console.WriteLine("The largest number is: " + largest);
        }
    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
    static long Factorial(int n)
    {
        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    static bool IsPrime(int n)
    {
        if (n <= 1)
            return false; // 0 and 1 are not prime

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false; // Found a divisor, so it's not prime
        }
        return true; // No divisors found, it's prime
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"The factorial of {number} is: {Factorial(number)}");

        //largestreturn();
        //console.readkey();
        //console.write("enter a year: ");
        //int year = int.parse(console.readline());

        //if (isleapyear(year))
        //    console.writeline($"{year} is a leap year.");
        //else
        //    console.writeline($"{year} is not a leap year.");

        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int sum = numbers.Sum();
        Console.WriteLine("Sum: " + sum);
        Console.Write("Enter a number: ");
        int numberp = int.Parse(Console.ReadLine());

        if (IsPrime(numberp))
            Console.WriteLine($"{numberp} is a prime number.");
        else
            Console.WriteLine($"{numberp} is not a prime number.");

    }


}
                                       
