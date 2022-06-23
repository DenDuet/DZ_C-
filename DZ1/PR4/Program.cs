// следующая задача №4

Console.WriteLine("Задача №4");
Console.WriteLine("----------------------------------------");

Console.Write("Введите первое целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;

if (max < numberB)
{
    max = numberB;
}
if (max < numberC)
{
    max = numberC;
}
Console.WriteLine("Максимальным из трех чисел (" + numberA + ", " + numberB +", " + numberC + ") является число " + max);
