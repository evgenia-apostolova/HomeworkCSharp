/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

int a = new int();
Console.WriteLine("Enter number1");
a = Convert.ToInt32(Console.ReadLine());

int b = new int();
Console.WriteLine("Enter number2");
b = Convert.ToInt32(Console.ReadLine());

int max = new int();

if (a > b)
max = a;

else
max = b;

Console.Write("max = ");
Console.WriteLine(max);
