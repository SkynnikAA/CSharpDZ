// МЕТОД 1

// void Method1()
// {
//     System.Console.WriteLine("Автор");
// }
// Method1();



//======================
// МЕТОД 2

// void Method2(string msg)
// {
//     System.Console.WriteLine(msg);
// }
// Method2( msg:"текст сообщения");


// вариант 2

// void Method21(string msg, int count)
// {
//    int i = 0;
//    while (i<count)
//    {
//     System.Console.WriteLine(msg);
//     i++;
//    }
// }
// Method21( msg: "текст " , count: 4 );
// Method21( count: 4 , msg: "новый текст "); // можно и так, не важно в каком порядке


//========================
// МЕТОД 3


// int Method3()
// {
//    return DateTime.Now.Year;
// }
// int year = Method3();
// System.Console.WriteLine(year);


//=============================
// МЕТОД 4 чтото принимает и чтото возвращает

// string Method4(int count, string text)
// {
//    int i = 0;
//    string result = String.Empty; // String.Empty;  ОЗНАЧАЕТ ЧТО ИСПОЛЬЗУЕТСЯ ПУСТОЕ ЗНАЧЕНИЕ
//       while (i<count)
//       {
//          result = result + text;
//          i++;
//       }
//       return result;

// }
// string res = Method4(6, "qwerty");
// System.Console.WriteLine(res);


// вариант 2

// string Method41(int count, string text)
// {

//     string result = String.Empty; // String.Empty;  ОЗНАЧАЕТ ЧТО ИСПОЛЬЗУЕТСЯ ПУСТОЕ ЗНАЧЕНИЕ
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;

// }
// string res = Method41(6, "qwerty");
// System.Console.WriteLine(res);


// ПРИМЕР таблица умножения

// for (int i = 2; i <= (9); i++)
// {
//    for (int j = 2; j <= 9; j++)
//    {
//       System.Console.WriteLine($"{i} x {j} = {i*j}");
//    }
//    System.Console.WriteLine();
// }

//================ РАБОТА С ТЕКСТОМ
// ЗАДАЧА: Дан текст. в тексте нужно все пробелы заменить черточками, 
// маленькие буквы "к" заменить большими "К", большие "С" на маленькие "с".

// string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие проусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";
//             // ПРИМЕР
//             // string s = "qwerty"
//             //             012
//             // s[3] = r 
// string Replace(string text, char oldValue, char newValue) // char oldValue, char newValue переменные для замены символов
// {
//    string result = String.Empty; // String.Empty;  ОЗНАЧАЕТ ЧТО ИСПОЛЬЗУЕТСЯ ПУСТОЕ ЗНАЧЕНИЕ
//    int length = text.Length;
//    for (int i = 0; i<length; i++)
//    {
//       if(text [i] == oldValue) result = result + $"{newValue}";
//       else result =  result + $"{text [i]}";
//    }
//    return result;
// }
// string newText = Replace(text,' ', '|' );
// System.Console.WriteLine(newText);
// System.Console.WriteLine();
// newText = Replace(text,'к', 'К' );
// System.Console.WriteLine(newText);


//=============================

// int[] arr = {1,5,4,3,2,6,7,1,1};
// void PrintArray(int[] array)
// {
//    int count = array.Length;
//    for ( int i = 0; i<count; i++)
//    {
//       System.Console.Write($"{array [i]}  ");
//    }
//    System.Console.WriteLine();
// }
// void SelectionSort(int[] array)
// {
//    for (int i = 0; i< array.Length -1 ; i++)
//    {
//       int minPosition =i;

//       for (int j = i+1; j < array.Length; j++)
//       {
//          if(array[j] < array[minPosition]) minPosition = j;
//       }

//       int temporary = array[i];
//       array[i] = array[minPosition];
//       array[minPosition] = temporary;
//    }

// }

// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);

// ДЗ РАЗВЕРНУТЬ МАССИВ ( ВЫВЕСТИ С НАЧАЛА САМЫЙ БОЛЬШОЙ)

int[] arr = {1,5,8,3,2,6,7,4,9};
void PrintArray(int[] array)
{
   int count = array.Length;
   for ( int i = 0; i<count; i++)
   {
      System.Console.Write($"{array [i]}  ");
   }
   System.Console.WriteLine();
}
void SelectionSort(int[] array)
{
   for (int i = 0; i < array.Length -1 ; i++)
   {
      int minPosition =i;

      for (int j = i+1; j < array.Length; j++)
      {
         if(array[j] > array[minPosition]) minPosition = j;
      }

      int temporary = array[i];
      array[i] = array[minPosition];
      array[minPosition] = temporary;
   }

}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);