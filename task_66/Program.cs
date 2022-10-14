// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNaturalNumbers(int startNumber, int finalNumber)
{
    if ((finalNumber - startNumber) == 0) return startNumber;
    else return startNumber + SumNaturalNumbers(startNumber + 1, finalNumber);
}

int n = new Random().Next(1, 6);
int m = new Random().Next(8, 20);
int sum = SumNaturalNumbers(n, m);

Console.Write($"Сумму натуральных элементов в промежутке от {n} до {m} равна {sum}.");