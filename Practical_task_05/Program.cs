// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = 9;
int[] array = new int[size];
int count = 0;

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + "  ");
    if ((array[i] % 2) == 0) count++;
}
System.Console.WriteLine($"{"\n"}Количество четных чисел в массиве:  {count}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int size = 6;
int[] array = new int[size];
int sum = 0;

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100);
    Console.Write(array[i] + "  ");
    if ((i % 2) != 0) sum = sum + array[i];
}
System.Console.WriteLine($"{"\n"}Сумма элементов на нечётных позициях в массиве:  {sum}");


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
/*
int size = 7;
double[] array = new double[size];
Random rand = new Random();
double minNum = array[0];
double maxNum = array[0];

for (int i = 1; i < size; i++)
{
    array[i] = rand.NextDouble() * 100;
    Console.Write(array[i] + "  ");
    if (array[i] < minNum) minNum = array[i];
    
    if (array[i] > maxNum) maxNum = array[i];
}
double diff = maxNum - minNum;
System.Console.WriteLine($"{"\n"}Разница между максимальным и минимальным элементом массива равна:  {Math.Round((diff),2)}");
*/
int size = 7;
double[] array = new double[size];
Random rand = new Random();

for (int i = 0; i < size; i++)
{
    array[i] = rand.NextDouble() * 100;
    Console.Write(array[i] + "  ");
}
double minNum = array[0];
double maxNum = array[0];

for (int i = 0; i < size; i++)
{
    if (array[i] < minNum) minNum = array[i];
    if (array[i] > maxNum) maxNum = array[i];
}

double diff = maxNum - minNum;
System.Console.WriteLine($"{"\n"}Разница между максимальным и минимальным элементом массива равна:  {Math.Round((diff), 2)}");
