using System;

class Program
{
    static void Main()
    {
        string answer;

        do
        {
            Console.WriteLine("آیا می‌خواهید به سوال بعدی پاسخ دهید؟ (بله/خیر)");
            answer = Console.ReadLine().Trim().ToLower();

            if (answer == "بله")
            {
                // میتونی سوالات بیشتر را اینجا اضافه کنی
                Console.WriteLine("این یک سوال تصمیم گیری است. لطفاً پاسخ دهید.");
            }
            else if (answer != "خیر")
            {
                Console.WriteLine("لطفاً فقط 'بله' یا 'خیر' وارد کنید.");
            }

        } while (answer == "بله");

        Console.WriteLine("پایان برنامه.");
    }
}