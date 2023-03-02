// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FiveDigitCheck(number)? CheckForPal(number)? "Число палиндром" : "Число не полиндром" : "Число не является пятизначным");


bool CheckForPal(int num)
{
return num % 10 == num/10000 && ((num - num % 10)/10)%10 == ((num - num % 1000)/1000)%10;
}


bool FiveDigitCheck(int numb)
{
    return numb >= 10000 && numb <100000;
}


