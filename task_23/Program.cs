// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string result = "";
for(int i = 1; i <= number; i++)
{
    result += $"{Math.Pow(i, 3)}, ";
}
result = result.TrimEnd(' ', ',');
Console.Write($"Список кубов от 1 до {number} включительно: {result}");