// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(LessZeroMoreSeven(number)? "Этому числу не соответствует ни какой день недели" : WeekEnd(Week(number)) ? "Выходной": "не является выходным днем");

bool LessZeroMoreSeven(int num)
{
return num<=0 || num>=8;
}

int Week (int numWeek)
{
if (numWeek == 1) Console.WriteLine("Понедельник");
else if (numWeek == 2) Console.WriteLine("Вторник");
else if (numWeek == 3) Console.WriteLine("Среда");
else if (numWeek == 4) Console.WriteLine("Четверг");
else if (numWeek == 5) Console.WriteLine("Пятница");
else if (numWeek == 6) Console.WriteLine("Суббота");
else if (numWeek == 7) Console.WriteLine("Воскресенье");
return numWeek;
}

bool WeekEnd (int numb)
{
    return numb == 6 || numb == 7;
}