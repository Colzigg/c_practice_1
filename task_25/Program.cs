// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите число, которое будем возводить в степень: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, которое будет степенью: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = numberA;
for(int i = 2; i <= numberB; i++)
{
    result *= numberA;
}
Console.Write($"Число {numberA} в степени {numberB} будет равно {result}.");