// следующая задача №34

Console.WriteLine("Задача №34");
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
    int even = 0;
    Console.WriteLine();
    Console.Write("В массиве: ");

    while (position < count)
    {
        if (col[position] % 2 == 0)
            even++;
        Console.Write(col[position] + " ");
        position++;
    }
    Console.WriteLine($" четных чисел - {even}");
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
