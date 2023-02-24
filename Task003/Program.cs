Console.WriteLine("Введите число дня недели");
int numWeek = Convert.ToInt32(Console.ReadLine());

if (numWeek == 1) Console.WriteLine("Понедельник");
else if (numWeek == 2) Console.WriteLine("Вторник");
else if (numWeek == 3) Console.WriteLine("Среда");
else if (numWeek == 4) Console.WriteLine("Четверг");
else if (numWeek == 5) Console.WriteLine("Пятница");
else if (numWeek == 6) Console.WriteLine("Суббота");
else if (numWeek == 7)Console.WriteLine("Воскресенье");
else  Console.WriteLine("Не существует дня недели под этим номером"); 



// if (numWeek == 1)
// {
//  Console.WriteLine("Понедельник");   
// }
// else
// {
//     if (numWeek == 2)
//     {
//       Console.WriteLine("Вторник");  
//     }
//     else
//     {
//         if (numWeek == 3)
//         {
//           Console.WriteLine("Среда");  
//         }
//         else
//         {
//             if (numWeek == 4)
//             {
//                 Console.WriteLine("Четверг");
//             }
//             else
//             {
//                 if (numWeek == 5)
//                 {
//                     Console.WriteLine("Пятница");
//                 }
//                 else
//                 {
//                     if (numWeek == 6)
//                     {
//                         Console.WriteLine("Суббота");
//                     }
//                     else
//                     {
//                         if (numWeek == 7)
//                         {
//                             Console.WriteLine("Воскресенье");
//                         }
//                         else
//                         {
//                             Console.WriteLine("Не существует дня недели под этим номером");
//                         }
//                     }
//                 }
//             }
//         }
//     }
// }