/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int getUserNumber(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int GetPalindrome (int userNumber)
{                                
    int Digit1 = userNumber / 10000;
    int Digit2 = userNumber / 1000 % 10;
    int Digit4 = userNumber / 10 % 10;
    int Digit5 = userNumber % 10;
    if (Digit1 == Digit5) 
    {
    if (Digit2 == Digit4)
    {
        Console.WriteLine($"{userNumber} is a palindrome");
    }
    }
    else
    {
        Console.WriteLine($"{userNumber} is not a palindrome");
    }
    return userNumber;

}
int userNumber = getUserNumber("Enter a 5-digit number: ");
Console.WriteLine();
int Number = GetPalindrome(userNumber);
Console.WriteLine();
