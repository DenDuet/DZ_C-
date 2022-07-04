// следующая задача №29

Console.WriteLine("Задача №29");
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
    while (position < count)
    {
        Console.Write(col[position]+" ");
        position++;
    }
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
