// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

double[] MatrixRowSumm(double[,] matrix)
{
    double[] arrayRowSumm = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double rowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum += matrix[i, j];
        }
        arrayRowSumm[i] = rowSum;
        Console.WriteLine($"Сумма значений по строке {i} равна {arrayRowSumm[i]}");
    }
    Console.WriteLine();
    return arrayRowSumm;
}

int rowMatrix = new Random().Next(4, 7);
int columnMatrix = new Random().Next(3, 7);

double[,] matrix = MatrixInputDouble(rowMatrix, columnMatrix);
MatrixOutput(matrix);

double[] tempArray = MatrixRowSumm(matrix);

double localMin = tempArray[0];
int localMinIndex = 0;
for (int i = 1; i < tempArray.Length; i++)
{
    if (tempArray[i] < localMin)
    {
        localMin = tempArray[i];
        localMinIndex = i;
    }
}

Console.WriteLine($"Номер строки с минимальной суммой равен {localMinIndex}, сумма значений равна {localMin}");