using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("لطفاً دو عدد m و n را وارد کنید:");
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"اعداد اول بین {m} و {n} عبارتند از:");

        for (int i = m; i <= n; i++)
        {
            if (IsPrime(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}