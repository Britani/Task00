// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CriateSpiralMatrix(int rows, int columns)
{
    int[,]matr = new int[rows,columns];
    //matr[0,0] = Convert.ToInt32(Console.Read());
    for (int i = 0)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = Convert.ToInt32(Console.Read());
        }
    } 
    j=matr.GetLength(1)-1;
    for (int i = 1; i < matr.GetLength(0); i++)
    {
        matr[i,j] = Convert.ToInt32(Console.Read());
    }
    i=matr.GetLength(0)-1;
    for (int j = matr.GetLength(1)-1; j >=0; j=i-1)
    {
         matr[i,j] = Convert.ToInt32(Console.Read());
    }
    j=0;
    for (int i = matr.GetLength(0)-1; i>=1; i=i-1)
    {
       matr[i,j] = Convert.ToInt32(Console.Read()); 
    }
     
    
    return matr;
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

int[,] matrix = CriateSpiralMatrix(4, 4);
PrintMatrix(matrix);