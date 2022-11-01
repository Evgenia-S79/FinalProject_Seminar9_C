// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int AckermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0 && m > 0)
        return AckermanFunction(m - 1, 1);
    else
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}

int m = GetNumberFromConsole("Введите первое значение больше 0, (m)");
int n = GetNumberFromConsole("Введите второе значение больше 0, (n)");
Console.WriteLine($"A({m}, {n}) = {AckermanFunction(m, n)}");