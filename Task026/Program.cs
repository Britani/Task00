// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int res = DigitCounter(number);
Console.WriteLine($"Количество цифр в числе {number} равно {res}");




int DigitCounter(int num)
{
int index = 0;
do                    // для того, чтобы цикл работал хотябы 1 раз
{
    num /= 10;
        index+=1;// либо index++
} while (num != 0); // помолает циклу работать при отриц знач аргумента
    
    return index;
}