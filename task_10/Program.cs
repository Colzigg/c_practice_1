﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = (num / 10)  % 10;
Console.Write($"Вторая цифра числа {num} - {result}");