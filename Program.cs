using System;

namespace Lab6_1_PrimeNumbers
{
    public class PrimeNumbers
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        public static int GetNthPrime(int n)
        {
            int countOfPrimes = 0, num = 2;
            while (true)
            {
                if (IsPrime(num))
                {
                    countOfPrimes++;
                    if (countOfPrimes == n) return num;
                }
                num++;
            }
        }
    }
    class Program
    {
        static  bool KeepGoing()
        {
            bool done = false;
            bool result = false;
            while (!done)
            {
                Console.Write("\nDo you want to find another prime (y/n)? ");
                string userKeepGoing = Console.ReadLine().ToLower();
                if (userKeepGoing == "y")
                {
                    result = true;
                    done = true;
                }
                else if (userKeepGoing == "n")
                {
                    result = false;
                    done = true;
                }
                else Console.WriteLine("Please enter \"y\" or \"n\".");
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find-A-Prime!");
            do
            {
                Console.Write("\nWhich prime do you want to find? ");
                int n = int.Parse(Console.ReadLine());
                if (n % 100 == 11 || n % 100 == 12 || n % 100 == 13) Console.WriteLine($"\nThe {n}th prime is {PrimeNumbers.GetNthPrime(n)}.");
                else switch (n % 10)
                {
                    case 1:
                        Console.WriteLine($"\nThe {n}st prime is {PrimeNumbers.GetNthPrime(n)}.");
                        break;
                    case 2:
                        Console.WriteLine($"\nThe {n}nd prime is {PrimeNumbers.GetNthPrime(n)}.");
                        break;
                    case 3:
                        Console.WriteLine($"\nThe {n}rd prime is {PrimeNumbers.GetNthPrime(n)}.");
                        break;
                    default:
                        Console.WriteLine($"\nThe {n}th prime is {PrimeNumbers.GetNthPrime(n)}.");
                        break;
                }
            }
            while (KeepGoing());
        }
    }
}
