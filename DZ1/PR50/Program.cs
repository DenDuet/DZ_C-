// следующая задача №47

Console.WriteLine("Задача №47");
Console.WriteLine("----------------------------------------");

Console.Write("Введите число строк массива: ");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int n=Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];

Random rnd = new Random();
for (int i=0; i<m; i++)
{
    for (int j=0; j<n; j++)
    {
        array[i,j] = rnd.Next(-100,100);
        Console.Write(array[i,j]+" ");
    }
    Console.WriteLine();
}

Console.Write("Введите номер строки элемента: ");
int m1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца элемента: ");
int n1=Convert.ToInt32(Console.ReadLine());

if (m1<=m && n1<n) 
{
    Console.WriteLine("Вот этот элемент: " + array[m1-1,n1-1]);
}
else
{
    Console.WriteLine("В этом массиве такого элемента нет.");
}
