﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Write("Массив из скольки элементов вы хотите создать? ");
int count = Convert.ToInt32(Console.ReadLine());
// int count = 8; ну или просто создаем массив длинной в константу 8, просто в примерах решения 5 и 3, а не 8, так что я подстраховался.

int[] array = new int[count];
Console.WriteLine($"Сейчас будем вводить с клавиатуры массив из {count} элементов, приготовтесь, будет весело.");

//Вводим массив
for(int i = 0; i < count; i++)
{
    Console.Write($"Введите элемент номер {i+1}: "); // сделаю нумерацию для человеков, а не программистов
    array[i] = Convert.ToInt32(Console.ReadLine());
}
// И выводим
Console.WriteLine("Получился следующий массив: ");
for(int i = 0; i < count; i++)
{
    Console.Write($"{array[i]} ");
}