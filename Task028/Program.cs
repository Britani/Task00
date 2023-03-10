// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.WriteLine("Введите натуральное число ");
int number = Convert.ToInt32(Console.ReadLine());

int res = Factorial(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {res}");

int Factorial(int num)
{
    int fukt = 1;
    for (int i = 1; i <= num; i++)
    {
        checked    // чтобы выдавало ошибку
        {
            fukt = fukt*i; // ошибка переполнения результата (чтобы видеть не корявый результат) а то что выявляется ошибка
        }
        // fukt = fukt*i;
    }
    return fukt;
}
