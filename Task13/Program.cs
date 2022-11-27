/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или
сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int Number = new Random().Next(1, 1500);
Console.WriteLine($"Given number: {Number}");

if (Number / 100 < 1) 
{
Console.WriteLine("There is no third digit");
}
else
{
    if (Number / 1000 > 0) 
    
    Console.WriteLine($"Third digit of {Number} is digit {Number / 10 % 10}");

    else Console.WriteLine($"Third digit of {Number} is digit {Number % 10}");
}

Console.WriteLine();
