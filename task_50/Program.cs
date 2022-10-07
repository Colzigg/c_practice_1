// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

double[,] MatrixInputDouble(int row, int column)
{
    double[,] matrix = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = new Random().Next(-9, 9);
        }
    }
    return matrix;
}

void MatrixOutput(double[,] matrix)
{
    Console.WriteLine();
    Console.WriteLine($"Сгенерирована следующая матрица, размером {matrix.GetLength(0)} х {matrix.GetLength(1)}");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] >= 0) Console.Write(" " + matrix[i, j] + " ");
            else Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите номер строки элемента, который хотите вернуть ");
int rowElement = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца элемента, который хотите вернуть ");
int columnElement = Convert.ToInt32(Console.ReadLine());

int rowMatrix = new Random().Next(2, 10);
int columnMatrix = new Random().Next(2, 10);

double[,] matrix = MatrixInputDouble(rowMatrix, columnMatrix);

MatrixOutput(matrix);

if ((rowElement > 0 & rowElement <= rowMatrix)
& (columnElement > 0 & columnElement <= columnMatrix))
{
    Console.Write($"Значение запрошенного вами элемента равно {matrix[rowElement - 1, columnElement - 1]}");
}
else Console.Write("Элемента с таким адресом в матрице нет!");