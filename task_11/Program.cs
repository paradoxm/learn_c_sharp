int randNumber = new Random().Next(100, 999 + 1); // 100 - 999

int shortNumber = RemoveSecondDigit(randNumber);

Console.WriteLine($"Случайное трехзначное число: {randNumber}");
Console.WriteLine($"Результат удаления второго числа: {shortNumber}");



int RemoveSecondDigit(int num)
{
    int first = num / 100;
    int last = num % 10;
    int result = first * 10 + last;

    return result;
}