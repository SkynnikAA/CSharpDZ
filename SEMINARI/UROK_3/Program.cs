// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

Console.Write( "введите число х:");
int x = Convert.ToInt32(Console.ReadLine);

Console.Write( "введите число y:");
int y = Convert.ToInt32(Console.ReadLine);

int result=0;
if(x>0 && y>0) result =1;
else if (x<0 && y>0) result =2;
else if (x<0 && y<0) result =3;
else if (x> 0 && y<0) result =4;
else Console.WriteLine( "точка в четверти ");
System.Console.WriteLine( $"точка лежит в{result} четверти ");  //System это класс командв не влияет на код sw клавиши



// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).


// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
