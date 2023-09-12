// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


using LearnCSharpUtils;


int number = Number.Propmpt("Введите положительное число: ");

if(number < 0) {
    Console.WriteLine("Некорректное число.");
    return;
}

int sum = SumDigits(number);
Console.WriteLine($"Сумма цифр числа {number} равна {sum}");



int SumDigits(int num)
{
    if (num == 0) return num;
    return (num % 10) + SumDigits(num / 10);
}