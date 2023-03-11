// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = СreateArrayInt(5, -10, 15);
PrintArray(array);
double different = DifferenceBetweenMaxAndMin(array);
Console.WriteLine($" -> {different}");

double[] СreateArrayInt(int size, double min, double max)
{
 double[] arr = new double[size];
 Random rnd = new Random();
 for (int i = 0; i < size; i++)
 {
    double num = rnd.NextDouble()*(max-min)+min;// не принемает аргументы, а выдает случ. числа от 0 до 1
    arr[i] = Math.Round(num, 2);     
 }
 return arr;
}

void PrintArray(double[] arr)

{
    Console.Write("[");

    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
Console.Write("]");
}
 double DifferenceBetweenMaxAndMin(double[] arr)
 {
    double min = arr[0];
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
       if (min>arr[i]) min = arr[i];
       if (max<arr[i]) max = arr[i];
    }

    double dif = Math.Round((max-min), 2);
    return dif;
 }

