// Задача 68: Напишите программу вычисления функции Аккермана с
//помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите 1 неотрицательное число: ");
int argumentA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 неотрицательное число: ");
int argumentB = Convert.ToInt32(Console.ReadLine());
int res = FunctionAkkermana(argumentA, argumentB);
Console.WriteLine($"m = {argumentA}, n = {argumentB} -> {res}");

int FunctionAkkermana(int a, int b)
{
    if (a == 0)
    {
        return b + 1;
    }
    else
    {
        if (b == 0)
        {
            return FunctionAkkermana(a - 1, 1);
        }
        else
        {
            return FunctionAkkermana(a - 1, FunctionAkkermana(a, b - 1));
        }
    }
}
