﻿// Задача 4: Напишите программу, 
// которая принимает на вход три числа и выдаёт 
// максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введи три числа");
Console.WriteLine("Введи первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
 
int max = a;
if (b > max) max = b;
if (c > max) max = c;
{
    Console.WriteLine($"Число {max} максимальное!");
}


