/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
Console.Clear();
Console.Write("Задайте элемент M => ");
int a = int.Parse(Console.ReadLine());
Console.Write("Задайте элемент N => ");
int b = int.Parse(Console.ReadLine());
int x = NaturSum(a, b);
Console.WriteLine($"Сумма => {x}");



int NaturSum(int a, int b)
{
    if (a == b+1) return 0;
    else return a + NaturSum(a+1,b);

}

