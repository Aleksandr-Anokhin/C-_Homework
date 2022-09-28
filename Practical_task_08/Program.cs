// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

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