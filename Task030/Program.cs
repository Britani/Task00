// адача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] array = new int [8]; // элементы все нули индексы - 0, 1, 2, 3...7

FillArray(array);

PrintArray(array);



void PrintArray(int[] collection)
{

    for (int i = 0;  i < collection.Length; i++)
    {
        Console.Write($"{collection[i]} ");
    }
}


    void FillArray(int[] collection)
{
    
    
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(0,2);
    }
}