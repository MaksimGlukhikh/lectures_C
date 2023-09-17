Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "валера")
{
    Console.WriteLine("Ебать ты Валера :D");
}
else
{
    Console.Write("Привет, " + username + "! Ты не Валера!");
}