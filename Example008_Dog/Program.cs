int count = 0;
Console.Write("Введите растояние между друзьями в метрах:");
string dist = Console.ReadLine();
int distance = int.Parse(dist);
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend =2;
int time;


while(distance>10)
{
    if(friend ==1)
    {
        time = distance/(firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance/(secondFriendSpeed+dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed)*time;
    count++;
}
Console.Write("Количество раз которое собака сбегала туда обратно: ");
Console.Write(count);