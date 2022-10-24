Console.Clear();
int count = 0;   // счетчик
int distance = 10000;   // растояние между друзьями
int firstFriehdSpeed = 1;   // скорость первого друга
int secondFriendSpeed = 2;  // скорость второго друга
int dogSpeed = 5;   // скорость собаки
int friend = 2; // количество друзей
int time = 0;
while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriehdSpeed + dogSpeed);
        friend = 2;
        distance = distance - (firstFriehdSpeed + secondFriendSpeed) * time;
        count++;
    }
    if (friend == 2)
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
        distance = distance - (firstFriehdSpeed + secondFriendSpeed) * time;
        count++;
    }

}

System.Console.WriteLine($"собако пробежит {count} раз");