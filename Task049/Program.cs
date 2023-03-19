// Задача 49: Задайте двумерный массив,
// Найдите элементы, у которых оба индекса четные,
// замените эти элементы на их квадраты.

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);
 Console.WriteLine();
int[,] array2dSquere = CriateNewMatrix(array2d);
PrintMatrix(array2dSquere);
 Console.WriteLine();
int[,] matrSquere = CriateNewMatrixSquere(array2d);
PrintMatrix(matrSquere);


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
        Console.Write($"{matrix[i, j], 7}");
    }
    Console.WriteLine();
    }
    
}




int[,] CriateNewMatrix(int[,] matrix)
{
   int[,] mat = matrix; //0, 1
    

    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            if(i%2==0 && j%2==0)
            mat[i, j] *= mat[i, j];
        }
    }
    return mat;
  
}

/////////////////////////////////////////////

int[,] CriateNewMatrixSquere(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i+=2)
    {
      for (int j = 0; j < matr.GetLength(1); j+=2)
      {
        matr[i,j] *= matr[i,j];
      }  
    }
    return matr;
}