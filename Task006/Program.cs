// Напишем программу, которая на вход принемает число и выдает является ли это число четным или нечетным
Console.WriteLine("Чтобы узнать является ли число четым или нечетным введите число ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0) Console.WriteLine($"Число {num} четное ");
else Console.WriteLine($"Число {num} нечетное ");
