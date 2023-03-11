// Задача 34: Задайте массив заполненный случайными положительными
//трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine($"Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = SetArrayRandomNumbers(size, 100, 999); // до 999 т.к. мы прописали в методе условие max+1
PrintArray(array);
int result = EvenNumberCounter(array);
Console.Write($" -> {result}");

// void RandomSize()
// {
// int size = new Random.Next(4,100);
// }

int[] SetArrayRandomNumbers(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
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

int EvenNumberCounter(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            res += 1;
    }
    return res;
}
