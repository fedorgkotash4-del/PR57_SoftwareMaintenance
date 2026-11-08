using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
Console.Write("Введіть ім'я: ");
var userName = Console.ReadLine()?.Trim();
if (string.IsNullOrWhiteSpace(userName))
{
    Console.Error.WriteLine("Помилка: ім'я не може бути порожнім.");
    return 1;
}
Console.WriteLine($"Вітаю {userName}!");
return 0;
