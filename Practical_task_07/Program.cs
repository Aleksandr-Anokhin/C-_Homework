// Задача 47. Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами. m = 3, n = 4.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] GetMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++) 
        {
            matrix[i,j] = new Random().NextDouble() * 20 - 10;
        }
    }
    return matrix;
}
void PrintMatrix(double[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++) 
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++) 
        {
            Console.Write(System.Math.Round(inputMatrix[i,m],1) + "\t"); 
        }
        Console.WriteLine();
    }
}
double[,] resultMatrix = GetMatrix(rows, columns); 
PrintMatrix(resultMatrix);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] GetArray(int m, int n)
{
    int[,] array = new int[4, 4];
    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++) 
        {
            array[i,j] = new Random().Next(11); 
        }
    }
    return array;
}
void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++) 
    {
        for (int m = 0; m < inputArray.GetLength(1); m++) 
        {
            Console.Write(inputArray[i,m] + "\t"); 
        }
        Console.WriteLine();
    }
}
int[,] resultArray = GetArray(4, 4); 

int[,] ChangeArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (n > inputArray.GetLength(0) || m > inputArray.GetLength(1))
            {
                Console.WriteLine("Такого числа в массиве нет");
            }
            else
            {
                Console.WriteLine($"Значение равно {inputArray[n-1,m-1]}");
            }
        }
    }
    return inputArray;
}
PrintArray(ChangeArray(resultArray));

// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetArray(int m, int n)
{
    int[,] array = new int[4, 4];
    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++) 
        {
            array[i,j] = new Random().Next(11); 
        }
    }
    return array;
}
void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++) 
    {
        for (int m = 0; m < inputArray.GetLength(1); m++) 
        {
            Console.Write(inputArray[i,m] + "\t"); 
        }
        Console.WriteLine();
    }
}
int[,] resultArray = GetArray(4, 4); 
int[,] ChangeArray(int[,] inputArray)
{
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            avarage = (avarage + inputArray[i, j]);
        }
        avarage = avarage / 4;
        Console.Write(avarage + ";" + "\t");
    }
    Console.WriteLine();
    return inputArray;
}
PrintArray(ChangeArray(resultArray));