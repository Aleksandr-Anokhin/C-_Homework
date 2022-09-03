// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//int number = new Random().Next(100, 1000);
//int number02 = number / 10;
//int newNumber = number02 % 10;
//Console.WriteLine(number);
//Console.WriteLine(newNumber);

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//Console.Clear();

Console.WriteLine("Введите число,в котором будет не меньше трёх цифр:");
string? number = Console.ReadLine();
int length = number.Length;
if (number.Length < 3) 
{
    Console.WriteLine("Третьей цифры нет, попробуйте ещё раз.");
}    
else 
Console.WriteLine($"Третья цифра: {number[2]}");

int number = new Random().Next(100, 1000);
