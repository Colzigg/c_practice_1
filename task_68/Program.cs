// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckermannFunction(int mParam, int nParam)
{
    if ((mParam > 0) & (nParam > 0)) return AckermannFunction(mParam - 1, AckermannFunction(mParam, nParam - 1));
    else if ((mParam > 0) & (nParam == 0)) return AckermannFunction(mParam - 1, 1);
    else return nParam + 1;
}

//Я тут рандом ограничил, а то можно впечатляющие числа получить уже начиная с m=4.
int n = new Random().Next(2, 6);
int m = new Random().Next(1, 4);
int sum = AckermannFunction(m, n);

Console.Write($"Результат функции Аккермана, где N = {n}, а M = {m} равен {sum}.");
