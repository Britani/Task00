// 0. Демонстрация решения
//Написать программу 
// 1.принемает на вход 2 числа
// 2. проверяет условие что первое это квадрат второго
// 3. На выходе 2 варианта является, не является

// Например:
// a =25 b=5 -> Да
// a =-9 b=3 -> Нет
// a =5 b=25 -> Нет

Console.WriteLine("Введите первое число ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA % (numberB*numberB) == 0)
{
 Console.WriteLine(numberA + " является квадратом числа " + numberB);  
}

else
{
 Console.WriteLine(numberA + " не является квадратом числа " + numberB);  
}
//if(numberA/numberB*numberB == index);
   //Console.WriteLine(numberA + " является квадратом числа " + numberB);  

//else
  // Console.WriteLine(a + "не является квадратом числа " + b);

//Console.WriteLine($"Квадрат числа {number} = {square}"); // интерполяция, с помощью $
//Console.WriteLine("Квадрат числа" + number + "=" + square); // конкатенация, склеивание строк с помощью + и ""

