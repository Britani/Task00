// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Чтобы посчитать, сколько чисел больше 0 введите, сколько чисел всего?");
int sizeArr = Convert.ToInt32(Console.ReadLine());
int[] array = EnterElements(sizeArr);
PrintArray(array);
int countElements = NegativeElementCounter(array);
Console.WriteLine($" -> {countElements}");

int[] EnterElements(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите число {i + 1} ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}; ");
        else
            Console.Write($"{arr[i]} ");
    }
}

int NegativeElementCounter(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            count++;
        }
    }
    return count;
}
