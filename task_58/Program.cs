// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

double[,] MatrixMultiplication(double[,] matrixFirst, double[,] matrixSecond)
{
    double[,] matrixFinal = new double[matrixFirst.GetLength(0), matrixFirst.GetLength(1)];
    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFirst.GetLength(1); j++)
        {
            matrixFinal[i, j] = matrixFirst[i,j] * matrixSecond[i,j];
        }
    }
    return matrixFinal;
}

int rowMatrix = new Random().Next(4, 7);
int columnMatrix = new Random().Next(3, 7);

double[,] matrixFirst = MatrixInputDouble(rowMatrix, columnMatrix);
MatrixOutput(matrixFirst);

double[,] matrixSecond = MatrixInputDouble(rowMatrix, columnMatrix);
MatrixOutput(matrixSecond);

double[,] matrixResult = MatrixMultiplication(matrixFirst, matrixSecond);
MatrixOutput(matrixResult);
