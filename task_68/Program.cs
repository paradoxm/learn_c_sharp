// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29


using LearnCSharpUtils;


int numN = Number.Propmpt("Введите начало диапазона: ");
int numM = Number.Propmpt("Введите конец диапазона: ");

if (!isValid(numN, numM)) return;

int result1 = Ackerman1(numN, numM);
int result2 = Ackerman2(numN, numM);

Console.WriteLine();
Console.WriteLine($"Результат функции Аккермана1: A({numN},{numM}) = {result1}");
Console.WriteLine($"Результат функции Аккермана2: A({numN},{numM}) = {result2}");



bool isValid(int from, int to)
{
    if (from < 1 || to < 0)
    {
        Console.WriteLine("Ввели некорректные числа.");
        return false;
    }

    return true;
}


int Ackerman1(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return Ackerman1(n - 1, 1);

    return Ackerman1(n - 1, Ackerman1(n, m - 1));
}

int Ackerman2(int n, int m)
{
    while (n != 0)
    {
        m = m == 0 ? 1 : Ackerman2(n, m - 1);
        n -= 1;
    };

    return m + 1;
}