// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int resDiv = number;
Console.WriteLine(LessThanHundred(number)? "в числa нет третьей цифры" : $"{ShowThirdDigit(resDiv)} является третьей цифрой в числе {number}");

bool LessThanHundred(int num)
{
return num<100;
}

int ShowThirdDigit(int resOfDiv)
{
    while (resOfDiv > 1000)
    {
        resOfDiv = resOfDiv / 10;
    }
    return resOfDiv%10;
}
