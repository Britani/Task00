// Задача 24: Напишите программу, которая
// принимает на вход число (А) и 
// выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите натуральное число ");
int number = Convert.ToInt32(Console.ReadLine());

int res = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {res}");

int SumNumbers(int numnum)
{
    int sum = 0;
    for (int i = 1; i <= numnum; i++)
    {
        sum += i; //sum = sum+i
    }
    return sum;
}
