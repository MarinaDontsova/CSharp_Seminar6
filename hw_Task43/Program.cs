﻿//     43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//     заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//     значения b1, k1, b2 и k2 задаются пользователем.
//     b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) 

Console.WriteLine("Введите k1 первой прямой");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k2 второй прямой");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b1 первой прямой");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b2 второй прямой");
int b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    double resultX = (double)(b2 - b1) / (k1 - k2);
    double resultY = ((double)(k1 * (b2 - b1)) / (k1 - k2)) + b1;
    Console.WriteLine($"Координаты точки пересечения прямых: ({resultX}; {resultY})");
}
