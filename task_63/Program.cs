// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


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

    NumturalNumbers(num - 1);
    Console.Write($"{num} ");
}