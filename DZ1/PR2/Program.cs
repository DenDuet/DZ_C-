// задача №2
Console.WriteLine("Задача №2");
Console.WriteLine("----------------------------------------");

Console.Write("Введите первое целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB) 
{
    Console.WriteLine("Первое число (" + numberA + ") больше второго (" + numberB +")");
}
else
{
    Console.WriteLine("Второе число (" + numberB + ") больше первого (" + numberA +")");
}
