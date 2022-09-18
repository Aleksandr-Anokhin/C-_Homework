// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.WriteLine("Вводите положительные и отрицательные целые числа:   ");
int[] n = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
int count = 0;

for (int i = 0; i < n.Length; i++)
{
    if (n[i] > 0) count++;
}

Console.WriteLine($"Количество положительных чисел: {count}");
*/
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите координаты точек:");
Console.Write("b1:");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("k1:");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("b2:");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("k2:");
double k2 = Convert.ToInt32(Console.ReadLine());

// Упрощаем уравнения: y = k1 * x + b1, y = k2 * x + b2 => k1 * x + b1 = k2 * x + b2 => 
// k1*x - k2*x = b2 - b1 => x(k1 - k2) = b2 - b1 => x = (b2 - b1)/(k1 - k2);

double x = (b2 - b1)/(k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения прямых имеет координаты х = {x} у = {y}");