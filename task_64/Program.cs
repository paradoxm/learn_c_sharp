// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


using LearnCSharpUtils;


int number = Number.Propmpt("Введите натуральное число: ");

if (number < 1)
{
    Console.WriteLine("Ввели некорректное число.");
    return;
}

NumturalNumbers(number);
Console.WriteLine();



void NumturalNumbers(int num)
{

    if (num == 0) return;

    Console.Write($"{num} ");
    NumturalNumbers(num - 1);
}