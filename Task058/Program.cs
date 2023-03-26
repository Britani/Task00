// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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


int[,] MultiplicationMatrix(int[,] matrixD, int[,] matrixF)
{
    int[,] matrix = new int[matrixD.GetLength(0), matrixF.GetLength(1)];
    for (int i = 0; i < matrixD.GetLength(0); i++)
    {
        for (int j = 0; j < matrixF.GetLength(1); j++)
        {
            for (int k = 0; k < matrixF.GetLength(0); k++)
            {
                matrix[i, j] += matrixD[i, k] * matrixF[k, j];
            }
        }
    }
    return matrix;
}

int[,] matrixA = CreateMatrixRndInt(3, 2, 2, 5);
PrintMatrix(matrixA);
Console.WriteLine();
int[,] matrixB = CreateMatrixRndInt(3, 4, 2, 5);
PrintMatrix(matrixB);
Console.WriteLine();
if (matrixA.GetLength(1) != matrixB.GetLength(0))
    Console.WriteLine($"Данные матрицы умножить невозможно ");
else
{
    int[,] matrixC = MultiplicationMatrix(matrixA, matrixB);
    Console.WriteLine();
    PrintMatrix(matrixC);
}
