/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно
выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] generate3DArray (int x, int y, int z, int min, int max)
{
    int[,,] array = new int[x, y, z];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = random.Next(min, max + 1);
            }
        }
    }
    return array;
}

void Print3DArray(int[,,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($" {array[i,j,k]} ({i}, {j}, {k})" + "\t");
            }  
            Console.WriteLine();                
        }
        Console.WriteLine();   
    }
}
int x = 2;
int y = 2;
int z = 2;
int min = 10;
int max = 99;
int[,,] array = generate3DArray (x, y, z, min, max);
Print3DArray(array);
