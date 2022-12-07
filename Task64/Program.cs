/*
Задача 64: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
int getUserInt(string message)
{
    Console.WriteLine(message);
    int userInt = Convert.ToInt32(Console.ReadLine());
    return userInt;
}

int StartIndex = getUserInt("Enter N: ");
printRange(StartIndex);

void printRange(int index)
{
    if (index != 0)
    {
        Console.Write(index + " ");
        printRange(index - 1);
    }
}