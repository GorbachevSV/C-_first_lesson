﻿Console.WriteLine("Type dot coordinates");
Console.Write("x:");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("y:");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCoordinate, yCoordinate);
string result = quarter > 0 
            ? $"Typed coordinates related to quarter - {quarter}"
            : "Coordinates incorrect";

Console.WriteLine(result);

int Quarter(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}