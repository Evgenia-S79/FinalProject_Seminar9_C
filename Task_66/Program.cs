// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumRecursion(int m, int n)
{
    if (m == n)
        return n;
    return n + SumRecursion(m, n - 1);
}

int m = GetNumberFromConsole("Введите первое значение (m)");
int n = GetNumberFromConsole("Введите второе значение (n)");

Console.WriteLine($"Сумма элементов от {m} до {n} = {SumRecursion(m, n)}");

