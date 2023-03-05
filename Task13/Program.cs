// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int ThirdDigit(int num)
{
    int count = 0;
    while (count < 2)
    {
        num = num / 10;
        count++;
    }
    int ThirdDigit = num % 10;
    return ThirdDigit;
}


Console.WriteLine("Type a number with more then three digits");
int number = Convert.ToInt32(Console.ReadLine());

int thirdDigit = ThirdDigit(number);

if (ThirdDigit(number) == 0)
{
    Console.WriteLine("Type Error");
}
else
{
    Console.WriteLine($"Third Digit {thirdDigit}");
}

