// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool NumberOfADay(int num) // num = number
{
    return num > 0 && num < 6;
     
}


Console.WriteLine("Type a number of a day: ");
Console.Write("Day Number ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 7)
{
    bool numberOfADay = NumberOfADay(number);
    Console.WriteLine(numberOfADay ? "no" : "yes");
}

else
{
    Console.WriteLine("Error");
}


