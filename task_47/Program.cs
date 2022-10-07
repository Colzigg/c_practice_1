// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] MatrixInputDouble(int row, int column)
{
    double[,] matrix = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = new Random().Next(-10, 10) + Math.Round(new Random().NextDouble(), 1);
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

Console.Write("Сколько строк должно быть в матрице? ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Сколько столбцов должно быть в матрице? ");
int column = Convert.ToInt32(Console.ReadLine());

double[,] matrix = MatrixInputDouble(row, column);
MatrixOutput(matrix);