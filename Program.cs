
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GetArray(int rows, int cols)
{
    double[,] result = new double[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            result[i, j] = new Random().NextDouble() * 2;
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            System.Console.WriteLine($"{inArray[i, j]} ");
        }
      System.Console.WriteLine();
    }
}

int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы: ");
double[,] array = GetArray(rows, cols);
PrintArray(array);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void CreateRandomArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 100);
        }
    }
}

void ShowArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void CheckNumber(int[,] arr)
{
    Console.WriteLine();
    Console.Write("Введите позицию на какой строке: ");
    int linePosition = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите позицию в каком столбце: ");
    int columnPosition = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число для проверки: ");
    int numberToCheck = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    if (arr[linePosition - 1, columnPosition - 1] == numberToCheck)
    {
        Console.WriteLine($"{numberToCheck} - такое число в массиве есть");
    }
    else
    {
        Console.WriteLine($"{numberToCheck} - такого числа в массиве нет");
    }
}

const int numberOfLines = 5;
const int numberOfColumns = 4;
int[,] array = new int[numberOfLines, numberOfColumns];

CreateRandomArray(array);
ShowArray(array);
CheckNumber(array);


// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void CreateRandomArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 100);
        }
    }
}

void ShowArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void CalculateAverage(int[,] arr)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j, i];
        }
        double average = sum / arr.GetLength(0);
        Console.Write($"{average:f1}; ");
    }
}

const int numberOfLines = 5;
const int numberOfColumns = 4;
int[,] array = new int[numberOfLines, numberOfColumns];

CreateRandomArray(array);
ShowArray(array);
CalculateAverage(array);