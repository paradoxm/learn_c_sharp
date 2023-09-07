// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


int number = Propmpt("Введите число: ");

string binNumberStr = NumberToBinaryStr(number);
int binNumberInt = NumberToBinaryInt(number);

Console.WriteLine($"Десятичное число {number} в двоичной системе равно {binNumberStr}");
Console.WriteLine($"Десятичное число {number} в двоичной системе равно {binNumberInt}");



int Propmpt(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    int result = Convert.ToInt32(input);
    return result;
}


string NumberToBinaryStr(int decNumber)
{
    string result = string.Empty;
    int rest = decNumber;

    while (rest > 0)
    {
        int bit = rest % 2;
        rest /= 2;
        result = bit + result;
    }

    return result;
}


int NumberToBinaryInt(int decNumber)
{
    int result = 0;
    int factor = 1;

    while (decNumber > 0)
    {
        result += decNumber % 2 * factor;
        decNumber /= 2;
        factor *= 10;
    }

    return result;
}
