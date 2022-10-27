// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Main()
{
    Console.Clear();
    Console.WriteLine("Введите количество строк массива: ");
    int rows = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Введите количество столбцов массива: ");
    int columns = int.Parse(Console.ReadLine()!);

    int[,] array = GetArray(rows, columns);
    PrintArray(array);
    ArithmeticMeanColumns(array);
}

int[,] GetArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}


void ArithmeticMeanColumns(int[,] array)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result += array[i, j];

        }
        Console.WriteLine($"Среднее арифметическое столбца номер {j + 1} = {result / array.GetLength(1)} ");
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
Main();