// следующая задача №15

Console.WriteLine("Задача №15");
Console.WriteLine("----------------------------------------");

string[] day = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };

Console.Write("Введите целое число (1-7): ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 7)
{
    Console.Write("Это " + day[number - 1]);
    if (number==6 || number==7)
    {
        Console.Write(" - выходной день.");
    }
}
else
{
    Console.WriteLine("Такого дня не существует!");
}