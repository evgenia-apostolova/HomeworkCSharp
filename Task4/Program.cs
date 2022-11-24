/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int a = new int();
Console.WriteLine("Enter number1");
a = Convert.ToInt32(Console.ReadLine());

int b = new int();
Console.WriteLine("Enter number2");
b = Convert.ToInt32(Console.ReadLine());

int c = new int();
Console.WriteLine("Enter number3");
c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a > b)
    max = a;
else if (b > max)
    max = b;
if (c > max)
    max = c;

Console.Write("max = ");
Console.WriteLine(max);
