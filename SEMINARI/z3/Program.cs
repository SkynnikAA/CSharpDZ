/*7. Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8
*/
//Console.Clear();
//int x ;
//Console.Write("Ведите число ");

// Console.ReadLine();
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// if (x/100)
// {
// Console.Write(x);
// }

//из семинара

Console.Clear();

Console.Write("Ведите число ");

int num = Convert.ToInt32(Console.ReadLine());
int num2 = num % 10;
Console.WriteLine(num2);

