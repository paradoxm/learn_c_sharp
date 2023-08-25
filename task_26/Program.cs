// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());


int digitCount = DigitCount(number);
Console.WriteLine($"Количество цифр для числа {number}: {digitCount}");



int DigitCount(int num)
{
    if (num == 0)
    {
        return 1;
    }

    int count = 0;
    int bufNum = num;

    while (bufNum != 0)
    {
        bufNum /= 10;
        count++;
    }

    return count;
}