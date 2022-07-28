/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int SummNumbers(int m, int n)
{
    if (m == n)
    {
      return n;
    } 
    else
    {
        return m + SummNumbers(m + 1, n);
    }
}

Console.WriteLine("Введите число М:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine());

int summ = SummNumbers(m,n);
Console.WriteLine($"{summ}");
