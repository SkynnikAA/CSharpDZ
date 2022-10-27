// Console.Clear();
// int x = 6;
// string s = "это строка";

// Console.Write("Ведите число ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Х равен: " + x);
// Console.WriteLine("вы ввели " + y);
// Console.WriteLine($" Сумма Y + Х = {y+x}");


// напишите программу, которая на вход принимает число и выдает его квадрат

// Console.Clear();

// Console.Write("Ведите число : ");
// int y = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("квадрат = " + y*y);




// // напишите программу, которая на вход принимает число и выдает его квадрат если число меньше 5, 
// // в куб если число больше 5

// Console.Clear();

// Console.Write("Ведите число : ");
// int y = Convert.ToInt32(Console.ReadLine());
// if (y>5)    //  если
// {
// System.Console.WriteLine("куб = " + y*y*y); 
// }
// else    // иначе
// System.Console.WriteLine("квадрат = " + y*y);   // если 1 строчка кода {}не нужны


// // 1. Напишите программу, которая на вход принимает два числа и проверяет, 
// // является ли первое число квадратом второго.
// // a = 25, b = 5 -> да
// // a = 2, b = 10 -> нет
// // a = 9, b = -3 -> да
// // a = -3 b = 9 -> нет

// Console.Clear();

// Console.Write("Ведите первое число : ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ведите второе число : ");
// int y = Convert.ToInt32(Console.ReadLine());
// if (y * y == x)
//     Console.Write("Да ");
// else
//     Console.Write("Нет ");



// // 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// // 3 -> Среда
// // 5 -> Пятница

// Console.Clear();

// Console.Write("Ведите номер дня недели : ");
// int x = Convert.ToInt32(Console.ReadLine());
// if (x == 1) Console.Write("понедельник ");
// if (x == 2) Console.Write("вторник ");
// if (x == 3) Console.Write("среда ");
// if (x == 4) Console.Write("четверг ");
// if (x == 5) Console.Write("пятница ");
// if (x == 6) Console.Write("суббота ");
// if (x == 7) Console.Write("воскресение ");
// else if (x > 7) Console.Write("не корректный ввод ");



// // 5. Напишите программу, которая на вход принимает одно число (N),
// // а на выходе показывает все целые числа в промежутке от -N до N.
// // 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// // 2 -> " -2, -1, 0, 1, 2"

// Console.Clear();

// Console.Write("Ведите число : ");
// int n = Convert.ToInt32(Console.ReadLine());
// int n2 = -n ;
// while (n2<=n)  // до тех пор пока 
// {
// Console.Write($" {n2} ");
// n2 ++;
// }



// // ВАРИАНТ 2 выводит включая отрицательные числа


// Console.Clear();

// Console.Write("Ведите число : ");
// int n = Convert.ToInt32(Console.ReadLine());
// int n2 = 0 ;
// if (n>0)    // если 
// {
//     n2 = n*-1;  // выполнять
//     while ( n2<=n)  // до тех пор пока 
//     {
//         System.Console.Write($" {n2} ");
//         n2++;
//     }
// }
// else   // иначе 
// {
//     n2 = n* -1;
//         while ( n<=n2)  // до тех пор пока 
//     {
//         System.Console.Write($" {n} ");
//         n++;
//     }
// }





// // 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// // 456 -> 6
// // 782 -> 2
// // 918 -> 8

// Console.Clear();

// Console.Write("Ведите число : ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("последняя цифра числа: " + n%10);


// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

// Console.Clear();

// Console.Write("Ведите числа : ");
// int n = Convert.ToInt32(Console.ReadLine());
// int n2 = Convert.ToInt32(Console.ReadLine());

// if (n2<n) Console.Write($"первое число больше {n} ");// до тех пор пока 

// Console.Write($"второе число больше {n2} ");





// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// // 2, 3, 7 -> 7
// // 44 5 78 -> 78
// // 22 3 9 -> 22

// Console.Clear();

// Console.Write("Ведите числа : ");
// int n = Convert.ToInt32(Console.ReadLine());
// int n2 = Convert.ToInt32(Console.ReadLine());
// int n3 = Convert.ToInt32(Console.ReadLine());
// int max = n;
// if (n2>max) max = n2;
// if (n3>max) max = n3;
// Console.Write($"MAX : {max} ");


// // ВАРИАНТ 2 на 1 строчку кода меньше

// Console.Clear();

// Console.Write("Ведите числа : ");
// int n = Convert.ToInt32(Console.ReadLine());
// int n2 = Convert.ToInt32(Console.ReadLine());
// int n3 = Convert.ToInt32(Console.ReadLine());
// if (n2>n) n = n2;
// if (n3>n) n = n3;
// Console.Write($"MAX : {n} ");






// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// // 4 -> да
// // -3 -> нет
// // 7 -> нет

// Console.Clear();

// Console.Write("Ведите число : ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n % 2 == 0) Console.WriteLine("число четное" ); //проверка на четность, если остаток от деления на 2 равен нулю то четное
// else Console.WriteLine("число не четное" );





// // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// // 5 -> 2, 4
// // 8 -> 2, 4, 6, 8

// Console.Clear();

// Console.Write("Ведите число : ");
// int n = Convert.ToInt32(Console.ReadLine());
// int i =0;
// while (i<=n)
// {
//     if (i % 2 == 0)
//     {
//     Console.Write($"{i} " );
//     }
//     i++;
// }
