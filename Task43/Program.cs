/*
Задача 43: Напишите программу, которая найдёт точку пересечения
двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int getNumberFromUser(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double findIntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Intersection point is at ({x};{y})");
    return x;
}

int b1 = getNumberFromUser ("Enter b1: ");
int k1 = getNumberFromUser ("Enter k1: ");
int b2 = getNumberFromUser ("Enter b2: ");
int k2 = getNumberFromUser ("Enter k2: ");
double intersectionPoint = findIntersectionPoint(b1, k1, b2, k2);