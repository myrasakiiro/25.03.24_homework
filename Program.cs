﻿// Задача 1: 
// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

// a=50 => нет
// a=7 => нет
// a=322 => да

// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number % 7 == 0 && number % 23 == 0)
// {
//     System.Console.Write("Да");
// }
// else
// {
//     System.Console.Write("Нет");
// }


// Задача 2: Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
// 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

// 2, 3 => 1
// -5, 3 => 2
// -3, -2 => 3
// 4, -2 => 4

// System.Console.Write("Введите координату X: ");
// int X = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите координату Y: ");
// int Y = Convert.ToInt32(Console.ReadLine());

// if(X > 0 && Y > 0)
// {
//     System.Console.Write("1");
// }
// else if(X < 0 && Y > 0)
// {
//     System.Console.Write("2");
// }
// else if(X < 0 && Y < 0)
// {
//     System.Console.Write("3");
// }
// else if(X > 0 && Y < 0)
// {
//     System.Console.Write("4");
// }
// else
// {
//     System.Console.Write("Точка находится на оси координат");
// }


// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

// 40 => 4
// 96 => 9
// 72 => 7


// System.Console.Write("Введите целое число от 10 до 99: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number > 10 && number < 99)
// {
//     int leftDigit = number / 10;
//     int rihgtDigit = number % 10;
//     if (leftDigit > rihgtDigit)
//     {
//         System.Console.Write(leftDigit);
//     } 
//     else
//     {
//         System.Console.Write(rihgtDigit);
//     }
// }
// else 
// {
//     System.Console.WriteLine("Вы ввели не правильное число! ");
// }

