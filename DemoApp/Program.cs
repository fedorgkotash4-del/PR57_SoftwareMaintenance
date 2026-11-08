using System.Globalization;
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

int age;
while (true)
{
    Console.Write("Введіть вік (0–130): ");
    var input = Console.ReadLine();
    if (input is null)
    {
        Console.Error.WriteLine("Помилка: введення віку перервано.");
        return 1;
    }
    if (int.TryParse(input, NumberStyles.Integer, CultureInfo.InvariantCulture, out age)
        && age is >= 0 and <= 130)
        break;
    Console.WriteLine("Некоректний вік. Введіть ціле число від 0 до 130.");
}

Console.WriteLine($"Вітаю {userName}!");
Console.WriteLine($"Ім'я: {userName}. Вік: {age}.");
Console.WriteLine(age >= 18 ? "Статус: повнолітній користувач." : "Статус: неповнолітній користувач.");
return 0;
