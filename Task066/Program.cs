// Задача 66: Задайте значения M и N. Напишите программу,
//которая найдёт сумму натуральных элементов в
//промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int sumNumbers = 0;
if (CheckWhichNumberGreater(numberM, numberN))
{
    sumNumbers = SumNaturalNumbersFromSegment(numberN, numberM);
}
else
{
    sumNumbers = SumNaturalNumbersFromSegment(numberM, numberN);
}
Console.Write($"M = {numberM}; N = {numberN} -> {sumNumbers}");

bool CheckWhichNumberGreater(int numA, int numB)
{
    return numA > numB;
}

int SumNaturalNumbersFromSegment(int numA, int numB)
{
    if (numA == numB)
        return numA;
    else
    {
        return numA + SumNaturalNumbersFromSegment(numA + 1, numB);
    }
}
