// следующая задача №27

Console.WriteLine("Задача №27");
Console.WriteLine("----------------------------------------");

int sum(string num)
{
    int summa=0;
    int len=num.Length;
    for (int i=0; i<len; i++)
    {
         summa=summa+int.Parse(num[i].ToString());
    }
    return summa;
}
Console.Write("Введите число: ");
string a = Console.ReadLine();
Console.WriteLine("Сумма чисел этого числа = " + sum(a));
