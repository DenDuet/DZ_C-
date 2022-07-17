// следующая задача №41

Console.WriteLine("Задача №41");
Console.WriteLine("----------------------------------------");

int FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    int numbers = 0;
    while (index < length)
    {
        Console.Write("Введите число: ");
        collection[index] = Convert.ToInt32(Console.ReadLine());
        if (collection[index] > 0)
        {
            numbers++;
        }
        index++;
    }
    return numbers;
}

Console.WriteLine("Сколько чисел в массиве? ");
int digit = Convert.ToInt32(Console.ReadLine());
int[] array = new int[digit];
int numbers = FillArray(array);
Console.WriteLine("Введено " + numbers + " положительных чисел.");
