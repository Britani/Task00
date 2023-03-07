// /Задача 25: 
//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число А ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B ");
int b = Convert.ToInt32(Console.ReadLine());

if (b>0)
{
    int degreOf = DegreOf(a, b);
    Console.WriteLine($"Число {a} в степени {b} равно {degreOf}");
}
else Console.WriteLine($"Число {b} не является натуральным");

int DegreOf(int c, int d)
{
    int res = 1;
    for (int i = 0; i < d; i++)
    {
        res *= c;
    }
    return res;
}

