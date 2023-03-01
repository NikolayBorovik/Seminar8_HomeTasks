// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка.

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

int SmallestSumOfItems(int[,] matrix)
{
    int[] sumsArray = new int[matrix.GetLength(0)];
    int count = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            count += matrix[i, j];
        }
        sumsArray[i] = count;
        count = 0;
    }
    System.Console.WriteLine();
    System.Console.WriteLine(String.Join(" ", sumsArray));
    System.Console.WriteLine();
    
    int min = sumsArray[0];
    int minIndex = 0;
    for (int i = 1; i < sumsArray.Length; i++)
    {
        if (sumsArray[i] < min)
        {
        min = sumsArray[i];
        minIndex = i;
        }
    }
    return minIndex;
}

int[,] matrix = GetIntMatrix(4, 5);

PrintMatrix(matrix);

System.Console.WriteLine($"The row with the smallest sum of numbers is: {SmallestSumOfItems(matrix)}");
