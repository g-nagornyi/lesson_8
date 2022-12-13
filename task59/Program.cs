int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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

int[] FindMinPosition(int [,] mass)
{
    int[] array = new int[2];
    int min = mass[0,0];
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (mass[i, j]< min)
            {
                min = mass[i, j];
                array[0] = i;
                array[1] = j;
            }
        }
    }
    return array;
}
int[,] CreateMatrix(int[,] matrix, int[] index)
{
    int[,] newMatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (m == index[0]) m++;
        m++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (n == index[1]) n++;
            newMatrix[i, j] = matrix[m, n];
            n++;
        }   
        n = 0;  
    }
    return newMatrix;
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
int[] arr = FindMinPosition(array2D);
int[,] resultMatrix = CreateMatrix(array2D, arr);
PrintMatrix(resultMatrix);

