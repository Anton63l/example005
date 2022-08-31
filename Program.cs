
Console.Write("Введите имя: ");
string username = Console.ReadLine();

if(username.ToLower == "Маша")
{
    Console.WriteLine("Рад тебя видеть, Маша");
}
else
{
    Console.Write($"Здравствуй, {username}");
}