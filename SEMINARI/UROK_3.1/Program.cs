﻿//17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//  причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.Write("Введите значение координаты x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение координаты y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// int result = 0;

// if (x > 0 && y > 0) result = 1;
// else if (x < 0 && y > 0) result = 2;
// else if (x < 0 && y < 0) result = 3;
// else if (x > 0 && y < 0) result = 4;
// else Console.WriteLine("Точка лежит на оси координат");

// System.Console.WriteLine($"Точка лежит в {result} четверти");



//Задача 18: Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).


// Console.Write("Введите номер четверти: ");
// int quarter = Convert.ToInt32(Console.ReadLine());

// string result = "";
// if (quarter == 1) result = "x > 0, y > 0";
// else if (quarter == 2) result = "x < 0 , y > 0";
// else if (quarter == 3) result = "x < 0 , y < 0";
// else if (quarter == 4) result = "x > 0 , y < 0";
// else System.Console.WriteLine("Неверно введена четверть");
// Console.WriteLine(result);





// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Console.Write("Введите значение координаты x первой точки: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение координаты y первой точки: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение координаты x второй точки: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение координаты y второй точки: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// int sum = ((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1));
// double distance = Math.Round(Math.Sqrt(sum),2);

// System.Console.WriteLine($"Расстояние между точками = {distance}");



// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// while (i <= num)
//  {
//     if (i % 1 != 1)
//     {
//         Console.Write(i * i + ",");
//     }
//  i ++;
// }
