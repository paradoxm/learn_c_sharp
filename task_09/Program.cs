int number = new Random().Next(10, 99 + 1);

int maxDigit = MaxDigit(number);

Console.WriteLine($"Случайное число: {number}");
Console.WriteLine($"Максимальное число: {maxDigit}");



int MaxDigit(int num)
{
    int first = num / 10;
    int second = num % 10;
    int max = first > second ? first : second;

    return max;
}