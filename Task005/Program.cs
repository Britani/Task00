//Напиши программу, которая на вход принемает число N
//а на выходе показывает все целые числа от -N до namespace Name
Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int count = -N;

if (N > 0)
{
    while (count <= N)
    {
        Console.Write(count + " ");
        count++;
    }
}
else
{
    Console.WriteLine(" Не верное число ");
}
