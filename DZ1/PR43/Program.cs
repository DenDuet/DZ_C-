// следующая задача №43

Console.WriteLine("Задача №43");
Console.WriteLine("----------------------------------------");

double accountX(double k1, double b1, double k2, double b2)
{
    return (b2 - b1) / (k1 - k2);
}

double accountY(double k1, double b1, double x)
{
    return k1 * x + b1;
}

Console.WriteLine("Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = accountX(k1, b1, k2, b2);
double y = accountY(k1, b1, x);

Console.WriteLine("Точка пересечения двух прямых: (" + x + ";" + y + ")");
