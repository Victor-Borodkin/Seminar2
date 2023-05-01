// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трезхначное число");
// int Number1 = Convert.ToInt32(Console.ReadLine());
// int Number2 = Number1 % 100;
// int Number3 = Number2 / 10;
// Console.WriteLine($"{Number3}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


// Console.WriteLine("Введите число");
// int Number1 = Convert.ToInt32(Console.ReadLine());
// if (Number1 / 100 == 0 )
// {
//     Console.WriteLine("третьей цифры нет");
// }
// else
// {
//     while(Number1 / 1000 >0)
//     {
//         Number1 = Number1 / 10;
//     }
//     Console.WriteLine(Number1 % 10);
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введите день недели: ");
// int day = Convert.ToInt32(Console.ReadLine());

// if (day > 0 && day < 8)
// {
// if (day == 1)
// {
// Console.WriteLine("нет");
// }
// if (day == 2)
// {
// Console.WriteLine("нет");
// }
// if (day == 3)
// {
// Console.WriteLine("нет");
// }
// if (day == 4)
// {
// Console.WriteLine("нет");
// }
// if (day == 5)
// {
// Console.WriteLine("нет");
// }
// if (day == 6)
// {
// Console.WriteLine("да");
// }
// if (day == 7)
// {
// Console.WriteLine("да");
// }
// }
// else
// {
// Console.WriteLine("Это не день недели");
// }
