﻿// Задача 21. Напишите программу, которая
// 1. принимает на вход координаты двух точек 
// 2. и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Clear();

// Console.WriteLine("Введите координаты для точки A: ");
// Console.Write("Введите х: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите z: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты для точки B: ");
// Console.Write("Введите х: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите z: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double result = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));

// Console.WriteLine(Math.Round(result,2));



Console.WriteLine("Введите координаты для точки A: ");
Console.Write("Введите х: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты для точки B: ");
Console.Write("Введите х: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int xc1, int yc1, int zc1, int xc2, int yc2, int zc2)
{
    return Math.Round(Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2)),2 );
}

Console.WriteLine($"A ({x1}, {y1}, {z1}); B ({x2}, {y2}, {z2}) == {Distance( x1,  y1,  z1,  x2,  y2,  z2)} ");
