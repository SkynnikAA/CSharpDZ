// методы (функции)

// void SayHello()
// {
// System.Console.WriteLine("hello c#");
// }
// System.Console.WriteLine("1");
// SayHello();
// System.Console.WriteLine("2");
// SayHello();
// System.Console.WriteLine("3");
// SayHello();



// void SayHello(string lang)
// {
// System.Console.WriteLine("hello {lang}");
// }
// System.Console.WriteLine("1");
// string name1="hsah";
// SayHello("C++");
// System.Console.WriteLine("2");
// string name2="payton";
// SayHello("Jawa");
// System.Console.WriteLine("3");
// string name3="ghjgxkjc";
// SayHello("C#");







// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


/*// void Sum(int A)
// {
//     int sum=0;
//     for (int i = 1; i <= A; i++)
//     {
//         sum=sum+i;
//     }
//     Console.WriteLine(sum);
// }
// int A=new Random().Next(2,5);
// Console.WriteLine(A);
// Sum(A);
*/

// void Numbers(int n)
// {
//     int i = 0;
// while(n > 0)
//     {
//     n = n / 10;
//     i++;
//     }
// Console.WriteLine("Количество цифр равно:" + i);
// }

// Numbers(456);
// Numbers(78);
// Numbers(89126);



// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5*/




// //Console.Clear;
// System.Console.WriteLine("Введите число");
// int chislo = Convert.ToInt32(Console.ReadLine());
// int i = 0;
// while ( chislo > 0)
//     {
//         chislo = chislo / 10;
//         i++;
//     }   
// System.Console.WriteLine(i);




// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

//Console.Clear;
// System.Console.WriteLine("Введите число");
// int chislo = Convert.ToInt32(Console.ReadLine());
// int i = 0;
// while ( chislo + i )
//     {
//         chislo = chislo + i;
//         i++;
//     }   
// System.Console.WriteLine(i);






/*// System.Console.WriteLine("Введите число");
// int A = Convert.ToInt32(Console.ReadLine());
// void Sum(int A)
// {
//     int sum=1;
//     for (int i = 1; i <= A; i++) // 
//     {
//         sum=sum*i;
//     }
//     Console.WriteLine(sum);
// }
// //int A=new Random().Next(2,5);
// //Console.WriteLine(A);
// Sum(A);
*/




// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] arrey = new int[8];
// //int A=new Random().Next(0,2);
// void Print(int[] arrey)
// {    
//     for (int i = 0; i < arrey.Length; i++) // 
//     {
//         Console.Write(arrey[i]);
//     }
// }
// void Random(int[] arrey)
// {    
//     for (int i = 0; i < arrey.Length; i++) // 
//     {
//         arrey[i] = new Random().Next(0,2);
//     }
// }

// Random(arrey);
// Print (arrey);

// ** Задача **   (x1 ^ 5) + (x2 ^ 5) + (x3 ^ 5) + (x4 ^ 5) = (x5 ^ 5)      в диапазоне   1->300
// это функция возведения числа в 5 степень: Math.Pow(i, 5). Получается нам надо все числа сложить в этой степени, верно?







