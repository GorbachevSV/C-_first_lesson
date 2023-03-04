int number = new Random().Next(100, 1000);
Console.WriteLine($"Random number from the line 100-999 -> {number}");
int firstDigit = number / 100;
int thirdDigit = number % 10;

int result = firstDigit * 10 + thirdDigit;

Console.WriteLine($"new number -> {result}");

int sumDigit = SumDigit(number);

int SumDigit(int num) // num = number
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int sumD = firstDigit * 10 + thirdDigit;
    return sumD;
}
Console.WriteLine($"new number -> {sumDigit}");