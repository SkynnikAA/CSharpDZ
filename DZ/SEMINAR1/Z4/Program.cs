// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
int max = 0;     // лучше использовать max = a, получается на 1 действие меньше, и будет работать с отрицательными числами
Console.WriteLine("Ведите a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите b:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите c:");
int c = Convert.ToInt32(Console.ReadLine());

if(a > max) max = a ;
if(b > max) max = b ;
if(c > max) max = c ;

Console.WriteLine($"max = {max}");
