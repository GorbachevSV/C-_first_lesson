// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

Console.WriteLine("Input two numbers: ");
Console.Write("numberA = ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("numberB = ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB)
{
    Console.WriteLine("numberA > numberB; max = " + numberA);
}
else
{
    Console.WriteLine("numberA > numberB; max = " + numberB);
}