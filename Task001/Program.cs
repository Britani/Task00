﻿// 0. Демонстрация решения

// 1.
// 2. выдает его квадрат (число уноженое на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}"); // интерполяция, с помощью $
//Console.WriteLine("Квадрат числа" + number + "=" + square); // конкатенация, склеивание строк с помощью + и ""

