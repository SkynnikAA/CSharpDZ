// пример сложения строк
string s1 = "C#";
string s2 = "Python";
string s3 = s1 + s2;
string s4 = s1 + " - " + s2;
string s5 = string.Concat(s1, s2, s3);  // сложение строк вариант 1 
string s6 = "Jawa";
string s7 = "C++";
string s8 = "JS";
System.Console.WriteLine(s3);
System.Console.WriteLine(s4);
System.Console.WriteLine(s5);
System.Console.WriteLine(s2.Length);
System.Console.WriteLine(s2[2]); // второй индекс = t
// сложение строк вариант 2
string[] array = new string[] {s1, s2, s6, s7, s8};  //создаем массив строк {задаем значения в массиве}
string s9 = string.Join(" ", array); //  Join объеденяет элементы в 1 строчку
System.Console.WriteLine(s9);