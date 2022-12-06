/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки
с наименьшей суммой элементов: 1 строка
*/

int[,] generate2DArray(int lengthRow, int lengthCol)
{
    int[,] array = new int[lengthRow, lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
void print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int sumOfRowElements(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
    return sum;
}

void MinSum (int[,] array)
{
    int count = 0;
    int minSum = sumOfRowElements(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int rowSum = sumOfRowElements(array, i);
        if (minSum > rowSum)
        {
            minSum = rowSum;
            count = i;
        }
    }
    Console.WriteLine($"Array row {count + 1} is a row with minimal sum of elements.");
}

int[,] generated2DArray = generate2DArray(4, 4);
print2DArray(generated2DArray);
MinSum(generated2DArray);
