System.Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if (username.ToLower() == "александр")
{
    Console.WriteLine("Ура, это Александр!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}