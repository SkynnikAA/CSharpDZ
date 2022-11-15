// //Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


// Console.WriteLine("Введите натуральное число больше 1:");
// int number = int.Parse(Console.ReadLine());

// ///Метод вывода натуральных чисел от N до 1:
// void NumberCounter (int number)
// {
//     if (number < 0) Console.Write($"{number} не натуральное число");
//     if (number == 0) return;
//     Console.Write("{0,4}", number);
//     NumberCounter (number - 1);
// }

// NumberCounter(number);



// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


// int findSum(int m, int n)
// {
//     int max = m;
//     int min = n;
//     int sum = 0;

//     if (n > m)
//     {
//         max = n;
//         min = m;
//     }
//     if (min == max) sum += min;
//     else sum += min + findSum(min+1, max);
//     return sum;
// }

// System.Console.Write("Введите M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(findSum(M,N));




// //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


// long akkerman(long n, long m)
// {
//   if (n == 0)
//     return m + 1;
//   else
//     if (m == 0)
//       return akkerman(n - 1, 1);
//     else
//       return akkerman(n - 1, akkerman(n, m - 1));
// }


// System.Console.Write("Введите M: ");
// long M = Convert.ToInt64(Console.ReadLine());
// System.Console.Write("Введите N: ");
// long N = Convert.ToInt64(Console.ReadLine());

// System.Console.WriteLine($"Функция Аккермана равна: {akkerman(M,N)}");