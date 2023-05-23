Console.Write("Введите ваше имя ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Здравствуйте, Мария! Рады вас снова видеть");
}
else
{
    Console.Write("Oh, it's you...");
    Console.WriteLine(username);
}