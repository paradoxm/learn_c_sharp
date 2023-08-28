// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите пятизначное число число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (IsValidNumber(number))
{
    string result = IsPalindrome(number) ? "Число является палиндромом" : "Число не является палиндромом";
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Некорректно введенное число");
}



bool IsValidNumber(int num)
{
    int digitCount = 0;

    while (num != 0)
    {
        num /= 10;
        digitCount++;
    }

    return digitCount == 5;
}

bool IsPalindrome(int num)
{
    int left = ReverseNUmber(num / 1000);
    int right = num % 100;

    return left == right;
}

int ReverseNUmber(int num)
{
    int result = 0;
    int rank = 1;

    while (num != 0)
    {
        result *= rank;
        result += num % 10;
        num /= 10;
        rank *= 10;
    }

    return result;
}