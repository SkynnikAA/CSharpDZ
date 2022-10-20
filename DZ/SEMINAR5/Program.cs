// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите 
// // программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

// Console.Clear();
// int[] CreateArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//         for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return array;
// }
//  void PrintArray(int[] array)
//  {
//     Console.Write("Созданный массив: { ");
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine("}.");
//  }
// int AmountEvenNumbers(int[] array)
// {
//     int amount = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0) 
//             amount++;
//     }
//     return amount;
// }
// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите начальный элемент диапвзона, от: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите конечный элемент диапазона, до: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[] yourArray = CreateArray(size, minValue,maxValue);
// PrintArray(yourArray);
// int result = AmountEvenNumbers(yourArray);
// Console.WriteLine($"Количество четных чисел в массиве = {result}.");




// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// // стоящих на нечётных позициях. [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0

// Console.Clear();
// int[] CreateArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//         for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return array;
// }
//  void PrintArray(int[] array)
//  {
//     Console.Write("Созданный массив: { ");
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine("}.");
//  }
// int SumUnevenIndexNums(int[] array)
// {
//     int sum = 0;
//     for(int i = 1; i < array.Length; i += 2)
//         sum = sum + array[i];
//     return sum;
// }
// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите начальный элемент диапвзона, от: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите конечный элемент диапазона, до: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[] yourArray = CreateArray(size, minValue,maxValue);
// PrintArray(yourArray);
// int result = SumUnevenIndexNums(yourArray);
// Console.WriteLine($"Сумма нечетных элементов = {result}.");



// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
// // элементов массива. [3 7 22 2 78] -> 76

// Console.Clear();
// double[] CreateArray(int size)
// {
//     double[] array = new double[size];
//         for(int i = 0; i < size; i++)
//     {
//         Console.Write($"Введите {i+1} элемент : ");
//         array[i] = Convert.ToDouble(Console.ReadLine());
//     }
//     return array;
// }
//  void PrintArray(double[] array)
//  {
//     Console.Write("Созданный массив: { ");
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine("}.");
//  }
// double DifMaxMin(double[] array)
// {
//     double dif = 0;
//     double min = array[0];
//     double max = array[0];
//     for(int i = 1; i < array.Length; i++)
//     {
//         if(array[i] > max)
//             max = array[i];
//         else if(array[i] < min)
//             min = array[i];
//         dif = max - min;
//     }
//     Console.WriteLine($"Максимальный элемент массиве = {max}.");
//     Console.WriteLine($"Миниимальный элемент массиве = {min}.");
//     return dif;
// }
// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] yourArray = CreateArray(size);
// PrintArray(yourArray);
// double result = DifMaxMin(yourArray);
// Console.WriteLine($"Разница между максимальными и минимальными элементами массива = {result}.");

