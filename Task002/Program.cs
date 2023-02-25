//Напишите программу, которая на вход принемает два числа и выдает, какое число меньше, а какое больше.

Console.WriteLine("Чтобы узнать какое число больше, а какое меньше введите первое число ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Теперь введите второе число ");
int numB = Convert.ToInt32(Console.ReadLine());
if (numA > numB)
    Console.WriteLine($"Большее число из {numA} и {numB} будет число {numA}");
if (numA < numB)
    Console.WriteLine($"Большее число из {numA} и {numB} будет число {numB} ");
else
    Console.WriteLine("Числа равны");
