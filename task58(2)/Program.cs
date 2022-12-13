// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, columns];
int[,] secondMatrix = new int[rows, columns];
int[,] resultMatrix = new int[rows, columns];


int[,] CreateMatrixRndInt(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }

    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}
int[,] CreateSecondMatrixRndInt(int[,] secondMatrix)
{
    Random rnd = new Random();
    for (int i = 0; i < secondMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            secondMatrix[i, j] = rnd.Next(1, 10);
        }

    }
    return secondMatrix;
}
void PrintSecondMatrix(int[,] secondMatrix)
{
    for (int i = 0; i < secondMatrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            if (j < secondMatrix.GetLength(1) - 1) Console.Write($"{secondMatrix[i, j],4}, ");
            else Console.Write($"{secondMatrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}
int[,] ResultMatrix(int[,] resultMatrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = 0;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                resultMatrix[i, j] += matrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return resultMatrix;
}
void PrintResultMatrix(int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            if (j < resultMatrix.GetLength(1) - 1) Console.Write($"{resultMatrix[i, j],4}, ");
            else Console.Write($"{resultMatrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}

CreateMatrixRndInt(matrix);
PrintMatrix(matrix);
Console.WriteLine();
CreateSecondMatrixRndInt(secondMatrix);
PrintSecondMatrix(secondMatrix);
Console.WriteLine();
ResultMatrix(resultMatrix);
if (matrix.GetLength(0) != secondMatrix.GetLength(1))
{
    Console.WriteLine(" Не выполняется правило умножения матриц ");
    return;
}
else PrintResultMatrix(resultMatrix);

