
// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int APowB(int a, int b)
{
    int res = 1;
    for (int i = 0; i < b; i++)
        res *= a;
    return res;
}

void CallAPowB() // вспомогательный метод с запросом данных и выводом в терминал.
{
    Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
    Console.Write("Введите первое число >: ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число >: ");
    int numberB = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{numberA}^{numberB} = {APowB(numberA, numberB)}");
}
CallAPowB();

// // // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// int SumOfDigits(int num) // принимает целое число, возвращает сумму цифр введенного числа
// {
//     int res = 0;
//     if (num < 0) num *= -1;

//     while (num > 0)
//     {
//         res += num % 10;
//         num /= 10;
//     }

//     return res;
// }

// void CallSumOfDigits() // вспомогательный метод с запросом данных и выводом в терминал.
// {
//     Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
//     Console.Write("Введите число >: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine($"Сумма цифр числа {number} равна {SumOfDigits(number)}.");
// }
// CallSumOfDigits();

// // Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// int[] MakeIntArray(int size, int minValue, int maxValue) // принимает целое число в качестве размера массива, верхнюю и нижнюю границу для генерации чисел, возвращает массив заданного размера, заполненный случайными числами от нижней до верхней границы чисел включительно.
// {
//     int[] array = new int[size];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void PrintIntArray(int[] array) // печать массива, состоящего из int элементов
// {
//     Console.Write("{ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]);
//         if (i < array.Length - 1) // ставим запятую после элемента, если это не последний элемент
//             Console.Write(", ");
//     }
//     Console.WriteLine(" }");
// }

// void CallMakeIntArray() // вспомогательный метод с запросом данных и выводом в терминал.
// {
//     Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.");
//     Console.Write("Введите размер массива >: ");
//     int arrSize = Convert.ToInt32(Console.ReadLine());
//     while (arrSize < 0)
//     {
//         Console.WriteLine("ОШИБКА! Размер массива не может быть отрицательным!");
//         Console.Write("Введите размер массива (неотрицательное число) >: ");
//         arrSize = Convert.ToInt32(Console.ReadLine());
//     }

//     Console.Write("Введите нижнюю границу для генерации чисел >: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Введите верхнюю границу для генерации чисел >: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     PrintIntArray(MakeIntArray(arrSize, minValue, maxValue));
// }
// CallMakeIntArray();

