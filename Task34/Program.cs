/*
Задача 34: Задайте массив, заполненный случайными положительными трёхзначными
числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] generateRandomArray(int length, int start, int end)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
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

int getEvenNumberArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}


int[] generatedArray = generateRandomArray(8, 100, 999);
printArray(generatedArray);
int count = getEvenNumberArray(generatedArray);
Console.WriteLine($"Number of even numbers in the array is {count}.");