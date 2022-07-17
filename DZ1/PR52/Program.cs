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
        array[i,j] = rnd.Next(-10,10);
        Console.Write(array[i,j]+" ");
    }
    Console.WriteLine();
}


for (int j=0; j<n; j++)
{
double sr=0;
    for (int i=0; i<m; i++)
    {
        sr = sr + array[i,j];
        Console.Write(array[i,j]+" + ");
    }
    Console.WriteLine(" среднее арифметическое столбца = "+ sr/m);
}