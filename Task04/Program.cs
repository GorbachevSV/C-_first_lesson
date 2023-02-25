// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

Console.WriteLine("Input three numbers: ");
Console.Write("numberA = ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("numberB = ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("numberC = ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberB > max)
{
    max = numberB;
}
else
{
    max = numberA;
}
if (numberC > max)
{
    max = numberC;
}
else
{
    max = numberA;
}
Console.WriteLine("max = " + max);
