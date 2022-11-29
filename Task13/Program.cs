﻿/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или
сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
/*
int Number = new Random().Next(1, 100000);
Console.WriteLine($"Random number: {Number}");

int counter = Number;
int place = 0;
while (counter != 0)
{
place++;
counter = counter/10;
}
int[] array = new int[place];
place = 0;
while (Number > 0)
{
array[place] = Number % 10;
Number = Number / 10;
place++;
}
if (array.Length >= 3)
{
Console.WriteLine($"Third digit is {array[array.Length - 3]}");
}
else
{
Console.WriteLine("There is no third digit");
}

Console.WriteLine();
*/

int GetRandomNumber(int start, int end)
{
    int result = 0;
    result = new Random().Next(start, end + 1);
    return result;
}

int GetSearchNumber(int number)
{
    int SearchNumber = 0;
    int NoSearchNumber = 0;
    int a = 100;
    int b = 1000;
    int c = 10000;
    int d = 100000;

    if (number < a) 
    {
    SearchNumber = NoSearchNumber;
    }
    else if (number < b)
    {
        SearchNumber = number % 10;
    }
    else if (number < c)
    {
        SearchNumber = (number / 10) % 10;
    }
    else if (number < d)
    {
        SearchNumber = (number / 100) % 10;
    }   
    return SearchNumber;  
                            
}

int number = GetRandomNumber (1, 100000);
int SearchNumber = GetSearchNumber(number);
Console.WriteLine($"Третьей цифрой числа {number} является {SearchNumber}");