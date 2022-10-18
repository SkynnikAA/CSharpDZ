// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int oldNumber = number;     // oldNumber первоначальное число 
int newNumber = 0;          // newNumber новое число
while (number > 0)
{
    int x = number % 10;   // пример 123 % 10, отсекам 3
    newNumber = newNumber * 10 + x;   // 0*10=0 +"3"
    number = number / 10;    // сокращаем число на 1 разряд каждый цикл
}
if (oldNumber == newNumber)      // проверка равны ли числа 
    Console.WriteLine($"Число {oldNumber} является полиндромом");
else
    Console.WriteLine($"Число {oldNumber} не является полиндромом");






// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Clear();
// System.Console.WriteLine("Введите координаты первой точки: х, у, z ");
// int[] pixel1 = new int[3];
// pixel1[0] = Convert.ToInt32(Console.ReadLine());
// pixel1[1] = Convert.ToInt32(Console.ReadLine());
// pixel1[2] = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите координаты второй точки: х, у, z ");
// int[] pixel2 = new int[3];
// pixel2[0] = Convert.ToInt32(Console.ReadLine());
// pixel2[1] = Convert.ToInt32(Console.ReadLine());
// pixel2[2] = Convert.ToInt32(Console.ReadLine());

// double n = 0;
// for (int i = 0; i < pixel1.Length; i++)
// {
//     for (i = 0; i < pixel2.Length; i++)
//     {
//         double n1 = Math.Pow(pixel1[i] - pixel2[i], 2);
//         n = n + n1;
//     }
// }
// System.Console.WriteLine(n);
// double dist = Math.Round(Math.Sqrt(n), 2);   //округлить и оставить 2 знака после запятой, корень от (Х), 2 знака после запятой
// System.Console.WriteLine($"Растояние между точками {dist}");



// // Задача 23
// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125

// Console.Clear();
// System.Console.WriteLine("Ведите число N : ");
// int N = Convert.ToInt32(Console.ReadLine()); 
// // считываем число из терминала , преобразуем число в строку, и записываем в N
// for (int i = 1; i <= N; i++) System.Console.WriteLine(Math.Pow(i, 3) + " ");
// // в цикле от 1 до N , каждое число возводим в 3 степени . Math.Pow(i, 3) число возводит в степень 
// System.Console.WriteLine();

