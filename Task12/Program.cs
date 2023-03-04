// Напишите программу, которая будет принимать на 
// вход два числа и выводить, является ли первое 
// число кратным второму. Если число 1 не кратно 
// числу 2, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

//Console.WriteLine("Type first number");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Type second number");
//int number2 = Convert.ToInt32(Console.ReadLine());

// int result = number1 % number2;

// if (result == 0)
// {
//    Console.WriteLine("Number1 can be devided by Number2 without remainder");
// }
// else
// {
//     Console.WriteLine($"Number1 can't be devided by Number2 without remainder, Remainder = {result}");
// }

Console.WriteLine("Type first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type second number");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = Multiple (num1, num2);

int Multiple (int num1, int num2)
{
   return num1%num2;
}

if (result == 0)
{
    Console.WriteLine("Number1 can be devided by Number2 without remainder");
}
else
{
     Console.WriteLine($"Number1 can't be devided by Number2 without remainder, Remainder = {result}");
}