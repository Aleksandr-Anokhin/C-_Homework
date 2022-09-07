// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число. Программа проверит, является ли оно палиндромом.");
string numPolinom = Console.ReadLine();
if (numPolinom[0]==numPolinom[4] && numPolinom[1]==numPolinom[3])
{
    Console.WriteLine("Это число является палиндромом.");
}
else Console.WriteLine("Число Не является палиндромом.");
