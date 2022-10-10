// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Ведите a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите b:");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"max a = {a}");
}
else
{
    Console.WriteLine($"max b = {b}");
}
// в примере не указан вывод мин, только мах,- требуется уточнение)