// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int resDiv = number;
Console.WriteLine(LessThanHundred(number)? "число не является трехзначным " : $"{ShowSecondDigit(resDiv)} является вторым числом в числе {number}");


bool LessThanHundred(int num)
{
return num<100 || num>=1000;
}

int ShowSecondDigit(int resOfDiv)
{
return resOfDiv = ((resDiv - resDiv%10)/10)%10;
}