// Задача 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Clear();

Console.Write("Enter number N: ");
int numberN = int.Parse(Console.ReadLine()!);

RecPrintNumbers(numberN);

void RecPrintNumbers(int numberN)
{
    if (numberN >= 1)
    {
        Console.Write($"{numberN} ");
        numberN--;
        RecPrintNumbers(numberN);
    }
}
