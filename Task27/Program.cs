/*
Задача 27: Напишите программу, которая принимает
на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int getNumberFromUser(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int getSumOfDigits (int userNumber)
{
    int sumOfDigits = 0;
    while (userNumber > 0)
    {
        int modulo = userNumber % 10;
        sumOfDigits = sumOfDigits + modulo;
        int quotient = userNumber / 10;
        userNumber = quotient;
    }
    return sumOfDigits;
}

int userNumber = getNumberFromUser("Enter a number:");
int sumOfDigits = getSumOfDigits(userNumber);
Console.WriteLine($"Sum of digits in {userNumber} is {sumOfDigits}");