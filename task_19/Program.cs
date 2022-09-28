// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int numStart = num / 10000 + ((num / 1000) % 10) * 10;
// Console.WriteLine(numStart);
int numEnd = num % 100;
// Console.WriteLine(numEnd);
if(numStart == numEnd)
{
    Console.WriteLine($"Число {num} является палиндромом!");
}
else
{
    Console.WriteLine($"Число {num} не является палиндромом!");
}