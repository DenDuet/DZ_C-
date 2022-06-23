// следующая задача №6

Console.WriteLine("Задача №6");
Console.WriteLine("----------------------------------------");

Console.Write("Введите целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA % 2 == 0) 
{
    Console.Write("Число " + numberA +" четное");
}
else
{
    Console.Write("Число " + numberA +" нечетное");
}