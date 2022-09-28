// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Write("Введите координаты первой точки: ");
double[] dotOne = {Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())};
Console.Write("Введите координаты второй точки: ");
double[] dotTwo = {Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())};
double distance = Math.Sqrt(Math.Pow(dotTwo[0] - dotOne[0], 2) + Math.Pow(dotTwo[1] - dotOne[1], 2) + Math.Pow(dotTwo[2] - dotOne[2], 2));
Console.WriteLine($"Расстояние между точками в 3D пространстве - {distance}.");