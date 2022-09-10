using System;

namespace Methods3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintRange(1000, -1000);
            Threes();
            EvenOrOdd(87);
            IsEqual(7, 12);
            IsPositive(1);
            VotingAge(20);
            TenRange(-10);
            Multiply(10);
        }
        public static void Multiply(int a)
        {
            for (int i = a)
            {
                Console.WriteLine($"{a} x 1 =", a * 1, $"{a} x 2 =", a * 2, $"{a} x 3 =", a * 3, $"{a} x 4 =", a * 4, $"{a} x 5 =", a * 5, $"{a} x 6 =", a * 6, $"{a} x 7 =", a * 7, $"{a} x 1 =", a * 8, $"{a} x 9 =", a * 9, $"{a} x 10 =", a * 10, $"{a} x 1 =", a * 11, $"{a} x 12 =", a * 12);

            }
        }

        public static bool TenRange(int range)
        {
            if (range <= 10 && range >= -10)
            {
                return true;
            }
            return false;
        }

        public static bool VotingAge(int age)
        {
            if (age > 18)
            {
                Console.WriteLine($"You are indeed old enough to vote");
                return true;
            }
            else
            {
                Console.WriteLine($"Sorry, you actually aren't able to vote yet");
                return false;
            }
        }

        public static bool IsPositive(int number1)
        {
            if (number1 > 0)
            {
                return true;
            }
            return false;    
        }

        public static void EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"That's definitely even");
            }
            else
            {
                Console.WriteLine($"Absolutely odd indeed");
            }
        }

        public static bool IsEqual(int a, int b)
        {
            if (a ==b)
            {
                return true;
            }
                return false;
        }

        public static void Threes()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }
        }

        public static void PrintRange(int ceiling, int floor)
        {
            for (int i = ceiling; i >= floor; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
