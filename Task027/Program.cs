// Задача 27: Напишите программу,
//которая принимает на вход число
//и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = SumDigit(number);
Console.WriteLine($"Сумма цифр в числе {number} равна {sum}");

int SumDigit(int num)
{
    int sumDigit = 0;
    if (num <= 0)
        num = num * -1;

    int remainder = num;
    do
    {
        remainder = num % 10;
        sumDigit = sumDigit + remainder;
        num = (num - remainder) / 10;
    } while (num != 0);
    return sumDigit;
}
