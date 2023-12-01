Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "alex")

{
    Console.WriteLine("УРА, это же the best Alender in the world");
}
else
{
    Console.WriteLine("Привет, " + username);
    Console.WriteLine(username);
}

