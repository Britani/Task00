﻿// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.
Console.WriteLine("Введите длинну стороны А:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длинну стороны B :");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длинну стороны  C:");
int l = Convert.ToInt32(Console.ReadLine());

string output = IsExistTriangle(n, m, l) ? "Треугольник может существовать с такими сторонами" : "Треугольник не может существовать с такими сторонами";
Console.WriteLine(output);

bool IsExistTriangle(int a, int b, int c)
{
    // if (a + b > c && b + c > a && c + a > b) return true;
    // else false;
    //можно
    return a + b > c && b + c > a && c + a > b;
    
}





// bool IsExistTriangle(int a, int b, int c)
// {
//     if (a + b > c && b + c > a && c + a > b) return true;
//     else return false;
// }

// Console.Write("Введите длину стороны А: ");
// int sideA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите длину стороны B: ");
// int sideB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите длину стороны C: ");
// int sideC = Convert.ToInt32(Console.ReadLine());
// string output = IsExistTriangle(sideA, sideB, sideC) ? "Треугольник может существовать с такими сторонами" : "Треугольник не может существовать с такими сторонами";
// Console.WriteLine(output);

