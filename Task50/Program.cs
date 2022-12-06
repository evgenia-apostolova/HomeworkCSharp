/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента
в двумерном массиве, и возвращает значение этого элемента
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

[0][1][2][3]
1 4 7 2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
8 4 2 4

9 -> 4
5 -> 9
*/

int[,] generate2DArray(int lengthRow, int lengthCol, int deviation)
{
    int[,] array = new int[lengthRow, lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = new Random().Next(-deviation, deviation + 1);
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

int[] ConvertArray (int[,] array)
{           
    int sizeConvertedArray = array.GetLength(0) * array.GetLength(1);
    int[] convertedArray = new int[sizeConvertedArray];
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            convertedArray[index] = array[i, j];
            index++;
        }
    }
    return convertedArray;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

void UserElement (int[] array)
{                
    Console.Write("Enter UserElement: ");
    int userElement = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < array.Length; i++)
    {
        if (userElement == i)
        {
            
            Console.WriteLine ($"Value of {userElement} is {array[i]}");
        }                                  
        if (userElement > array.Length )
        {
            Console.WriteLine("There is no such index in the array");
            Console.WriteLine();
        }
        if (userElement < 0)
        {
            Console.WriteLine("There is no such index in the array");
            Console.WriteLine();
        }                  
    }
}

Console.Write("2DArray:");
Console.WriteLine();
int[,] generated2DArray = generate2DArray(3, 4, 30);
print2DArray(generated2DArray);
Console.WriteLine();
Console.WriteLine("Converted 1DArray:");
int[] convertedArray = ConvertArray(generated2DArray);
PrintArray(convertedArray);
Console.WriteLine();
UserElement(convertedArray);