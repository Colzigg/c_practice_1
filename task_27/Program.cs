// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int numConv = num;
int result = 1;
while(numConv > 9)
    {
        numConv = numConv / 10;
        result++;
    }
Console.Write($"В числе {num} - {result} цифр(ы).");
