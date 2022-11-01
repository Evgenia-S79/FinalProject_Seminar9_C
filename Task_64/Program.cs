// Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

double GetNumberFromConsole()
{
    Console.Write("Введите число: ");
    return Convert.ToDouble(Console.ReadLine());
}

void PrintNumberRecursion(double number, int counter)
{
    if (counter > number) return;
    PrintNumberRecursion(number, counter + 1);
        if (counter != 1)
           Console.Write(counter + ", ");
        else
            Console.Write(counter + ".");
}

double number = GetNumberFromConsole();
int counter = 1;
PrintNumberRecursion(number, counter);