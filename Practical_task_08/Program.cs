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

int[,] SortRowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            int position = j;
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] > matrix[i, position]) position = k;
            }
                int value = matrix[i, j];
                matrix[i, j] = matrix[i, position];
                matrix[i, position] = value;
        }
    }
    return matrix;
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными по убыванию элементами строк: ");
PrintMatrix(SortRowMatrix(resultMatrix));


// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов. 

int[,] array = GetArray(4, 4, 0, 10);
PrintArray(array);

Console.WriteLine($"Строка с наименьшей суммой - {GetRowNumber(array)}");

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}   ");
        }
        Console.WriteLine();
    }
}
int GetRowNumber (int [,] array)
{
    int row = 0;
    int minsum = 0;
    for (int i = 0; i<array.GetLength(1); i++)
    {
        minsum = minsum + array[0,i];
    }

    for (int i = 1; i<array.GetLength(0); i++)
    {
        int sum = 0; 
        for (int j = 0; j<array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        if (minsum < sum)
        {
            minsum = sum;
            row = i++;
        }
    }
    return row;
}


// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.

int[,] firstMartrix = new int[2, 2];
CreateArray(firstMartrix);
Console.WriteLine("Первая матрица:");
WriteArray(firstMartrix);

int[,] secondMartrix = new int[2, 2];
CreateArray(secondMartrix);
Console.WriteLine("Вторая матрица:");
WriteArray(secondMartrix);

int[,] resultMatrix = new int[2, 2];

MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine("Произведение матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(10);
    }
  }
}

void WriteArray (int[,] array)
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

// * Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
int[,] Spiral(int[,] array)
{
    var SizeX = array.GetUpperBound(0);
    var SizeY = array.GetUpperBound(1);
    var maxX = SizeX + 1;
    var maxY = SizeY;
    var dirX = 1;
    var dirY = 1;

    var x = -1;
    var y = 0;
    var val = 1;
    while ((maxX >= 0) && (maxY >= 0))
    {
        for (int xval = 1; xval <= maxX; xval++)
        {
            array[x + dirX * xval, y] = val;
            val++;
        }

        x = x + dirX * maxX;
        dirX = -dirX;
        maxX--;

        for (int yval = 1; yval <= maxY; yval++)
        {
            array[x, y + dirY * yval] = val;
            val++;
        }

        y = y + dirY * maxY;
        dirY = -dirY;
        maxY--;
    }
    return array;
}
void print(int[,] array)
{
    for (int y = 0; y <= array.GetUpperBound(1); y++)
    {
        for (int x = 0; x <= array.GetUpperBound(0); x++)
            Console.Write(" " + array[x,y]);
            Console.WriteLine();
    }
}
var z = new int[4,4];
    z = Spiral(z);
    print(z);
    

    