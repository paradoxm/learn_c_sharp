// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


using LearnCSharpUtils;


int numberFrom = Number.Propmpt("Введите начало диапазона: ");
int numberTo = Number.Propmpt("Введите конец диапазона: ");

if (numberFrom < 1 || numberTo < 0)
{
    Console.WriteLine("Ввели некорректные числа.");
    return;
}

int min = numberFrom;
int max = numberTo;

if (numberFrom > numberTo)
{
    min = numberTo;
    max = numberFrom;
}

NumturalNumbers(min, max);
Console.WriteLine();



void NumturalNumbers(int from, int to)
{
    if (to < from) return;

    NumturalNumbers(from, to - 1);
    Console.Write($"{to} ");
}