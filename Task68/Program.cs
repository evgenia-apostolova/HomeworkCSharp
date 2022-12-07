/*
Задача 68: Напишите программу вычисления функции Аккермана
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int getUserInt(string message)
{
    Console.Write (message);
    int userInt = Convert.ToInt32(Console.ReadLine());
    return userInt;
}

int AckermannFunc(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return AckermannFunc(m - 1, 1);
  else return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
}
		
int m = getUserInt("Enter number M: ");
int n = getUserInt("Enter number N: ");
int Ack = AckermannFunc(m, n);
Console.WriteLine($"Ackermann function is {Ack}");