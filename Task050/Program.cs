// Задача 50. Напишите программу, которая на вход принимает
//позиции элемента в двумерном массиве, и возвращает
//значение этого элемента или же указание,
//что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

int[] PositionElement()
{
    int[] pos = new int[2];
    Console.WriteLine(
        "Чтобы узнать чему равен и существует ли элемент массива, введите его индекс по вертикали "
    );
    pos[0] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" теперь введите его индекс по горизонтали ");
    pos[1] = Convert.ToInt32(Console.ReadLine());
    return pos;

}

void PrintPosition(int[] position)
{
    for (int i = 0; i < position.Length-1; i++)
    {
       Console.Write($"{position[i]}, "); 
    }
     Console.Write($"{position[position.Length-1]} ");

}
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


int[,] array2d = CreateMatrixRndInt(3, 4, 1, 100);
PrintMatrix(array2d);
int[] positions = PositionElement();
PrintPosition(positions);

if (positions[0]<array2d.GetLength(0) && positions[1]<array2d.GetLength(1))
{
    Console.WriteLine($" -> {array2d[positions[0], positions[1]]}");
}
else Console.WriteLine(" Такого элемента в массиве нет");
