// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

void MatrixAverageColumn(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double averageColumn, sumColumn = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sumColumn += matrix[j, i];
        }
        averageColumn = Math.Round(sumColumn / matrix.GetLength(0), 1);
        Console.WriteLine($"Среднее арифметическое по столбцу {i + 1} равно {averageColumn} (сумма элементов -  {sumColumn})");
    }
}

int rowMatrix = new Random().Next(3, 7);
int columnMatrix = new Random().Next(3, 7);

double[,] matrix = MatrixInputDouble(rowMatrix, columnMatrix);

MatrixOutput(matrix);

MatrixAverageColumn(matrix);