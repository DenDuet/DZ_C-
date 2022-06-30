// следующая задача №23

Console.WriteLine("Задача №23");
Console.WriteLine("----------------------------------------");

int[] cube(int n)
{
    int[] array= new int[n];

    for (int i=1; i<=n; i++)
    {
        array[i-1] = i * i * i;
        Console.WriteLine("Куб числа " + i + " равен числу " + Math.Pow(i,3));
    }
    return array;
}
void printArray(int[] array, int n)
{
    Console.Write("Массив ");
    for (int i=1; i<=n; i++)
    {
        Console.Write(array[i-1] + ", ");
    }

}

Console.Write("Введите число N: ");

int N = Convert.ToInt32(Console.ReadLine());

int[] array = cube(N);
printArray(array, N); 