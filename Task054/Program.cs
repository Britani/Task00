﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortDescendingLineLine(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1)-1; k++)
        {
          for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            int temp = 0;
            if (matrix[i, j] < matrix[i, j + 1])
            {
                temp = matrix[i, j];
                matrix[i, j] = matrix[i, j+1];
                matrix[i, j+1] = temp;
            }  
        }
        
            
        }
    }
}
int[,] matrix = CreateMatrixRndInt(5, 4, -5, 10);
PrintMatrix(matrix);
Console.WriteLine();
SortDescendingLineLine(matrix);
PrintMatrix(matrix);

// int[] arr = new int[7];
// Random rnd = new Random();
// for (int i = 0; i < 7; i++)
// {
//     arr[i] = rnd.Next(1,9);
// }
// PrintArray(arr);
// Console.WriteLine();
// SortArray(arr);
// PrintArray(arr);

// void SortArray(int[] arr)
// {
//     int temporery=0;
//     for (int i = 0; i < arr.Length-1; i++)
//     {
//        if (arr[i]<arr[i+1])
//        {
//         temporery = arr[i];
//         arr[i]=arr[i+1];
//         arr[i+1]=temporery;
//        }

//     }
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[", 3);

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1)
//             Console.Write($"{arr[i]}, ");
//         else
//             Console.Write($"{arr[i]}");
//     }
//     Console.Write("]");

// }
