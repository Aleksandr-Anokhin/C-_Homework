// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[4, 4];
    for (int i = 0; i < matrix.GetLength(0); i++) // строчки: matrix.GetLength(0) = m
    {
        for (int j = 0; j < n; j++) // столбцы: matrix.GetLength(1) = n
        {
            matrix[i,j] = new Random().Next(11); // [0;10] 
        }
    }
    return matrix;
}
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++) // строчки
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++) // cтолбцы
        {
            Console.Write(inputMatrix[i,m] + "\t"); 
        }
        Console.WriteLine();
    }
}
int[,] resultMatrix = GetMatrix(4, 4); // Заполнение матрицы
PrintMatrix(resultMatrix);

int[,] ChangeArray(int[,] inputArray)
{
    Console.WriteLine("Сортировка элементов строк по убыванию");
    Array.Reverse(inputArray); // Метод сортировки по убыванию
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        Console.Write(inputArray + "\t");
    }
    return inputArray;
}
PrintMatrix(ChangeArray(resultMatrix));
*/

// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов. 

int sum_str = 0;
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[4, 4];
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < n; j++) 
        {
            matrix[i,j] = new Random().Next(11); 
            
        }
    }
    return matrix;
}
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++) 
    {
            
        for (int m = 0; m < inputMatrix.GetLength(1); m++) 
        {
            Console.Write(inputMatrix[i,m] + "\t"); 
            sum_str += inputMatrix[i,m];
        }
        Console.WriteLine("Сумма строки  " + (i + 1) + "  " + sum_str);
        Console.WriteLine();
    }
}
int[,] resultMatrix = GetMatrix(4, 4); 
PrintMatrix(resultMatrix);

int ChangeArray(int[,] inputArray)
{
    int min_sum = sum_str;
        if (sum_str < min_sum) min_sum = sum_str; 
        Console.WriteLine("Минимальная сумма строк равна: " + min_sum);
        return inputArray;
}    
PrintMatrix(ChangeArray(inputArray));
  