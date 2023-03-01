// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int[,] GetIntMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] ProductOFMatrixes(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    int count = 0;
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        int k = 0;
        for (int j = 0; j < matrix2.GetLength(0); j++)
        {
            count += matrix1[i, j]*matrix2[j,k];
        }
        result[i,k] = count;
        count = 0;
    }
    
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        int k = 1;
        for (int j = 0; j < matrix2.GetLength(0); j++)
        {
            count += matrix1[i, j]*matrix2[j,k];
        }
        result[i,k] = count;
        count = 0;
    }
    return result;
}

int[,] matrix1 = GetIntMatrix(2, 3);
int[,] matrix2 = GetIntMatrix(3, 2);

PrintMatrix(matrix1);
System.Console.WriteLine();
PrintMatrix(matrix2);
System.Console.WriteLine();

PrintMatrix(ProductOFMatrixes(matrix1, matrix2));

