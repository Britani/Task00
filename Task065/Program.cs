// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void ShowNumbers(int firstNum, int secondNum)
{
    //if (firstNum < secondNum)
    // {
        if (secondNum == firstNum - 1) return;
        ShowNumbers(firstNum, secondNum - 1);
        Console.Write($"{secondNum} ");
    // }
    else if (firstNum > secondNum)
    {
        //if (secondNum - 1 == firstNum) return;
        Console.Write($"{firstNum} ");
        ShowNumbers(firstNum - 1, secondNum);
    }
    else 
        Console.Write($"{firstNum} ");
       // return;
    //}
}

Console.Write("Введите первое натуральное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Числа от {numberM} до {numberN}: ");
ShowNumbers(numberM, numberN);




///////////////////////////////

// string NumberRec(int a, int b)
// {
//     if (a>b)
//     {
        
//     }
// }

