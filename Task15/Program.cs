/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую
день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/


Console.WriteLine("Enter a daynumber of a weekday");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber > 5)
    
Console.WriteLine("This day is a dayoff");

if (dayNumber <= 5)

Console.WriteLine("This day is a workday");


