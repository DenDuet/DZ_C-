// следующая задача №19

Console.WriteLine("Задача №19");
Console.WriteLine("----------------------------------------");


Console.WriteLine("Введите пятизначное число: ");
string val=Console.ReadLine();
int v=val.Length;
Console.WriteLine("Длина числа " + v + " число " + val);

if (v==5)
{
    if (val[0]==val[v-1] && val[1]==val[v-2])
    {
        Console.WriteLine("Это полиндром");
    }
    else
    {
        Console.WriteLine("Это не полиндром");
    }
}