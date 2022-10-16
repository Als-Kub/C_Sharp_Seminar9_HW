// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Clear();

Console.Write("Enter the firt number ");
int numberM = int.Parse(Console.ReadLine()!);

Console.Write("Enter the second number ");
int numberN = int.Parse(Console.ReadLine()!);


Console.WriteLine();
Console.WriteLine($"A(m,n)= {RecAckermannFunction(numberM, numberN)}");


int RecAckermannFunction(int numberM, int numberN)
{

    if (numberM == 0)
    {
        return numberN + 1;
    }
    
    if (numberM > 0 && numberN == 0)
    {
        return RecAckermannFunction(numberM - 1, 1);
    }

    return RecAckermannFunction(numberM - 1, RecAckermannFunction(numberM, numberN - 1));

}

