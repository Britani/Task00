// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.WriteLine("Введите число N");
int number= Convert.ToInt32(Console.ReadLine());

Quart(number);

void Quart(int numb)
{
    int index = 1;

    while (index<=numb)
    {
        Console.WriteLine($"{index,5}->{index*index,5}");
        index++;
    }
}
