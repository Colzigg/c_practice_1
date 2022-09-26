// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int numConv = num;
if(numConv < 100)
{
    Console.WriteLine($"У числа {num} нет третьей цифры!");
}
else
{
    while(numConv >= 1000)
    {
        numConv = numConv / 10;
    }
    int result = numConv % 10;
    Console.Write($"Третья цифра числа {num} - {result}");
}