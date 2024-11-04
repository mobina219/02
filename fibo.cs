using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("لطفاً یک عدد بین 0 تا 9 را وارد کنید:");

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

            if (keyInfo.KeyChar >= '0' && keyInfo.KeyChar <= '9')
            {
                Console.WriteLine($"\nشما عدد {keyInfo.KeyChar} را وارد کردید.");
                break;
            }
            else
            {
                Console.WriteLine("\nورودی معتبر نیست. لطفاً یک عدد بین 0 تا 9 وارد کنید:");
            }
        }
    }
}