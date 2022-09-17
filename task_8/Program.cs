Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
//int rem = a % 2;
int count = 1;
string result = "";
int rem = 0;
while(count <= a)
{
    rem = count % 2;
    if(rem == 0)
    {
        result += $"{count}, ";
    }
    count++;
}
result = result.TrimEnd(' ', ',');
Console.Write($"Последовательность чисел: {result}");