void FillArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}
void PrintArray(int[]col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int Indexof(int [] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // если искомого элемента нет выводим позицию -1
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int[10];  // new int[10] создает массив в котором 10 элементов
 FillArray(array);
 PrintArray(array);
 System.Console.WriteLine();
 int pos = Indexof(array, 4); // ищем цифру 4 в массиве
 System.Console.WriteLine(pos);