// следующая задача №38

Console.WriteLine("Задача №38");
Console.WriteLine("----------------------------------------");

double[] FillArray(double[] collection, int a, int b)
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

void PrintArray(double[] col)
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

void MaxMin(double[] col)
{
    int count = col.Length;
    double maxElement = 0;
    double minElement = 0;
    int position = 0;

    if (col[position] >= col[position+1]) 
    {
        maxElement = col[position];
        minElement = col[position+1];
    }
    else
    {
        maxElement = col[position+1];
        minElement = col[position];
    }

    position = 2;
    while (position < count)
    {
        if (col[position] > maxElement) {maxElement = col[position];}
        else if (col[position] < minElement) {minElement = col[position];}
        position ++;
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {maxElement} - {minElement} = {maxElement-minElement}");
    Console.WriteLine();    
}

Console.WriteLine("Сколько чисел в массиве? ");
int digit = Convert.ToInt32(Console.ReadLine());
double[] array = new double[digit];

Console.WriteLine("Введите нижнюю границу чисел: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите верхнюю границу чисел: ");
int b = Convert.ToInt32(Console.ReadLine());

array = FillArray(array, a, b);
PrintArray(array);
MaxMin(array);