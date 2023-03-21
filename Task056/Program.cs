// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] matr = CreateMatrixRndInt(5, 7, -5, 10);
PrintMatrix(matr);
Console.WriteLine();
int[] sum = SumElementsAcrossRows(matr);
PrintArray(sum);
int nomberMinSumRows = MinSumRows(sum);
Console.WriteLine();
Console.WriteLine($"Строка с минимальной суммой элементов номер {nomberMinSumRows}");

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; //0, 1
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
        //Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine();
    }
}

int[] SumElementsAcrossRows(int[,] matrix)
{
    int[] sumElementsRows = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumElementsRows[i] += matrix[i, j];
        }
    }
    return sumElementsRows;
}

void PrintArray(int[] arr)
{
    Console.Write("[", 3);

    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int MinSumRows(int[] array)
{
    int min = array[0];
    int index = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (min >= array[i])
            min = array[i];
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == min)
            index = i;
    }
    return index;
}
