// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)
void Main()
{
    Console.Clear();
    Console.WriteLine("Введите номер строки массива: ");
    int row = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Введите номер столбца массива: ");
    int column = int.Parse(Console.ReadLine()!);

    int[,] array = GetArray(5, 5);
    PrintArray(array);
    Console.WriteLine();
    ElementRowColumn(array, row, column);
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
void ElementRowColumn(int[,] array, int row, int column)
{
    if (row > array.GetLength(0) - 1 || column > array.GetLength(1) - 1)
    {
        Console.WriteLine("такого элемента в массиве нет!!!");
    }
    else
        Console.WriteLine($"Элемент массива {row} строки и {column} столбца  -> {array[row, column]}");
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