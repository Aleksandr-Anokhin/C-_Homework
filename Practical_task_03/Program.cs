// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число. Программа проверит, является ли оно палиндромом.");
string numPal = Console.ReadLine();
if (numPal[0]==numPal[4] && numPal[1]==numPal[3])
{
    Console.WriteLine("Это число является палиндромом.");
}
else Console.WriteLine("Число Не является палиндромом.");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

Console.WriteLine("Программа для рассчета расстояния между двумя точками в 3D пространстве.");
Console.WriteLine("Введите координаты двух точек:");
Console.Write("Введите координату Х1:");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y1:");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Z1:");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Х2:");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y2:");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Z2:");
int z2 = Convert.ToInt32(Console.ReadLine());

double P = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между точками: {Math.Round(P,2)}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число N");
int start = 1;
int end = Convert.ToInt32(Console.ReadLine());
while (start <= end)
{
    Console.WriteLine(start * start * start);
     start++;
}