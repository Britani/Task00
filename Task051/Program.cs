// Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали
// (с индексами (0;0), (1;1)) и т.д.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; //0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max+1);
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
int SumElementsDiagonal(int[,]array)
{
int sum = 0;
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i==j)
            {
                sum += array[i, j];
            }
            
        }
        
    }
    return sum;
}

int SumDiagonal(int[,] array)
{
int sum = 0;
for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
{
    sum +=array[i,i];
}
return sum;
}

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2d);
int res = SumElementsDiagonal(array2d);
Console.WriteLine(res);
int summery = SumDiagonal(array2d);
Console.WriteLine(res);