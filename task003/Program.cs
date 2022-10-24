// Задача 49: Задайте двумерный массив. Найдите элементы, у 
// которых оба индекса чётные, и замените эти элементы на их 
// квадраты.
// Например, изначально массив     Новый массив будет выглядеть 
// выглядел вот так:               вот так:
// 1 4 7 2                           1 4 7 2
// 5 9 2 3                           5 81 2 9
// 8 4 2 4                           8 4 2 4

void Main()
{
    Console.Clear();
    Console.WriteLine("Введите количество строк массива: ");
    int rows = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Введите количество столбцов массива: ");
    int columns = int.Parse(Console.ReadLine()!);

    int[,] array = GetArray(rows, columns, 2, 3);
    PrintArray(array);
    int[,] newArray = SquadArray(array);
    Console.WriteLine();
    PrintArray(newArray);
}
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
int[,] SquadArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] *= array[i, j];
            }
        }
    }
    return array;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
Main();