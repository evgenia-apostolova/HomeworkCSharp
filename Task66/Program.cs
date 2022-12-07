/*
Задача 66: Задайте значения M и N. Напишите программу, которая
найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int getUserInt(string message)
{
    Console.WriteLine(message);
    int userInt = Convert.ToInt32(Console.ReadLine());
    return userInt;
}
void SumOfElements (int userNumberM, int userNumberN, int sum)
{
    if (userNumberM > userNumberN)
    {
        Console.WriteLine($"Sum of elements from М to N is {sum}"); 
        return;             
    }
    sum = sum + (userNumberM++);                
    SumOfElements(userNumberM, userNumberN, sum);
}
int userNumberM = getUserInt ("Enter element М: ");
int userNumberN = getUserInt ("Enter element N: ");
SumOfElements (userNumberM, userNumberN, 0);