/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int getNumberFromUser(string message)
{
int result = 0;
Console.WriteLine(message);
result = Convert.ToInt32(Console.ReadLine());
return result;
}

int Solution(int userNumber)
{
    Console.WriteLine($"Table of number cubes from 1 to {userNumber}");
    for (int i = 1; i <= userNumber; i++)
    {
        double number = Math.Pow(i, 3);
        Console.WriteLine($"{number}");
    }
    return userNumber;
}
int userNumber = getNumberFromUser("Enter a number:");
Console.WriteLine();
double number = Solution(userNumber);
