/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет 
*/

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = rnd.Next(minValue, maxValue +1);
        }
    }
    return array;
}

void PrintChosen (int[,] array)
{
    Console.WriteLine("Введите номер элемента по i");
    int posI = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите номер элемента по j");
    int posJ = int.Parse(Console.ReadLine()!);

    if (posI < array.GetLength(0) && posJ < array.GetLength(1)) 
        Console.WriteLine($"Ваше число: {array[posI, posJ]}.");
    else 
        Console.WriteLine($"Числа с индексом {posI}" + "," + $"{posJ} в массиве нет");

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
           for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = GetArray(5, 5, 0, 10);
PrintArray(array);
Console.WriteLine();
PrintChosen(array);