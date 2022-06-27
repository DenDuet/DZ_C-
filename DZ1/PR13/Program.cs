// следующая задача №13

Console.WriteLine("Задача №13");
Console.WriteLine("----------------------------------------");

int number;

Console.Write("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Исходное число: " + number);

if (number<100)
{
    Console.WriteLine("Третьей цифры нет!");
}
else if (number>=100 && number<1000)
{
    Console.WriteLine("Третья цифра: " + number % 10);
}
else if (number>=1000 && number<10000)
{
    Console.WriteLine("Третья цифра: " + (number/10) % 10);
}
else if (number>=10000 && number<100000)
{
    Console.WriteLine("Третья цифра: " + (number/100) % 10);
}
