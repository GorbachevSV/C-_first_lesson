// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Input a number of a day: ");
Console.Write("Day Number ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA == 1)
    {
        Console.WriteLine("Monday");
    }
else if (numberA == 2)
    {
        Console.WriteLine("Tuesday");
    }   
else if (numberA == 3)
    {
        Console.WriteLine("Wednesday");
    }   
else if (numberA == 4)
    {
        Console.WriteLine("Thursday");
    }   
else if (numberA == 5)
    {
        Console.WriteLine("Friday");
    }   
else if (numberA == 6)
    {
        Console.WriteLine("Saturday");
    }   
else if (numberA == 7)
    {
        Console.WriteLine("Sunday");
    }   
else
    {
        Console.WriteLine("Error");
    }