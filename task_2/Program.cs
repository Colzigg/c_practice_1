Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if(b>max)
{
    max = b;
}
Console.Write($"Максимальное число: {max}");