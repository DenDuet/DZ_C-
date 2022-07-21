// следующая задача №56
// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Задача №56");
Console.WriteLine("----------------------------------------");

Console.Write("Введите число строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];

Random rnd = new Random();
Console.WriteLine("Исходный массив: ");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = rnd.Next(0, 10);
    }
}

int RowsSumm(int[,] array)
{
    int minimum = 0;

    int rowsNumber = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summa = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summa = summa + array[i, j];
        }
        if (i == 0)
        {
            minimum = summa;
        }
        if (summa < minimum)
        {
            minimum = summa;
            rowsNumber = i;
        }
    }
    return rowsNumber;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

PrintArray(array);

Console.WriteLine($"Минимальная сумма чисел в строке {RowsSumm(array) + 1}");
