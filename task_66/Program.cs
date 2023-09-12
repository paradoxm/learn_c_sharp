// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


using LearnCSharpUtils;


int numberFrom = Number.Propmpt("Введите начало диапазона: ");
int numberTo = Number.Propmpt("Введите конец диапазона: ");

if (!isValid(numberFrom, numberTo)) return;

int[] range = swapNumberIfNeed(numberFrom, numberTo);
int min = range[0];
int max = range[1];

int sum = SumNumturalNumbers(min, max);

Console.WriteLine();
Console.WriteLine($"Сумма элементов от {min} до {max} равна {sum}");



bool isValid(int from, int to)
{
    if (from < 1 || to < 0)
    {
        Console.WriteLine("Ввели некорректные числа.");
        return false;
    }

    return true;
}

int[] swapNumberIfNeed(int from, int to)
{
    int[] numbersRange = new int[2] { from, to };

    if (numbersRange[0] > numbersRange[1])
    {
        numbersRange[0] = to;
        numbersRange[1] = from;
    }

    return numbersRange;
}


int SumNumturalNumbers(int from, int to)
{
    if (to < from) return 0;
    return to + SumNumturalNumbers(from, to - 1);
}