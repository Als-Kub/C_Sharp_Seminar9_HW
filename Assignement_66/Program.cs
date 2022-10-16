// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N. Рекурсивно
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



Console.Clear();

Console.Write("Enter number M: ");
int numberM = int.Parse(Console.ReadLine()!);

Console.Write("Enter number N: ");
int numberN = int.Parse(Console.ReadLine()!);


if (numberM > numberN)
{
    int temp = 0;
    temp = numberM;
    numberM = numberN;
    numberN = temp;
}

Console.WriteLine($"Sum = {RecPrintNumbers(numberM, numberN)}");


int RecPrintNumbers(int numberM, int numberN, int sum = 0)
{

    if (numberM <= numberN)
    {
        sum = numberM + RecPrintNumbers(numberM + 1, numberN);
    }

    return sum;
}
