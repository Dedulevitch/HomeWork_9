/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Clear();
Console.WriteLine("Задайте значение N ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"N = {n}");
NumbersRec2(n);



void NumbersRec2(int n)
{
    if (n==0) return;
    Console.Write($"{n}" + "\t");
    n--;
    NumbersRec2(n);
}
