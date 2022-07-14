// следующая задача №36

Console.WriteLine("Задача №36");
Console.WriteLine("----------------------------------------");

int[] FillArray(int[] collection, int a, int b)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(a, b);
        index++;
    }
    return collection;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;

    Console.WriteLine();
    Console.Write("В массиве: ");
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
    Console.WriteLine();
}

int SummaNumbers(int[] col)
{
    int count = col.Length;
    int position = 1;
    int sum = 0;

    while (position < count)
    {
        sum = sum + col[position];
        position += 2;
    }
    return sum;
}

Console.WriteLine("Сколько чисел в массиве? ");
int digit = Convert.ToInt32(Console.ReadLine());
int[] array = new int[digit];

Console.WriteLine("Введите нижнюю границу чисел: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите верхнюю границу чисел: ");
int b = Convert.ToInt32(Console.ReadLine());

array = FillArray(array, a, b);
PrintArray(array);

Console.WriteLine("Сумма чисел, стоящих на нечетных позициях = " + SummaNumbers(array));
Console.WriteLine();