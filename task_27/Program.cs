// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    Console.WriteLine("Некорректно введенное число");
}
else
{
    int digitSum = SumDigits(number);
    Console.WriteLine($"Сумма цифр в числе {number}: {digitSum}");
}



int SumDigits(int num)
{
    if (num == 0)
    {
        return 0;
    }

    int sum = 0;

    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }

    return sum;
}