// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.Clear();

// int AmountPositiveNums(int amountNum)
// {
//     int count = 0; 
//     for(int i = 1; i <= amountNum; i++)
//     {
//         Console.Write($"Введите {i} число: ");
//         double num = Convert.ToDouble(Console.ReadLine());
//         if(num>0) count++;
//     }
//     return count;
// }

// Console.Write("Сколько будет чисел ? : ");
// int amountNum = Convert.ToInt32(Console.ReadLine());
// int result = AmountPositiveNums(amountNum);
// Console.WriteLine($"Количество положительных чисел = {result}");


// ВАРИАНТ 2


// Console.WriteLine("Введите числа через запятую");
// int[] Arrey = Array.ConvertAll(Console.ReadLine().Split(','), Convert.ToInt32);    // вводим М элементов, делим строку для ввода через запятую , конвертруем строку в числы
// int М = Arrey.Count(x => x > 0);                                                  // Считаем сколько М элементов > 0 , ставим => чтобы выводил 0
// Console.WriteLine($"Кол-во элементов больше 0: {М}");                             // выводим решение]


// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// // y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Console.Clear();
// double[] IntersectionLines(double b1, double k1, double b2, double k2)
// {
//     double[] array = new double[2];
//     array[0] = (b2-b1)/(k1-k2);
//     array[1] = k1 * array[0] + b1;
//     return array;
// }

// void PrintIntersection(double[] array)
// {
//     Console.Write($"Точка пересечения = [{array[0]}; {array[1]}].");
// }

// Console.Write("Введите b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());
// if(k1 == k2) Console.WriteLine("Точки пересечения нет.");
// else
// {
//     double[] result = IntersectionLines(b1,k1,b2,k2);
//     PrintIntersection(result);
// }