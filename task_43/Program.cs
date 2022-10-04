// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Write($"Введите значение номер b1: "); 
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите значение номер k1: "); 
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите значение номер b2: "); 
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите значение номер k2: "); 
double k2 = Convert.ToInt32(Console.ReadLine());

double xCount(double b1, double k1, double b2, double k2) 
{
    double x = (b1 - b2) / -(k1 - k2);
    return x;
}

double yCount(double x, double b1, double k1)
{
    double y = k1 * x + b1;
    return y;
}

double x = xCount(b1, k1, b2, k2);
double y = yCount(x, b1, k1);

Console.WriteLine($"Координаты точки пересечения прямых - [{x}, {y}]");