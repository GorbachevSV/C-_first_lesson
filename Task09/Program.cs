// Напишите программу, которая выводит случайное 
// число из отрезка [10, 99] и показывает наибольшую 
// цифру числа.

int number = new Random().Next(10, 100);
Console.WriteLine($"Random number from the line 10-99 -> {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;
if(firstDigit > secondDigit) Console.WriteLine($"max digit of the number -> {firstDigit}");
else Console.WriteLine($"max digit of the number -> {secondDigit}");