int[] arrey = { 1, 12, 31, 4, 15, 16, 4, 17, 18 };
int n = arrey.Length;
int find = 4;
int index = 0;

while (index < n)
{
    if (arrey[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++;

}