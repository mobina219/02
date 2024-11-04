
Console.WriteLine("لطفا دو عدد وارد کنید");

int m = int.parse(console.readline())
int n = int.parse(console.readline())

Console.WriteLine("اعداد آینه ای بین m,n عبارتند از);
    for(int i=m;int<=n;int++)
    {
    if(IsPalindrome(i))
    {
    console.wrireline(i);
}
}
}
static bool IsPalindrome(int number)
{
    int reverse = 0;
    int temp = number;
    while (temp > 0)
    {
        int remainder = temp % 10;
        reverse = (reverse * 10) + remainder;
        temp /= 10;
    }
    return number == reverse;
}
}