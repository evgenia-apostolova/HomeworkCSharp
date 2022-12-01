/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] generateRandomArray(int length, int start, int end)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble();
    }
    return array;
}

void printArray(double[] array)
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

double getMaxElement(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}

double getMinElement(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}

double getDifferenceBetweenElements(double max, double min)
{
    double difference = max - min;
    return difference;
}


double [] generatedArray = generateRandomArray(6, -10, 20);
printArray(generatedArray);
double maxElement = getMaxElement(generatedArray);
double minElement = getMinElement(generatedArray);
double difference = getDifferenceBetweenElements(maxElement, minElement);
Console.WriteLine($"Maximum element of the array is {maxElement}, minimum is {minElement},"); 
Console.WriteLine($"Difference between max and min elements is {difference}");
