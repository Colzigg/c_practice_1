// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int numConv = num;
int sum = 0;
while(numConv > 9)
{
    sum += (numConv % 10);
    numConv = numConv / 10;
}
sum += numConv;
Console.Write($"В числе {num} сумма цифр равна {sum}");
