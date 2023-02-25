//Напишите программу которая принемает на вход 3 числа и выдает максимальное из этих чисел.
Console.WriteLine("Чтобы узнать какое число является максимальным введем первое число ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Теперь введем второе число ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Теперь введем третье число ");
int numC = Convert.ToInt32(Console.ReadLine());
int numMax = numA;
if (numMax <= numB) numMax=numB;
if (numMax <= numC)numMax=numC;
 Console.WriteLine($"Максимальным среди этих трех чисел является число {numMax}"); 
