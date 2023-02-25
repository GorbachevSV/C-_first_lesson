// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6 782 -> 2 918 -> 8
 
Console.Write("Type a three digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 0) number *= -1;
if(number > 99 && number < 1000)
    {
        int result = number % 10;
        Console.WriteLine("Result = " + result);
    }
else
    {
        Console.WriteLine("Error");
    }