//Написать программу которая принемает на вход трехзначную цифру
// а на выход показывает последнюю цифру этого числа
Console.WriteLine("Введите трехзначное число ");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Math.Abs(numA);
int Remainder = numB % 10;

if (numB < 1000 && numB >= 100)
    Console.WriteLine($"Последнее число трехзначного числа {numA} = {Remainder} ");
else Console.WriteLine($"Число {numA} не является трехзначным числом");
