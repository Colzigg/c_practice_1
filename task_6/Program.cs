Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int rem = a % 2;
if(rem == 0)
{
    Console.Write($"Число {a} четное");
}
else
{
    Console.Write($"Число {a} нечетное");
}