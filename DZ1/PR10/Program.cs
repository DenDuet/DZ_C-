// следующая задача №10

Console.WriteLine("Задача №10");
Console.WriteLine("----------------------------------------");

int number, number2;

number = new Random().Next(100, 999);
Console.WriteLine("Исходное число: " + number);

number2 = (number/10) % 10;
Console.WriteLine("Итоговое число: " + number2);
