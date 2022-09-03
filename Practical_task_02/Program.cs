// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Программа генерирует трёхзначное число и показывает вторую цифру");
int number = new Random().Next(100, 1000);
int number02 = number / 10;
int newNumber = number02 % 10;
Console.WriteLine(number);
Console.WriteLine(newNumber);

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.WriteLine("Введите число,в котором будет не меньше трёх цифр:");
string? number3 = Console.ReadLine();
int length = number3.Length;
if (number3.Length < 3) 
{
    Console.WriteLine("Третьей цифры нет, попробуйте ещё раз.");
}    
else 
Console.WriteLine($"Третья цифра: {number3[2]}");

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Программа проверяет, является ли этот день выходным.");
Console.WriteLine("Введите цифру от 1 до 7 которая соответствует дню недели");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 6 || num == 7)
{
    Console.WriteLine("Это выходной, можно отдохнуть ;)");
}
else Console.WriteLine("Это рабочий день.");