﻿// Задача 63: Задайте значение N. Напишите программу, 
//которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите");
int num = Convert.ToInt32(Console.ReadLine());

NaturalsNumbers(num);

void NaturalsNumbers(int number)
{
    if(number==0)return;
    NaturalsNumbers(number-1);
    Console.Write($"{number} ");
}

/////////////////////обратный порядок/////////////////////////////////
Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number);

void NaturalNumbers(int num)
{
    if(num == 0) return;
    Console.Write($"{num} ");
    NaturalNumbers(num - 1);
}



