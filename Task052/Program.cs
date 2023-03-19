// Задача 52. Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            Console.Write($"{matrix[i, j], 6}");
        }
        Console.WriteLine();
    }
}

double[] ArithmeticMeanOverColumns(int[,] matr)
{
    double[] array = new double[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            array[j] += matr[i, j];
        }
        array[j] = Math.Round(array[j] / matr.GetLength(0), 2);
    }
    return array;
}

void PrintArray(double[] arr)
{
    Console.Write($"Среднее арифметическое каждого стобца ->");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i], 10}");
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, -50, 50);
PrintMatrix(array2d);
double[] arithmeticMeanOverColumns = ArithmeticMeanOverColumns(array2d);
PrintArray(arithmeticMeanOverColumns);
