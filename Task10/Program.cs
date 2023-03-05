// Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit(int num) // num = number
{
    int thirdDigit = num / 10; // убираем 3 число
    int firstDigit = thirdDigit % 10; // оставляем остаток
    int secD = firstDigit;
    return secD;
}

Console.WriteLine("Type a number with three digits");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit = SecondDigit(number);
Console.WriteLine($"Second Digit {secondDigit}");
