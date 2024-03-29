﻿// Задача 64: Задайте значение N. Напишите программу, которая
//выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"N = {number}" + " -> \"");
if (NaturalNumberСheck(number))
{
    ShowNaturalNumbersFromMaximumOne(number);
}
else
    Console.WriteLine($"Число {number} не является натуральным\"");





bool NaturalNumberСheck(int num)
{
    return num > 0;
}

void ShowNaturalNumbersFromMaximumOne(int n)
{
    //Console.Write($"N = {n} -> ");
    if (n == 0)
        return;
    else
    {
        if (n > 1)
        {
            Console.Write($"{n}, ");
            ShowNaturalNumbersFromMaximumOne(n - 1);
        }
        else
        {
            if (n == 1)
                Console.Write($"{n}\"");
        }
    }
}
