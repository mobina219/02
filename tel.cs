using System.Text.RegularExpressions;

MatchCollection matches = Regex.Matches(input, @"0\d{9}");
foreach (Match match in matches)
{
    string phoneNumber = match.Value;
    if (IsPhoneNumberValid(phoneNumber))
    {
        Console.WriteLine(phoneNumber);
    }
      