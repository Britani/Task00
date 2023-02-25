//Написать программу которая принемает на вход трехзначную цифру
// а на выход показывает последнюю цифру этого числа
Console.WriteLine("Введите трехзначное число ");
    int num = Convert.ToInt32(Console.ReadLine());
    int Remainder = num % 10;

    if (num < 1000 && num >= 100) Console.WriteLine($"Последнее число трехзначного числа {num} = {Remainder} ");
    
    else Console.WriteLine($"Число {num} не является трехзначным числом");
