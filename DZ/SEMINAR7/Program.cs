// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
// // m = 3, n = 4.
// // 0,5 7 -2 -0,2
// // 1 -3,3 8 -9,9
// // 8 7,8 -7,1 9
// Console.Clear();

// double[,] CreateRandomDouble2Array()
// {
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите минимально возможное значение: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимально возможное значение: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
//     double[,] array = new double[rows, columns];
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = Math.Round((rand.Next(minValue, maxValue) + rand.NextDouble()), 1);
//     return array;
// }
// void Print2DoubleArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + "  ");
//         Console.WriteLine();
//     }
// }
// double[,] myArray = CreateRandomDouble2Array();
// Print2DoubleArray(myArray);



// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// // значение этого элемента или же указание, что такого элемента нет.
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 17 -> такого числа в массиве нет

// Console.Clear();
// int[,] CreateRandom2Array()
// {
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите минимально возможное значение: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимально возможное значение: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }

// void Print2Array(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");

//         Console.WriteLine();
//     }
// }

// void FindElement(int[,] array)
// {
//     Console.Write("Введите индекс 'i' элемента: ");
//     int i = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите индекс 'j' элемента: ");
//     int j = Convert.ToInt32(Console.ReadLine());
//     if ((i >= 0 && i < array.GetLength(0)) && (j >= 0 && j < array.GetLength(1)))
//         Console.WriteLine($"Элемент с индексами [{i},{j}] = {array[i, j]}");
//     else
//         Console.WriteLine("Нет элемента с такими индексами.");
// }

// int[,] myArray = CreateRandom2Array();
// Print2Array(myArray);
// FindElement(myArray);




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

// Console.Clear();
// int[,] myArray = CreateRandom2Array();
// Print2Array(myArray);
// int[,] CreateRandom2Array()
// {
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите минимально возможное значение: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимально возможное значение: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }
// double[] FindColumnsElementsAverage(int[,] array)
// {

//     double[] newarray = new double[array.GetLength(1)];
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double sum = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//             sum = sum + array[i, j];
//         newarray[j] = Math.Round((sum / array.GetLength(0)),1);
//     }  
//     return newarray;
// }

// void PrintArray(double[] array)
// {
//     Console.Write("Среднее значение столбцов : { ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + "  |  "); // как в выводе последнего среднего значения сделать чтобы в конце не ставил " | " ?
//     }
//     Console.WriteLine("}.");
// }

// void Print2Array(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + "  |  ");

//         Console.WriteLine();
//     }
// }

// double[] newarray = FindColumnsElementsAverage(myArray);
// PrintArray(newarray);

