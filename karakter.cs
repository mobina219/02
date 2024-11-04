using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("لطفاً یک کاراکتر حروف الفبا وارد کنید:");

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

            if (char.IsLetter(keyInfo.KeyChar))
            {
                Console.WriteLine($"\nشما کاراکتر '{keyInfo.KeyChar}' را وارد کردید.");
                break;
            }
            else
            {
                Console.WriteLine("\nورودی معتبر نیست. لطفاً یک کاراکتر حروف الفبا وارد کنید:");
            }
        }
    }
}