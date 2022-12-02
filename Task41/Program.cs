/*
Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int[] userGenerateArray(int length, int start, int end)
{
    Console.Write("Enter numbers M times: ");
    length = Convert.ToInt32(Console.ReadLine());
    int[] array = new int [length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

int numbersGreaterThanZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        count++;
    }
    return count;
}

int[] generatedArray = userGenerateArray(6, -20, 20);
printArray(generatedArray);
int count = numbersGreaterThanZero(generatedArray);
Console.WriteLine($"There are {count} numbers greater than zero in M-number array");
