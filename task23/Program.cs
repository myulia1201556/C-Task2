// Задача 23. Напишите программу, которая 
// 1. принимает на вход число (N) и
// 2.  выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
 
 while (i <= num)
 {
    int cube = i*i*i;
    Console.WriteLine($"{i} в 3 степени - {cube}");
    i++;
 }
