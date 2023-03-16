// Задача 43: Напишите программу, которая найдёт точку пересечения
//двух прямых, заданных уравнениями
//y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Для того чтобы узнать точку пересечения заданных функций введите коэффициент k1 ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Теперь введите коэффициент k2 ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Далее введите коэффициент b1 ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" и коэффициент b2 ");
double b2 = Convert.ToDouble(Console.ReadLine()); 

// Console.WriteLine("Для того чтобы узнать точку пересечения заданных функций введите коэффициент k1 ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Теперь введите коэффициент k2 ");
// int k2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Далее введите коэффициент b1 ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" и коэффициент b2 ");
// int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"k1 = {k1}, k2 = {k2}, b1 = {b1}, b2 = {b2} - ");
bool parall = ParallelismCheck(k1, k2);
bool coincidence = Сoincidence (k1, k2, b1, b2);

if (parall==true) 
  if(coincidence==true) Console.WriteLine("Прямые совпадают");
  else Console.WriteLine("Прямые параллельны");
else {
    double[] coord = IntersectionPointCoordinate(k1, k2, b1, b2);
PrintArray(coord);
}


// string output = Сoincidence (k1, k2, b1, b2 )? "Прямые совпадают":ParallelismCheck(k1, k2)? "Прямые параллельны" : "->";
// Console.Write(output);




bool ParallelismCheck(double a1, double a2)
{
    return (a1 == a2);
}

bool Сoincidence (double a1, double a2, double c1, double c2 )
{
return (c1 == c2);
}






// Console.WriteLine(ParallelismCheck(k1, k2)? "Графики параллельны":"");




// double[] EnteringCoefficients()
// {
//     double[] arr = new double[4];

//     Console.WriteLine("Для того чтобы узнать точку пересечения заданных функций введите коэффициент k1 ");
//         arr[0] = Convert.ToDouble(Console.ReadLine());
//         Console.WriteLine("Теперь введите коэффициент k2 ");
//         arr[1] = Convert.ToDouble(Console.ReadLine());
//     if (arr[0] = arr[1]);
//         {
//             Console.WriteLine("ПРямые параллелььны");
//          EnteringCoefficients();
//         }
//     Console.WriteLine("Далее введите коэффициент b1 ");
//         arr[2] = Convert.ToDouble(Console.ReadLine());
//         Console.WriteLine(" и коэффициент b2 ");
//         arr[3] = Convert.ToDouble(Console.ReadLine()); 
//    return arr;
// }

double[] IntersectionPointCoordinate(double a1, double a2, double c1, double c2)
{
    double[] array = new double[2];

    array[0] = Math.Round((c2 - c1) / (a1 - a2), 2);
    array[1] = Math.Round((a1*array[0] + b1), 2);

    return array;
}

void PrintArray(double[] arr)
{
    Console.Write("(");

    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}; ");
        else
            Console.Write($"{arr[i]}");
    }
    Console.Write(")");
}
