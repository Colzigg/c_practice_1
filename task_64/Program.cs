// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void NaturalNumbers(int number)
{
    if (number == 1) Console.Write(number);
    else
    {
        Console.Write($"{number}, ");
        NaturalNumbers(number - 1);
    }
}

int n = new Random().Next(1, 10);
NaturalNumbers(n);