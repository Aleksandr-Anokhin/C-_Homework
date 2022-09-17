// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Вводите положительные и отрицательные целые числа:   ");
int[] n = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
int count = 0;

for (int i = 0; i < n.Length; i++)
{
    if (n[i] > 0) count++;
}

Console.WriteLine($"Количество положительных чисел: {count}");