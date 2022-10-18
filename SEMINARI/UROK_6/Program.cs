






// // /*Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// // [1 2 3 4 5] -> [5 4 3 2 1]
// // [6 7 3 6] -> [6 3 7 6]*/

// Console.WriteLine("Введите размер массива: ");
// int l = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[l];
// int temp = 0;
// Console.WriteLine("Исходный массив: ");
// for (int j = 0; j < array.Length; j++)
// {
//     array[j] = new Random().Next(0, 10);
//     Console.Write($"{array[j]} ");
// }

// Console.WriteLine("Развернутый массив: ");
// for (int i = 0; i < array.Length / 2; i++)
// {
//     temp = array[i];
//     array[i] = array[array.Length - 1 - i];
//     array[array.Length - 1 - i] = temp;
// }

// for (int j = 0; j < array.Length; j++)
// {
//     Console.Write($"{array[j]} ");
// }
// Console.WriteLine();


// /* Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//  Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон*/

// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2) Console.WriteLine("Такой треугольник может быть"); 
// else Console.WriteLine("Такой треугольник не может быть");



// /*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
//решение через строки */

            // Console.Write("Введите число: ");
            // int decimalNumber = int.Parse(Console.ReadLine());   // Parse проеобразует строку 

            // int remainder;
            // string result = string.Empty;
            // while (decimalNumber > 0)
            // {
            //     remainder = decimalNumber % 2;
            //     decimalNumber /= 2;
            //     result = remainder.ToString() + result;
            // }
            // Console.WriteLine("Число в двоичном коде:  {0}",result);





// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


// System.Console.WriteLine("Введите число: ");
// int fib = Convert.ToInt32(Console.ReadLine());

// int[] fibo = new int[fib];
// fibo[0] = 0;
// fibo[1] = 1;
// for (int i = 2; i < fibo.Length; i++)
// {
//     fibo[i] = fibo[i-1] + fibo[i-2];
// }

// for (int j = 0; j < fibo.Length; j++)
// {
//        System.Console.Write($"{fibo[j]} ");
// }


// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
// РЕШЕНИЕ: создать второй массив и по индекно его скопировать

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
