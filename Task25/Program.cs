/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int getNumberFromUser(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Powering (int numA, int numB)
{
    int result = 1;
    for (int i = 0; i < numB; i++)
    {
        result = result * numA;
    }
    return result;
}

int numA = getNumberFromUser("Enter number A:");
int numB = getNumberFromUser("Enter number B:");
int count = Powering(numA, numB);
Console.WriteLine($"{numA} powered to {numB} = {count}");

